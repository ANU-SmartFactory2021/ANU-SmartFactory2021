import cv2
import socket
import time
import base64


img = cv2.imread('test.jpg', cv2.IMREAD_UNCHANGED)

cv2.imshow('image', img)
cv2.waitKey(0)
cv2.destroyAllWindows()



host_ip = '127.0.0.1'
port_num = 12345

client_socket = socket.socket( socket.AF_INET, socket.SOCK_STREAM )
client_socket.connect( ( host_ip, port_num ) )
client_socket.sendall( 'CLIENT_TYPE=INSPECTION'.encode() )

while True :
    time.sleep(1)
    print( 'wating server...' )
    recv_data = client_socket.recv( 256 )
    if recv_data == b'ack' :
        break


with open("test.jpg", "rb") as img_file:
    converted_string = base64.b64encode(img_file.read())


data = '<' + 'QRCODE=1234567890|' + converted_string.decode('utf-8') + '>'
client_socket.sendall( data.encode() )
client_socket.close()
