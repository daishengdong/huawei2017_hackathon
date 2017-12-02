#!/bin/bash
# A script to control some LEDs through an pyroelectric module.

CURRENT_DIR=`dirname "$0"`
WORKING_HOME=`cd "$CURRENT_DIR"; pwd`

# input mode port
PYROELECTRIC_MODULE_GPIO_PORT=7

# output mode ports
LED_GPIO_PORT_1=0
LED_GPIO_PORT_2=1

SRC_FILE=$WORKING_HOME/src/sense_camera.cpp
BIN_FILE=$WORKING_HOME/out/sense_camera



# sudo modprobe ch341
# sudo stty -F /dev/ttyAMA0 115200

# sudo modprobe bcm2835-v4l2

rm $BIN_FILE

# compile the source code if the executable bin not exists
if [ ! -f $BIN_FILE ]; then
    echo "Compiling $SRC_FILE ..."
    g++ -I include -c src/uart.c -o out/uart.o
    g++ -I include -c src/gpio.c -o out/gpio.o
    g++ -I include -c src/network.c -o out/network.o
    g++ -I/usr/include/opencv2/ -I include `pkg-config --cflags opencv --libs opencv` -c src/camera.c -o out/camera.o
    g++ -I include `pkg-config --cflags opencv --libs opencv` $SRC_FILE out/gpio.o out/uart.o out/camera.o out/network.o -o $BIN_FILE -lwiringPi
    if [ $? -ne 0 ]; then
	echo "Failed to compile $SRC_FILE"
	exit 1
    fi
fi

# run the program
echo "Running $BIN_FILE ..."
$BIN_FILE
