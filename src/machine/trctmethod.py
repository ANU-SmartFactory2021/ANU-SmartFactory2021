import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
DIGIT1=25

GPIO.setup(DIGIT1, GPIO.IN)

##μΌμ1 ν¨μ##
def read_sensor() :
        
        digit1_val=GPIO.input(DIGIT1)
        
        a = digit1_val
       
        return a 
