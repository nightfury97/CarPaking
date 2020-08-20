import io
import os
from google.cloud import vision_v1p3beta1 as vision
from google.cloud.vision import types
from datetime import datetime
import cv2
import imutils
# Setup google authen client key
os.environ['GOOGLE_APPLICATION_CREDENTIALS'] = 'client_key.json'

# Source path content all images
SOURCE_PATH = "D:/Driver/DoAnTuan/CarLiscense/anh/"


def recognize_license_plate(img_path):
    start_time = datetime.now()
    image = cv2.imread(img_path)

    # Get image size
    height, width = image.shape[:2]

    # Scale image
    image = cv2.resize(image, (800, int((height * 800) / width)))
    # image = imutils.resize(image, width=500)

    # Display the original image
    cv2.imshow("Original Image", image)
    cv2.waitKey(0)

    # RGB to Gray scale conversion
    gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    cv2.imshow("1 - Grayscale Conversion", gray)
    cv2.waitKey(0)

    # Noise removal with iterative bilateral filter(removes noise while preserving edges)
    gray = cv2.bilateralFilter(gray, 11, 17, 17)
    cv2.imshow("2 - Bilateral Filter", gray)
    cv2.waitKey(0)

    # Find Edges of the grayscale image
    edged = cv2.Canny(gray, 170, 200)
    cv2.imshow("3 - Canny Edges", edged)
    cv2.waitKey(0)

    # Find contours based on Edges
    cnts, new = cv2.findContours(edged.copy(), cv2.RETR_LIST, cv2.CHAIN_APPROX_SIMPLE)[-2:]

    # Create copy of original image to draw all contours
    img1 = image.copy()
    cv2.drawContours(img1, cnts, -1, (0,255,0), 3)
    cv2.imshow("4- All Contours", img1)
    cv2.waitKey(0)

    #sort contours based on their area keeping minimum required area as '30' (anything smaller than this will not be considered)
    cnts=sorted(cnts, key = cv2.contourArea, reverse = True)[:30]
    NumberPlateCnt = None #we currently have no Number plate contour

    # Top 30 Contours
    img2 = image.copy()
    cv2.drawContours(img2, cnts, -1, (0,255,0), 3)
    cv2.imshow("5- Top 30 Contours", img2)
    cv2.waitKey(0)

    # loop over our contours to find the best possible approximate contour of number plate
    count = 0
    idx =7
    for c in cnts:
            peri = cv2.arcLength(c, True)
            approx = cv2.approxPolyDP(c, 0.02 * peri, True)
            # print ("approx = ",approx)
            if len(approx) == 4:  # Select the contour with 4 corners
                NumberPlateCnt = approx #This is our approx Number Plate Contour

                # Crop those contours and store it in Cropped Images folder
                x, y, w, h = cv2.boundingRect(c) #This will find out co-ord for plate
                new_img = gray[y:y + h, x:x + w] #Create new image
                cv2.imwrite('./' + str(idx) + '.png', new_img) #Store new image
                idx+=1

                break


    # Drawing the selected contour on the original image
    #print(NumberPlateCnt)
    cv2.drawContours(image, [NumberPlateCnt], -1, (0,255,0), 3)
    cv2.imshow("Final Image With Number Plate Detected", image)
    cv2.waitKey(0)

    Cropped_img_loc = './7.png'
    cv2.imshow("Cropped Image ", cv2.imread(Cropped_img_loc))
    cv2.waitKey(0)

    # Create google vision client
    client = vision.ImageAnnotatorClient()

    # Read image file
    with io.open(Cropped_img_loc, 'rb') as image_file:
        content = image_file.read()

    image2 = vision.types.Image(content=content)
   
    # Recognize text
    response = client.text_detection(image=image2)
    texts = response.text_annotations
    license_plate =""
    for text in texts[1:]:
        license_plate+=text.description
        # print(text.description)
        # if len(text.description) == 10:
        #     license_plate = text.description
        #     print(license_plate)
        #     vertices = [(vertex.x, vertex.y)
        #                 for vertex in text.bounding_poly.vertices]

        #     # Put text license plate number to image
        #     cv2.putText(image, license_plate, (200, 200), cv2.FONT_HERSHEY_SIMPLEX, 2, (0, 0, 255), 3)

        #     print(vertices)
        #     # Draw rectangle around license plate
        #     # cv2.rectangle(image, (vertices[0][0]-10, vertices[0][1]-10), (vertices[2][0]+10, vertices[2][1]+10), (0, 255, 0), 3)
        #     print('Total time: {}'.format(datetime.now() - start_time))
        #     cv2.imshow('Recognize & Draw', image)
        #     cv2.waitKey(0)
    print(license_plate)

print('---------- Start recognize license palate --------')
path = SOURCE_PATH + '2.jpg'
print(path)
recognize_license_plate(path)
print('---------- End ----------')
