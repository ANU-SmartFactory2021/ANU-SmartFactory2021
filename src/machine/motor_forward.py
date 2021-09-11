import RPi.GPIO as GPIO
import time
GPIO.setmode(GPIO.BCM)

GPIO_RP = 24
GPIO_RN = 25
GPIO_EN = 12

GPIO.setup(GPIO_RP, GPIO.OUT)
GPIO.setup(GPIO_RN, GPIO.OUT)
GPIO.setup(GPIO_EN, GPIO.OUT)

try:
    while True:
        print ("forward")
        GPIO.output(GPIO_RP, GPIO.HIGH)
        GPIO.output(GPIO_RN, GPIO.LOW)
        GPIO.output(GPIO_EN, GPIO.HIGH)
        time.sleep(0.5)
        
        
except KeyboardInterrupt:
    print("keyboardIInterrupt")
finally:
    print("cleanup")
    GPIO.cleanup()