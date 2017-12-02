#include <stdio.h>
#include <stdlib.h>

#include "camera.h"

#ifdef USING_OPENCV
#include "opencv.hpp"
#endif

/**
 * A program to capture an image from camera using OpenCV or raspistill tool.
 *
 * @author: ShengdongDai /d00347338
 */

#ifdef USING_OPENCV
CvCapture* pCapture = NULL;
#endif

void camera_init(void) {
#ifdef USING_OPENCV
    pCapture = cvCreateCameraCapture(0);
    cvSetCaptureProperty(pCapture, CV_CAP_PROP_FRAME_WIDTH, 640);
    cvSetCaptureProperty(pCapture, CV_CAP_PROP_FRAME_HEIGHT, 480);

    cvSetCaptureProperty(pCapture, CV_CAP_PROP_BRIGHTNESS, 20);
    cvSetCaptureProperty(pCapture, CV_CAP_PROP_CONTRAST, 10);
#endif
}

int camera_capture(void) {
#ifdef USING_OPENCV
    if (NULL == pCapture) {
        perror("camera not init!\n");
        return -1;
    }

    IplImage *image_frame = 0;

    image_frame = cvQueryFrame(pCapture); // query a frame

    if (NULL == image_frame) {
        perror("get frame failed!\n");
        return -1;
    }

    cvSaveImage(IMAGE_PATH, image_frame);
#else
    system("/opt/vc/bin/raspistill -o " IMAGE_PATH " -w 800 -h 600 -br 50 --nopreview --exposure sports --timeout 1");
#endif

    return 0;
}

void camera_deinit(void) {
#ifdef USING_OPENCV
    cvReleaseCapture(&pCapture); // free memory
#endif
}
