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


def servo_main():
    print("서보 함수를 호출 했습니다")
    while True:
       
        print("왼쪽: 1 \n오른쪽: 2 \n다른 함수 호출:3 ")
        num = 0
        num = input()
        if num == '1' :
            print("1 입력")

            pwm.start(11.0)
            time.sleep(2.0)
            pwm.ChangeDutyCycle(0.0)
            
            #break

        elif num == '2' :
            print("2 입력")
            pwm.start(2.0)
            time.sleep(2.0)
            pwm.ChangeDutyCycle(0.0)
            
            #break

        elif num == '3':
            
            break
        
try:
    servo_main()  
              

finally:
    GPIO.cleanup()
    print("GPIO cleanup...!!!")

