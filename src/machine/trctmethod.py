import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
DIGIT=23
GPIO.setup(DIGIT, GPIO.IN)


def read_sensor() :
    digit_val=GPIO.input(DIGIT)
    return digit_val


    