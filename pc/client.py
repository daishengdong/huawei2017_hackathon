#encoding=utf8
import socket

def client():
    HOST = '192.168.199.176'  # The remote host
    PORT = 50007  # The same port as used by the server
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.connect((HOST, PORT))
    s.send('winlock'.encode("utf-8"))
    data = s.recv(1024)
    s.close()
    print('Received', repr(data))


if __name__=="__main__":
    client()


