import cv2
import argparse
import numpy as np
import time
from pyzbar import pyzbar


def qc(data):
    
    gray = cv2.cvtColor(data, cv2.COLOR_BGR2GRAY)

    gray = cv2.GaussianBlur(gray, (5, 5), 0)
    gray = cv2.medianBlur(gray, 5)
    gray = cv2.adaptiveThreshold(gray, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C,
                                 cv2.THRESH_BINARY, 11, 3.5)
    kernel = np.ones((2, 3), np.uint8)
    gray = cv2.erode(gray, kernel, iterations=1)
    gray = cv2.dilate(gray, kernel, iterations=1)

    circles = cv2.HoughCircles(gray, cv2.HOUGH_GRADIENT, 1, 200, param1=50, param2=200, minRadius=30, maxRadius=0)
    if circles is None:
        return False
    else:
        return True


while True:
    cap = cv2.VideoCapture(0)
    cap.set(3, 320)
    cap.set(4, 320)
    
    retval, frame = cap.read()
    obj = pyzbar.decode(frame)

    if qc(frame):
        print(obj)
        print('circle')
        
    else:
        print(obj)
        print('error')
    cap.release()
    obj = None
    time.sleep(1)
"""while True:

    retval, frame = cap.read()
    decoded_objects = pyzbar.decode(frame)
    retval, buffer = cv2.imencode('.jpg', frame)

    if qc(frame):
        print('qc:pass')
    else:
        print('qc:fail')
    for obj in decoded_objects:
        print(obj.data)

"""
