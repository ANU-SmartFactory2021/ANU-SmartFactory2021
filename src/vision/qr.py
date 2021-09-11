# -*- coding: utf-8 -*-
import cv2
import base64
import numpy
from pyzbar import pyzbar


cap = cv2.VideoCapture(0)
cap.set(3, 640)
cap.set(4, 480)


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
            return f'<QR:{obj.data}|{converted_string.decode("utf-8")}>'

# raspistill -v -o test.jpg
# vcgencmd get_camera
