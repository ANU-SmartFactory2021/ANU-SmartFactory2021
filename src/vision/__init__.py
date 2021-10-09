# -*- coding: utf-8 -*-
import qr
import soc
import time


print('start')
soc.connect()
soc.send('<CLIENT_TYPE=INSPECTION>')

while True:
    time.sleep(1)
    print('waiting server...')
    recv_data = soc.recv()
    print(recv_data)
    if recv_data == 'ack':
        break


soc.send('<PI_ONE_STATE=READY>')
print('pi ready')
qr.final()

capture_start = False
while True:

    try:
        recv_data = soc.recv()
        if recv_data == '<CMD=REQUEST_START>':
            qr.init()
            if qr.check():
                soc.send('<PI_ONE_STATE=START>')
                qr.final()
            else:
                soc.send('<PI_ONE_STATE=FAIL')
                qr.final()

        if recv_data == '<CMD=CAPTURE_START>':
            # if recv_data == 'aa\n':
            soc.send('<RECV_ACK>')
            capture_start = True
            qr.init()

        if recv_data == '<CMD=CAPTURE_STOP>':
            # if recv_data == 'bb\n':
            soc.send('PI_ONE_STATE=STOP')
            capture_start = False
            print(capture_start)
            qrdata = None
            qr.final()

        if capture_start == True:
            qrdata = qr.decode()

            if qrdata != "QR_CODE_ERROR" and qrdata != None:
                soc.send(qrdata)
                capture_start = False
                print('img send')
                qrdata = None
                qr.final()

            """while True:
                recv_data = soc.recv()
                qrdata = qr.decode()

                if qrdata != "QR_CODE_ERROR":
                    temp = qrdata.split('|')[0]
                    temp1 = qr.decode().split('|')[0]
                    if temp != temp1 and temp1 is not None:
                        print('img send')
                        soc.send(qrdata)

                if recv_data == '<CMD=CAPTURE_STOP>':
                    soc.send('PI_ONE_STATE=STOP')
                    break"""

    except BlockingIOError as e:
        print(e)
