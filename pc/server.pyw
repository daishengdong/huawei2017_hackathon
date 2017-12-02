#encoding=utf8
from socket import *
import time
import ctypes
import platform
import os
import threading


def callfacereg(img):
    print("face reg")


def sendtowin():
    HOST = '192.168.199.176'  # The remote host
    PORT = 50007  # The same port as used by the server
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.connect((HOST, PORT))
    s.send('winlock'.encode("utf-8"))
    data = s.recv(1024)
    s.close()
    print('Received', repr(data))
    pass


def runserver():
    HOST = '192.168.199.176'  # Symbolic name meaning all available interfaces
    PORT = 50007              # Arbitrary non-privileged port
    s = socket(AF_INET, SOCK_STREAM)
    s.bind((HOST, PORT))
    s.listen(10)
    l = []
    while True:
        conn, addr = s.accept()
        print('Connected by', addr)
        c = Client(conn)
        c.start()
        l.append(c)
    

class Client(threading.Thread):
    conn = None

    def __init__(self,conn):
        threading.Thread.__init__(self)
        self.conn = conn

    def run(self):
        #server status
        LOOPWAIT = 0
        RECEIVE_FILE = 1
        RECEIVE_FILE_SIZE = 2

        status = LOOPWAIT
        FileBuffer = b""
        recivesize = 0
        try:
            while True:
                if RECEIVE_FILE == status and recivesize <= 1024:
                    data = self.conn.recv(recivesize)
                else:
                    data = self.conn.recv(1024)
                print(data)
                if not data: break
                if RECEIVE_FILE == status:
                    FileBuffer += data
                    recivesize -= len(data)
                    if recivesize == 0 and callfacereg(FileBuffer):
                        self.conn.send("unlock")
                    else:
                        self.conn.send("failed")
                if RECEIVE_FILE_SIZE == status:
                    recivesize = int(data)
                if data == b'img':
                    self.conn.send(b"OK")
                    status = RECEIVE_FILE_SIZE
                if data == b'winlock':
                    sysstr = platform.system()
                    if  sysstr == "Windows":
                        dll = ctypes.WinDLL('user32.dll');
                        dll.LockWorkStation();
                        time.sleep(1)
                        os.system("nircmd.exe monitor off")
                        #self.conn.send("OK")
                        continue
                    else:
                        sendtowin()
                        self.conn.send("OK")
                        continue
                self.conn.send(data)
        except:
            self.conn.close()

if __name__=="__main__":
    while True:
        try:
            runserver()
        except:
            time.sleep(5)
