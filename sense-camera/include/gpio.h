#ifndef __GPIO_H_
#define __GPIO_H_

void gpio_init(int pyroelectric_gpio_port, int led_gpio_port);
void gpio_deinit(void);
void led_on(void);
void led_off(void);
int pyreelectric_status_get(void);

#endif
