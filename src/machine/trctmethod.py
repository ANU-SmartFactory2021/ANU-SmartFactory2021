import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
DIGIT1=23

GPIO.setup(DIGIT1, GPIO.IN)

##센서1 함수##
def read_sensor() :
        
        digit1_val=GPIO.input(DIGIT1)
        
        a = digit1_val
       
        return a 
