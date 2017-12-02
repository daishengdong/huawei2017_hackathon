#ifndef __UART_H_
#define __UART_H_

int uart_init(void);
int uart_deinit(void);
int uart_output(const char *msg, size_t len);

#endif
