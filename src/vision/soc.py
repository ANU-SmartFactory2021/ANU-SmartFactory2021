import socket
import threading

def Recv():
    recv_data = client_socket.recv(1024).decode('utf-8')
    return recv_data

def Send(send_data):
    client_socket.send(send_data.encode())
    return send_data

def SendQR(send_data):
    client_socket.send(send_data)
    return send_data

client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
ip = '127.0.0.1'
port = 1234
client_socket.connect((ip, port))

recv_thread = threading.Thread(target=Recv, args=(client_socket, ))
send_thread = threading.Thread(target=Send, args=(client_socket, ))