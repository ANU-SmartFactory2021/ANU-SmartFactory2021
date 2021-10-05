import RPi.GPIO as GPIO
import time
import soc

GPIO.setmode(GPIO.BCM)
DIGIT1=23
DIGIT2=24

GPIO.setup(DIGIT1, GPIO.IN)
GPIO.setup(DIGIT2, GPIO.IN)

##왼쪽, 오른쪽 센서 함수##
def read_sensor() :
    
        while True:
            
            digit1_val=GPIO.input(DIGIT1)
            
            
            digit2_val=GPIO.input(DIGIT2)
            
           
            time.sleep(0.3)
            
            ##왼쪽 오른쪽 감지 센서##
            if digit1_val == True:
                print("불량")
                break
            
        
            elif digit2_val == True:
                print("양품")
                break


