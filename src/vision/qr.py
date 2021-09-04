# -*- coding: utf-8 -*-
import cv2
import base64
import os
import numpy as np
from pyzbar import pyzbar


cap = cv2.VideoCapture(0)


def check():
    try:
        cap = cv2.VideoCapture(0)
        if not cap.isOpened():
            return False
        else:
            return True
    except cv2.error as e:
        print(e)


def decode():
    retval, frame = cap.read()
    retval, buffer = cv2.imencode('.jpg', frame)
    decoded_objects = pyzbar.decode(frame)
    converted_string = base64.b64encode(buffer)

    if not decoded_objects:
        print(decoded_objects)
        return "QR_READ_ERROR"
    else:
        for obj in decoded_objects:
            print(obj.data)
            return f'<QR:{obj.data}|{converted_string.decode("utf-8")}>'
