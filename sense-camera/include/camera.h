#ifndef __CAMERA_H
#define __CAMERA_H

#define IMAGE_PATH  "out/webcam.jgp"

void camera_init(void);
void camera_deinit(void);
int camera_capture(void);

#endif
