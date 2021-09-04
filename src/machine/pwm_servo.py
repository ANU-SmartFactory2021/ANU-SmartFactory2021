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



try :
    
    while True: 
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

        else :
            print("다시입력해주세요")
            break
                

finally:
    GPIO.cleanup()
    print("GPIO cleanup...!!!")

