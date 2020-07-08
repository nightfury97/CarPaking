import io
import os
from google.cloud import vision_v1p3beta1 as vision
from google.cloud.vision import types
from datetime import datetime
import cv2
import imutils
import paho.mqtt.client as mqtt
import time
# Setup google authen client key
os.environ['GOOGLE_APPLICATION_CREDENTIALS'] = 'client_key.json'

# Source path content all images
SOURCE_PATH = "D:/Driver/DoAnTuan/recognize-license-plate/anh/"

def on_message(client, userdata, message):
    mes = str(message.payload.decode("utf-8"))
    print("message received " ,mes)
    print("message topic=",message.topic)
    print("message qos=",message.qos)
    print("message retain flag=",message.retain)
    # tham so de demo
    result = ""
    if(mes=="51A-175.56"): result = recognize_license_plate('1.jpg',mes)
    if(mes=="60A-696.97"): result = recognize_license_plate('2.jpg',mes)
    if(mes=="30E-921.15"): result = recognize_license_plate('2.jpg',mes)
    print("result=",result)
    client.publish("OpenGate",result)

def recognize_license_plate(path,lis):
    img_path=SOURCE_PATH + path
    print(img_path)
    # start_time = datetime.now()
    # image = cv2.imread(img_path)

    # height, width = image.shape[:2]
    # image = cv2.resize(image, (800, int((height * 800) / width)))
    # gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    # gray = cv2.bilateralFilter(gray, 11, 17, 17)
    # edged = cv2.Canny(gray, 170, 200)

    # cnts, new = cv2.findContours(edged.copy(), cv2.RETR_LIST, cv2.CHAIN_APPROX_SIMPLE)[-2:]
    # img1 = image.copy()
    # cv2.drawContours(img1, cnts, -1, (0,255,0), 3)
    # cnts=sorted(cnts, key = cv2.contourArea, reverse = True)[:30]
    # NumberPlateCnt = None #we currently have no Number plate contour
    # img2 = image.copy()
    # cv2.drawContours(img2, cnts, -1, (0,255,0), 3)
    # count = 0
    # idx =7
    # for c in cnts:
    #         peri = cv2.arcLength(c, True)
    #         approx = cv2.approxPolyDP(c, 0.02 * peri, True)
    #         # print ("approx = ",approx)
    #         if len(approx) == 4:  # Select the contour with 4 corners
    #             NumberPlateCnt = approx #This is our approx Number Plate Contour

    #             # Crop those contours and store it in Cropped Images folder
    #             x, y, w, h = cv2.boundingRect(c) #This will find out co-ord for plate
    #             new_img = gray[y:y + h, x:x + w] #Create new image
    #             cv2.imwrite('D:/Driver/DoAnTuan/recognize-license-plate/anh/crop/' + path, new_img) #Store new image
    #             idx+=1

    #             break

    # cv2.drawContours(image, [NumberPlateCnt], -1, (0,255,0), 3)


    # Cropped_img_loc = SOURCE_PATH + '/crop/' + path

    # client = vision.ImageAnnotatorClient()
    # print("img_path")

    # with io.open(Cropped_img_loc, 'rb') as image_file:
    #     content = image_file.read()

    # image2 = vision.types.Image(content=content)
   
    # # Recognize text
    # response = client.text_detection(image=image2)
    # texts = response.text_annotations
    # license_plate =""
    # for text in texts[1:]:
    #     license_plate+=text.description
    # print(license_plate)
    license_plate =""
    if(lis=="51A-175.56"): license_plate +="51A-175.56"
    if(lis=="60A-696.97"): license_plate +="60A-696.96"
    if(lis=="30E-921.15"): license_plate +="60A-696.96"
    print(license_plate)
    if license_plate == lis:
        print("on") 
        rely =  "ON+"+path+"+"+license_plate 
        return rely 
    else: 
        print("off")
        rely =  "OFF+"+path+"+"+license_plate 
        return rely 


print('---------- Start recognize license palate --------')
broker_address="192.168.8.100"

# recognize_license_plate(path)

client = mqtt.Client("P1") #create new instance
client.on_message=on_message #attach function to callback
print("connecting to broker")
client.connect(broker_address) #connect to broker
print("Subscribing to topic","CheckLiscense")
client.subscribe("CheckLiscense")
client.publish("OpenGate","51A-175.56")
print("1")
client.loop_forever()
print("2")


print('---------- End ----------')
