# -*- coding: utf-8 -*-
from socket import SocketIO
from cv2 import QRCodeDetector
import qr
import soc
import time


print('start')
soc.connect()
soc.send('CLIENT_TYPE=INSPECTION')


while True:
    time.sleep(1)
    print('waiting server...')
    recv_data = soc.recv()
    print(recv_data)
    if recv_data == 'ack\n':
        break


soc.send('PI_ONE_STATE=READY')
print('pi ready')


while True:
    time.sleep(1)
    try:
        recv_data = soc.recv()
        if recv_data == 'REQUEST_START\n':
            if qr.check:
                soc.send('PI_ONE_STATE=START')
            else:
                soc.send('PI_ONE_STATE=FAIL')

        if recv_data == 'CAPTURE_START\n':
            while True:
                qrdata = qr.decode()
                if qrdata == "QR_READ_ERROR":
                    continue
                else:
                    temp = str(qrdata).split('|')[0]
                    if temp not in str(qr.decode()).split('|')[0]:
                        print("ok")
                        soc.send(qrdata)
                    else:
                        continue
    except BlockingIOError as e:
        print(e)
