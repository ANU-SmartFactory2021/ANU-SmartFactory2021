import qr
import soc
import time
# dummy

print('start')
check = True

soc.send('CLIENT_TYPE=INSPECTION')

while True:
    time.sleep(1)
    print('waiting server...')
    recv_data = soc.recv()
    print(recv_data)
    if recv_data == "ack":
        break

soc.send('PI_ONE_STATE=READY')

while True:
    recv_data = soc.recv()
    if recv_data == 'REQUEST_START':
        if check:
            soc.send('PI_ONE_STATE=START')
        else:
            soc.send('PI_ONE_STATE=FAIL')

    if recv_data == 'CAPTURE_START':
        soc.send(qr.decode())
