# -*- coding: UTF-8 -*-
import sys,os,dlib,glob,numpy
from skimage import io
import time
class MyRecognition:
    # 候选人脸描述子list
    descriptors = []
    # 候选集初始化
    candidate = []
    # 加载正脸检测器
    detector = dlib.get_frontal_face_detector()
    # 加载人脸关键点检测器
    sp = dlib.shape_predictor("./shape_predictor_68_face_landmarks.dat")
    # 加载人脸识别模型
    facerec = dlib.face_recognition_model_v1("./dlib_face_recognition_resnet_model_v1.dat")
    # img type
    imgType = '.jpg'
 
  
    def __del__(self):
        self.descriptors = []
        self.candidate = []

    def preCalculate(self,faces_folder_path):
        for filename in os.listdir(faces_folder_path):
            if filename.endswith(self.imgType):
                self.candidate.append(filename)
        # 对文件夹下的每一个人脸进行:
        # 1.人脸检测
        # 2.关键点检测
        # 3.描述子提取
        for f in glob.glob(os.path.join(faces_folder_path, "*"+self.imgType)):
        # print("Processing file: {}".format(f))
            img = io.imread(f)
            # 1.人脸检测
            dets = self.detector(img, 1)
            # print("Number of faces detected: {}".format(len(dets)))
            for k, d in enumerate(dets): 
                # 2.关键点检测
                shape = self.sp(img, d)
                # 3.描述子提取，128D向量
                face_descriptor = self.facerec.compute_face_descriptor(img, shape)
                # 转换为numpy array
                v = numpy.array(face_descriptor) 
                self.descriptors.append(v)
    #用以增加需识别用户
    def addAndUpdate(self,targerImg,imgName):
        self.candidate.append(imgName)
        dets = self.detector(targerImg, 1)
        for k, d in enumerate(dets): 
            shape = self.sp(img, d)
            face_descriptor = self.facerec.compute_face_descriptor(img, shape)
            v = numpy.array(face_descriptor) 
            self.descriptors.append(v)

    def recognition(self,targerImg):
        # 对需识别人脸提取描述子
        dets = self.detector(targerImg, 1)
        dist = []
        for k, d in enumerate(dets):
            shape = self.sp(targerImg, d)
            face_descriptor = self.facerec.compute_face_descriptor(targerImg, shape)
            d_test = numpy.array(face_descriptor) 
            # 计算欧式距离
            for i in self.descriptors:
                dist_ = numpy.linalg.norm(i-d_test)
                dist.append(dist_)
        # print(dist)
        # 候选人和距离组成一个dict
        c_d = dict(zip(self.candidate,dist))
        cd_sorted = sorted(c_d.items(), key=lambda d:d[1])
        if cd_sorted == None or len(cd_sorted)==0:
            print("this pic no face!")
            return "noPerson"
        if len(cd_sorted[0])==0:
            print("this pic no face!")
            return "noPerson"
        if cd_sorted[0][1] > 0.35:
            print("The person is: others",cd_sorted[0][1])
            return "others"
        else:
            print("The person is: ",cd_sorted[0][0],cd_sorted[0][1])
            return cd_sorted[0][0]
'''
# test
mr = MyRecognition()
mr.preCalculate("./candidate-faces/")
#print(candidate)
start = time.time()
img1 = io.imread('4.jpg')
mr.recognition(img1)
end = time.time()
print("recognition cost time %f"%(end-start))
'''