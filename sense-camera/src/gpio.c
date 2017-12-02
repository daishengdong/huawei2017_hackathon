#include <wiringPi.h>

#include "gpio.h"

/**
 * A program to handle LEDs & pyroelectric module though GPIO..
 *
 * @author: ShengdongDai /d00347338
 */

int pyroelectric_gpio_port = -1;
int led_gpio_port = -1;

void gpio_init(int p_pyroelectric_gpio_port, int p_led_gpio_port) {
	wiringPiSetup();

	pinMode(p_pyroelectric_gpio_port, INPUT); // set mode to input
	pinMode(p_led_gpio_port, OUTPUT); // set mode to output


    digitalWrite(p_pyroelectric_gpio_port, 0);
    digitalWrite(p_led_gpio_port, 0);

    pyroelectric_gpio_port = p_pyroelectric_gpio_port;
    led_gpio_port = p_led_gpio_port;
}

void led_on(void) {
    if (led_gpio_port == -1)
        return;
    digitalWrite(led_gpio_port, 1);
}

void led_off(void) {
    if (led_gpio_port == -1)
        return;
    digitalWrite(led_gpio_port, 0);
}

int pyreelectric_status_get(void) {
    if (pyroelectric_gpio_port == -1)
        return 0;
    return digitalRead(pyroelectric_gpio_port);
}

void gpio_deinit(void) {
    pyroelectric_gpio_port = -1;
    led_gpio_port = -1;
}
