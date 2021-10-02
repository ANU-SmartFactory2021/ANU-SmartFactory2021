# -*- coding: utf-8 -*-
import cv2
import base64
import argparse
import numpy as np
import time
from pyzbar import pyzbar

cap = cv2.VideoCapture(0)
cap.set(3, 320)
cap.set(4, 320)


def check():
    try:
        if not cap.isOpened():
            print('capture fail')
            cap.release()
            return False
        else:
            print('capture ok')
            return True
    except cv2.error as e:
        print(e)


def qc(data):
    gray = cv2.cvtColor(data, cv2.COLOR_BGR2GRAY)

    gray = cv2.GaussianBlur(gray, (5, 5), 0)
    gray = cv2.medianBlur(gray, 5)
    gray = cv2.adaptiveThreshold(gray, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C,
                                 cv2.THRESH_BINARY, 11, 3.5)
    kernel = np.ones((2, 3), np.uint8)
    gray = cv2.erode(gray, kernel, iterations=1)
    gray = cv2.dilate(gray, kernel, iterations=1)

    circles = cv2.HoughCircles(
        gray, cv2.HOUGH_GRADIENT, 1, 260, param1=30, param2=65, minRadius=0, maxRadius=0)

    if circles is None:
        return False
    else:
        return True


def decode():
    retval, frame = cap.read()
    decoded_objects = pyzbar.decode(frame)
    retval, buffer = cv2.imencode('.jpg', frame)
    converted_string = base64.b64encode(buffer)

    if not decoded_objects:
        print(decoded_objects)
        return "QR_READ_ERROR"
    else:
        for obj in decoded_objects:
            print(obj.data)
            time.sleep(1)
            if qc(frame):
                print('qc : pass')
                return f'<QRCODE:{1234567812}|QUALITY=PASS|{converted_string.decode("utf-8")}>'
                # return f'<QRCODE:{obj.data}|QUALITY=PASS|{converted_string.decode("utf-8")}>'
            else:
                print('qc : fail')
                return f'<QRCODE:{1234567812}|QUALITY=FAIL|{converted_string.decode("utf-8")}>'
                # return f'<QRCODE:{obj.data}|QUALITY=FAIL|{converted_string.decode("utf-8")}>'

# raspistill -v -o test.jpg
# vcgencmd get_camera
