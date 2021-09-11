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
    print('waiting...')
    try:
        recv_data = soc.recv()
        if recv_data == 'REQUEST_START\n':
            if qr.check():
                soc.send('PI_ONE_STATE=START')
            else:
                soc.send('PI_ONE_STATE=FAIL')

        if recv_data == 'CAPTURE_START\n':
            while True:
                recv_data = soc.recv()
                qrdata = qr.decode()
                if qrdata != "QR_CODE_ERROR":
                    temp = qrdata.split('|')[0]
                    temp2 = qr.decode()
                    if temp != temp2 and temp2 != "QR_CODE_ERROR":
                        print('changed')
                        soc.send(qrdata)
                if recv_data == 'CAPTURE_STOP\n':
                    break

    except BlockingIOError as e:
        print(e)
