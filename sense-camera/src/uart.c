#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <string.h>
#include <errno.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <fcntl.h>
#include <termios.h>

#include "uart.h"

/**
 * A program to handle uart
 *
 * author: ShengdongDai /d00347338
 */

#define BAUDRATE    B115200 // Baud rate : 115200
#define DEVICE      "/dev/ttyAMA0"
#define SIZE        1024

int uart_fd = 0;

// Open Port & Set Port
int uart_init(void) {
    struct termios tios_new;
    struct termios tios_save;

    uart_fd = open(DEVICE, O_RDWR | O_NOCTTY | O_NDELAY);
    if (-1 == uart_fd) {
        perror("open serial port error!\n");
        return -1;
    }

    if (fcntl(uart_fd, F_SETFL, 0) < 0) {
        perror("fcntl F_SETFL error!\n");
        return -1;
    }

    if (tcgetattr(uart_fd, &tios_save) != 0) {
        perror("tcgetattr error!\n");
        return -1;
    }

    tios_new = tios_save;
    cfmakeraw(&tios_new); //将终端设置为原始模式，该模式下所有的输入数据以字节为单位被处理

    // set speed
    cfsetispeed(&tios_new, BAUDRATE); // 115200
    cfsetospeed(&tios_new, BAUDRATE);

    // set databits  
    tios_new.c_cflag |= (CLOCAL | CREAD);
    tios_new.c_cflag &= ~CSIZE;
    tios_new.c_cflag |= CS8;

    // set parity  
    tios_new.c_cflag &= ~PARENB;  
    tios_new.c_iflag &= ~INPCK;

    // set stopbits  
    tios_new.c_cflag &= ~CSTOPB;
    tios_new.c_cc[VTIME] = 0; // 指定所要读取字符的最小数量
    tios_new.c_cc[VMIN] = 1; // 指定读取第一个字符的等待时间，时间的单位为n*100ms
    // 如果设置VTIME=0，则无字符输入时read（）操作无限期的阻塞
    tcflush(uart_fd, TCIFLUSH); // 清空终端未完成的输入/输出请求及数据。
    if (tcsetattr(uart_fd, TCSANOW, &tios_new) != 0) {
        perror("tcsetattr error!\n");
        return -1;
    }

    return 0;
}

int uart_output(const char *msg, size_t len) {
    int ret = 0;
    char buf[SIZE];

    bzero(buf, SIZE);
    write(uart_fd, msg, len);

    return 0;
}

int uart_deinit(void) {
    return close(uart_fd);
}
