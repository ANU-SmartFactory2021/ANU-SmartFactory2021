# -*- coding: utf-8 -*-
import cv2
import base64
import os

from pyzbar import pyzbar

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
    #카메라 주소
    cap = cv2.VideoCapture(0)
    ret, frame = cap.read()

    decoded_objects = pyzbar.decode(frame)
    cv2.imwrite("image.jpg", frame)
    with open("image.jpg", "rb") as img_file:
        converted_string = base64.b64encode(img_file.read())

    os.remove("image.jpg")
    print(decoded_objects)

    if not decoded_objects:
        return "QR_READ_ERROR"
    else:
        for obj in decoded_objects:
            return f'<QR:{obj.data}|{converted_string.decode("utf-8")}>'