import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
DIGIT=23
GPIO.setup(DIGIT, GPIO.IN)

try:
    while True:
        digit_val=GPIO.input(DIGIT)
        print("dlgital : %d " %(digit_val))
        time.sleep(0.5)
finally:
    GPIO.cleanup()
    
