import RPi.GPIO as GPIO
import time

#servo핀 GPIO18번 
servo_pin = 18
 
#GPIO.setmode 함수를 호출하여 BCM GPIO 핀 번호로 사용하도록 설정
GPIO.setmode(GPIO.BCM)

#GPIO.setup 함수 호출후 GPIO 출력으로 설정 (True , False)
GPIO.setup(servo_pin, GPIO.OUT)

#PWM 파형의 주파수를 50HZ로 설정 
pwm = GPIO.PWM(servo_pin ,50)


def servo_main( btn ):
    
        num = btn
        ## 왼쪽 서보모터##
        if num == '<CMD=CLASSIFY_LEFT>' :
            print("양품")

            pwm.start(11.0)
            time.sleep(2.0)
            pwm.ChangeDutyCycle(0.0)
            
           

        ##오른쪽 서보모터##
        elif num == '<CMD=CLASSIFY_RIGHT>' :
            print("불량")
            pwm.start(2.0)
            time.sleep(2.0)
            pwm.ChangeDutyCycle(0.0)
