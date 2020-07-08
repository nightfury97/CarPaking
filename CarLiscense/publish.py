import io
import os
import paho.mqtt.client as mqtt
import time

def on_message(client, userdata, message):
    print("message received " ,str(message.payload.decode("utf-8")))
    print("message topic=",message.topic)
    print("message qos=",message.qos)
    print("message retain flag=",message.retain)
    recognize_license_plate(path)


broker_address="192.168.8.100"

client = mqtt.Client("P2") #create new instance
client.connect(broker_address) #connect to broker

print("Publishing message to topic","CheckLiscense")
client.publish("CheckLiscense","51A-175.56")
time.sleep(4) # wait
# client.loop_stop() #stop the loop
print('---------- End ----------')
