import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)


GPIO_RP = 24
GPIO_RN = 25
GPIO_EN = 12


def motor_main( btn2 ):
    
        
        if btn2 == '4\n' :
        #if btn2 == '<CMD=BELT_START>' :
            print("forward")
            GPIO.setup(GPIO_RP, GPIO.OUT)
            GPIO.setup(GPIO_RN, GPIO.OUT)
            GPIO.setup(GPIO_EN, GPIO.OUT)
            
            GPIO.output(GPIO_RP, GPIO.HIGH)
            GPIO.output(GPIO_RN, GPIO.LOW)
            GPIO.output(GPIO_EN, GPIO.HIGH)
            
        if btn2 =='5\n' :
        #if btn2 =='<CMD=BELT_STOP>' :
            print("STOP")
            GPIO.output(GPIO_RP, GPIO.LOW)
            GPIO.output(GPIO_RN, GPIO.LOW)
            GPIO.output(GPIO_EN, GPIO.LOW)
         
       
