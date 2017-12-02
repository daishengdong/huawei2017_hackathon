#include <wiringPi.h>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <time.h>

#include "uart.h"
#include "camera.h"
#include "network.h"
#include "gpio.h"

/**
 * Entry of the whole show.
 *
 * @author: ShengdongDai /d00347338
 */

#define MAGIC_CODE_UNLOCK   "s0123456789e"
#define MAGIC_CODE_LOCK     "winlock"

const int PYROELECTRIC_GPIO_PORT = 7;
const int LED_GPIO_PORT = 0;


static inline bool verify_user(void) {
    int result = 0;

    // get a frame
    if (camera_capture() != 0) {
        printf("camera_capture failed!\n");
        return false;
    }

    if (network_transfer(IMAGE_PATH, &result) != 0) {
        printf("network_transfer failed!\n");
        return false;
    }
    
    return result == 1;
}

static inline void unlock(void) {
    uart_output(MAGIC_CODE_UNLOCK, 12);
}

static inline void lock(void) {
    network_send(MAGIC_CODE_LOCK, 7);
}

int main(int argc, char* argv[]) {
    while (true) {
        try {
            if (uart_init() != 0) {
                perror("uart_init error!\n");
                return -1;
            }

            if (network_init("192.168.199.127", 50007) != 0) {
                perror("network_init error!\n");
                return -1;
            }

            gpio_init(PYROELECTRIC_GPIO_PORT, LED_GPIO_PORT);
            camera_init();

            led_off();

            int last_status = 0;
            bool need_lock = false;
            bool need_unlock = true;
            time_t last_moving_time = time((time_t *)NULL);
            time_t cur_time = time((time_t *)NULL);

            while (true) {
                int cur_status = pyreelectric_status_get();

                cur_time = time((time_t *)NULL);

                if (need_lock && cur_time - last_moving_time >= 10) {
                    if (verify_user()) {
                        last_moving_time = time((time_t *)NULL);
                        continue;
                    }

                    lock();
                    need_lock = false;
                    need_unlock = true;
                    led_off();
                    led_on();
                    led_off();
                    printf("LOCK!\n");
                    continue;
                }

                if (cur_status == 1 || cur_status != last_status) {
                    last_moving_time = time((time_t *)NULL);
                    last_status = cur_status;

                    if (!need_unlock)
                        continue;

                    led_on();


                    if (verify_user()) {
                        unlock();
                        led_off();
                        led_on();
                        led_off();
                        need_lock = true;
                        need_unlock = false;
                        printf("UNLOCK!\n");
                    }
                    // delay(10);
                }
            }
        } catch (...) {
            uart_deinit();
            network_deinit();
            gpio_deinit();
            camera_deinit();
            led_off();
        }
    }

    return 0;
}
