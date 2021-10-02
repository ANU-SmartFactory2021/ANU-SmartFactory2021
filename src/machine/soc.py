
# -*- coding: utf-8 -*-

import socket
import threading
import errno
import select

def recv():
    try:
        recv_data = client_socket.recv(256).decode('utf-8')
    except BlockingIOError:
        return ""
    return recv_data


def send(send_data):
    try:
        client_socket.sendall(send_data.encode())
    except socket.error as e:
        if e.errno != errno.EAGAIN:
            raise e
        print('Blocking with', len(send_data), 'remaining')
        select.select([], [client_socket], [])


def connect():
    try:
        client_socket.connect((ip, port))
        client_socket.setblocking(False)
        #print("connected")
    except socket.error as e:
        print(f"error while connecting : {e}")
        return False


client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
#client_socket.setblocking(False)

# 서버
#ip = '127.0.0.1'
ip = '192.168.0.8'
port = 9999

# recv_thread = threading.Thread(target=recv, args=(client_socket,))
# send_thread = threading.Thread(target=send, args=(client_socket,))
