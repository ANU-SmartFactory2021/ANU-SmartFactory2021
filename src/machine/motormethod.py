import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)

GPIO_RP = 24
GPIO_RN = 25
GPIO_EN = 12

GPIO.setup(GPIO_RP, GPIO.OUT)
GPIO.setup(GPIO_RN, GPIO.OUT)
GPIO.setup(GPIO_EN, GPIO.OUT)

def motor_main( btn2 ):
    
        num = btn2
        if num1 == '1' :
            prin("forward")
            
            GPIO.output(GPIO_RP, GPIO.HIGH)
            GPIO.output(GPIO_RN, GPIO.LOW)
            GPIO.output(GPIO.EN, GPIO.HIGH)
      