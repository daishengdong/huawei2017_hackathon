#include <stdlib.h>
#include <sys/types.h>
#include <stdio.h>
#include <sys/socket.h>
#include <arpa/inet.h>
#include <string.h>
#include <unistd.h>
#include <sys/stat.h>
#include <fcntl.h>

#include "network.h"

/**
 * a program to handler network image transfer
 *
 * author: ShengdongDai /d00347338
 */

#define IMAGEFILESIZE (640 * 320 * 3)

int socket_fd;

// image file buffer
char image[IMAGEFILESIZE] = {0x01,0x02};

int network_init(const char *ip, unsigned short port) {
    struct sockaddr_in s_add, c_add; 

    /* 建立socket 使用因特网，TCP流传输 */
    socket_fd = socket(AF_INET, SOCK_STREAM, 0);
    if (-1 == socket_fd) {
        perror("socket fail!\n");
        close(socket_fd);
        return -1;
    }

    /* 构造服务器端的ip和端口信息，具体结构体可以查资料 */
    bzero(&s_add, sizeof(struct sockaddr_in));
    s_add.sin_family = AF_INET;
    s_add.sin_addr.s_addr = inet_addr(ip); /* ip转换为4字节整形，使用时需要根据服务端ip进行更改 */
    s_add.sin_port = htons(port);


    /* 客户端连接服务器，参数依次为socket文件描述符，地址信息，地址结构大小 */
    if (-1 == connect(socket_fd, (struct sockaddr *)(&s_add), sizeof(struct sockaddr))) {
        perror("connect fail!\n");
        close(socket_fd);
        return -1;
    }

    return 0;
}

static inline int file_size_get(const char *image_path) {
    struct stat buf;
    if (stat(image_path, &buf) < 0)
        return -1;

    return buf.st_size;
}

static inline int buffer_set(const char *image_path, int file_size) {
    int fd = open(image_path, O_RDONLY);
    int ret = read(fd, image, file_size);
    if (ret != file_size) {
        printf("read image failed!\n");
        close(fd);
        return -1;
    }

    close(fd);
    return 0;
}

static inline int data_prepare(const char *image_path, int *file_size) {
    *file_size = file_size_get(image_path);
    if (*file_size == -1) {
        printf("file_size_get failed!\n");
        return -1;   
    }

    if (*file_size > IMAGEFILESIZE) {
        printf("image too large!\n");
        return -1;   
    }

    if (buffer_set(image_path, *file_size) != 0) {
        printf("read image failed!\n");
        return -1;   
    }

    return 0;
}

void network_send(const char *msg, size_t len) {
    // we just deliver it
    write(socket_fd, msg, len);
}

int network_transfer(const char *image_path, void *priv) {
    int recbytes;
    int sin_size;
    int file_size;
    char buffer[1024] = {0};

    if (data_prepare(image_path, &file_size) != 0) {
        printf("data_prepare failed!\n");
        return -1;
    }

    // send img string
    if (-1 == write(socket_fd, "img", 3))  {  
        printf("write fail!\n");  
        return -1;  
    }

    /* 连接成功,从服务端接收字符 */
    if (-1 == (recbytes = read(socket_fd, buffer, 1024))) {
        printf("read data fail !\n");
        return -1;
    }
    printf("read ok REC: ");

    buffer[recbytes] = '\0';
    printf("%s\n", buffer);
    if (strcmp("OK", buffer) != 0) {
        printf("receive not right!\n");
        return -1;
    }

    // send file length
    char filesize[20];
    sprintf(filesize, "%d", file_size);
    int len = strlen(filesize);
    if (-1 == write(socket_fd, filesize, len)) {  
        printf("write fail!\n");  
        return -1;  
    }
    if (-1 == (recbytes = read(socket_fd, buffer, 1024))) {
        printf("read data fail !\n");
        return -1;
    }
    buffer[recbytes] = '\0';

    if (strcmp("OK", buffer) != 0){
        printf("send file length, return %s\n", buffer);
    }

    // send image file
    if (-1 == write(socket_fd, image, file_size)) {
        printf("write fail!\n");  
        return -1; 
    }

    if (-1 == (recbytes = read(socket_fd, buffer, 1024))) {
        printf("read data fail !\n");
        return -1;
    }
    buffer[recbytes] = '\0';
    printf("send file success, return %s\n", buffer);

    if (priv != NULL)
        if (strcmp("unlock", buffer) == 0)
            *(int *)priv = 1;
        else
            *(int *)priv = 0;

    return 0;
}

int network_deinit(void) {
    return close(socket_fd);
}
