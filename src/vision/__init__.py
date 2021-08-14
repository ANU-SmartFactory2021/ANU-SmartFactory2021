import qr
import soc

# dummy
check = True

soc.Send('PI_ONE_STATE=READY')
print('test start')
while True:
    recv_data = soc.Recv()
    if recv_data == 'REQUEST_START':
        if check:
            soc.Send('PI_ONE_STATE=START')
        else:
            soc.Send('PI_ONE_STATE=FAIL')

    if recv_data == 'CAPTURE_START':
        soc.SendQR(qr.decode())
