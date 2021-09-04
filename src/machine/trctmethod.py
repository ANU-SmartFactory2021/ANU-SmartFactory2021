import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
DIGIT=23
GPIO.setup(DIGIT, GPIO.IN)



def trct_main():
    print("센서 함수를 호출했습니다.")
    print("사용하시겠습니까: 1 \n다른 센서 사용: 2")
    while True:
        
        num2 = 0
        num2 = input()
        
        if num2=='1':
            digit_val=GPIO.input(DIGIT)
            print("dlgital : %d " %(digit_val))
            time.sleep(0.5)
            
        elif num2=='2':
            break
        
try:
    trct_main()

finally:
    GPIO.cleanup()
    