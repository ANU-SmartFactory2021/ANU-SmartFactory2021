import cv2
import argparse
import numpy as np
from pyzbar import pyzbar

cap = cv2.VideoCapture('http://192.168.0.64:4747/video')
cap.set(3, 320)
cap.set(4, 320)

def qc(data):
    gray = cv2.cvtColor(data, cv2.COLOR_BGR2GRAY)

    gray = cv2.GaussianBlur(gray, (5, 5), 0)
    gray = cv2.medianBlur(gray, 5)
    gray = cv2.adaptiveThreshold(gray, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C,
                                 cv2.THRESH_BINARY, 11, 3.5)
    kernel = np.ones((2, 2), np.uint8)
    gray = cv2.erode(gray, kernel, iterations=1)
    gray = cv2.dilate(gray, kernel, iterations=1)

    circles = cv2.HoughCircles(gray, cv2.HOUGH_GRADIENT, 1, 260, param1=30, param2=65, minRadius=0, maxRadius=0)

    if circles is None:
        return False
    else:
        return True

while True:

    retval, frame = cap.read()
    decoded_objects = pyzbar.decode(frame)
    retval, buffer = cv2.imencode('.jpg', frame)

    if qc(frame):
        print('qc:pass')
        for obj in decoded_objects:
            printf({obj.data})
    else:
        print('qc:fail')
        for obj in decoded_objects:
            printf({obj.data})
