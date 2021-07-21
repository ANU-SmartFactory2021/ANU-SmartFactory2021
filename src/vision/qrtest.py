import cv2
from pyzbar import pyzbar
from socket import *

#tcp
def tcp(barcode):
    ip = "127.0.0.1"
    port = 1234

    clientsocket = socket(AF_INET, SOCK_STREAM)
    clientsocket.connect((ip, port))
    print("connected")
    clientsocket.send(barcode)

    # server receive
    # data = clientsocket.recv(1024)
    # print("recv :", data.decode("UTF-8"))

# barcode read
def read_barcodes(frame):
    barcodes = pyzbar.decode(frame)
    for barcode in barcodes:
        x, y , w, h = barcode.rect
        barcode_info = barcode.data.decode('utf-8')
        cv2.rectangle(frame, (x, y),(x+w, y+h), (0, 255, 0), 2)

        #send barcode data
        tcp(barcode.data)
        font = cv2.FONT_HERSHEY_DUPLEX
        cv2.putText(frame, barcode_info, (x + 6, y - 6), font, 2.0, (255, 255, 255), 1)
        with open("barcode_result.txt", mode ='w') as file:
            file.write("Recognized Barcode:" + barcode_info)    
    return frame

def main():
    camera = cv2.VideoCapture('http://192.168.0.64:4747/video')
    # camera = cv2.VideoCapture(0)
    ret, frame = camera.read()
    while ret:
        ret, frame = camera.read()
        frame = read_barcodes(frame)
        cv2.imshow('Barcode/QR code reader', frame)

        #esc == break
        if cv2.waitKey(1) & 0xFF == 27:
            break
    camera.release()
    cv2.destroyAllWindows()

if __name__ == '__main__':
    main()