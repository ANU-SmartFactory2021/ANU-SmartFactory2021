import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)

GPIO_RP = 20
GPIO_RN = 21
GPIO_EN = 16


def motor_main( btn2 ):
    
        ##모터 Running##
        
        if btn2 == '<CMD=BELT_START>' :
            print("FORWARD")
            GPIO.setup(GPIO_RP, GPIO.OUT)
            GPIO.setup(GPIO_RN, GPIO.OUT)
            GPIO.setup(GPIO_EN, GPIO.OUT)

            pwm1 = GPIO.PWM(GPIO_EN, 0.1) ##속도 제어

            ##FORWARD##
            # GPIO.output(GPIO_RP, GPIO.LOW)
            # GPIO.output(GPIO_RN, GPIO.HIGH)
            # GPIO.output(GPIO_EN, GPIO.HIGH)

            ##BACKWARD##
            GPIO.output(GPIO_RP, GPIO.HIGH)
            GPIO.output(GPIO_RN, GPIO.LOW)
            GPIO.output(GPIO_EN, GPIO.HIGH)

        ##모터 Stop##    
        
        if btn2 =='<CMD=BELT_STOP>' : 
            print("STOP")
            GPIO.output(GPIO_RP, GPIO.LOW)
            GPIO.output(GPIO_RN, GPIO.LOW)
            GPIO.output(GPIO_EN, GPIO.LOW)
         
       