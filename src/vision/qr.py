import cv2
from pyzbar import pyzbar

def decode():

    cap = cv2.VideoCapture("http://192.168.0.64:4747/video")
    ret, frame = cap.read()
    decodedObjects = pyzbar.decode(frame)

    print(decodedObjects)

    if decodedObjects == []:
        return "QR_READ_ERROR".encode()
    else:
        for obj in decodedObjects:
            return "QRCODE="+obj.data
