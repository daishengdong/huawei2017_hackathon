#!/usr/bin/python

#encoding=utf8
from socket import *
import traceback
import time
import ctypes
import platform
import os
from skimage import io 
import recognition as rg
import threading
#from PIL import Image
#import binascii
#import io
image_index = 0
def callfacereg(img):
    #print(img)
    global image_index
    f = open(str(image_index)+'_recv.jpg', 'wb')
    print(str(image_index)+'_recv.jpg')
    f.write(img);
    f.close();
    img2 = io.imread(str(image_index)+'_recv.jpg')
    image_index += 1
    '''
    r_data = binascii.hexlify(img)
    stream = io.BytesIO(r_data)
    img2 = Image.open(stream)
    '''
    ret = mr.recognition(img2)   
    print("face reg")
    return ret

def sendtowin():
    HOST = '192.168.199.176'  # The remote host
    PORT = 50007  # The same port as used by the server
    print("sendtowin")
    s = socket(AF_INET, SOCK_STREAM)
    s.connect((HOST, PORT))
    print("sendtowin connect")
    s.send('winlock'.encode("utf-8"))
    #data = s.recv(1024)
    s.close()
    print('Received')
    pass


def runserver():
    HOST = '192.168.199.127'  # Symbolic name meaning all available interfaces
    PORT = 50007              # Arbitrary non-privileged port
    s = socket(AF_INET, SOCK_STREAM)
    s.bind((HOST, PORT))
    
    s.listen(10)
    l = []

    while True:
        conn, addr = s.accept()
        print('Connected by', addr)
        c = Server(conn)
        c.start()
        l.append(c)

class Server(threading.Thread):
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
                if not data: break
                if RECEIVE_FILE != status:
                    print('data',data)
                if RECEIVE_FILE == status:
                    FileBuffer += data
                    recivesize -= len(data)
                    if recivesize == 0:
                        ret = callfacereg(FileBuffer)
                        if ret == "others":
                            self.conn.send(b"failed")
                        elif ret == "noPerson":
                            self.conn.send(b"failed")
                        else:
                            self.conn.send(b"unlock")
                        status = LOOPWAIT
                        FileBuffer = b""
                    continue
                if RECEIVE_FILE_SIZE == status:
                    recivesize = int(data)
                    self.conn.send(b"OK")
                    status = RECEIVE_FILE
                    continue
                if data == b'img':
                    self.conn.send(b"OK")
                    status = RECEIVE_FILE_SIZE
                    continue
                if data == b'winlock':
                    sysstr = platform.system()
                    if sysstr == "Windows":
                        dll = ctypes.WinDLL('user32.dll');
                        dll.LockWorkStation();
                        time.sleep(1)
                        os.system("nircmd.exe monitor off")
                    else:
                        sendtowin()
            #    self.conn.send(data)
        except Exception as e:
            self.conn.close()

if __name__=="__main__":
    mr = rg.MyRecognition()
    mr.preCalculate("./candidate-faces/")
    while True:
        try:
            runserver()
        except Exception as e:
            print("Error",e)
            traceback.print_exc()
            time.sleep(5)
