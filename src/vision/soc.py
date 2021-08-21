import socket
import threading


def recv():
    recv_data = client_socket.recv(256).decode('utf-8')
    return recv_data


def send(send_data):
    client_socket.sendall(send_data.encode())
    return send_data

client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

# 서버
ip = '127.0.0.1'
port = 9999
client_socket.connect((ip, port))

recv_thread = threading.Thread(target=recv, args=(client_socket,))
send_thread = threading.Thread(target=send, args=(client_socket,))
