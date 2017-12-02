#ifndef __NETWORK_H_
#define __NETWORK_H_

int network_init(const char *ip, unsigned short port);
int network_deinit(void);
void network_send(const char *msg, size_t len);
int network_transfer(const char *image_path, void *priv);

#endif
