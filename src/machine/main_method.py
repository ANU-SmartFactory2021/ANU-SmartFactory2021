#import servomethod as sf #servomethod_function
#import trctmethod as tf #trctmethod_function
import RPi.GPIO as GPIO
import time




def main_method():
    while True:
        print(" 서보 함수 호출: 1 \n 센서함수 호출: 2")
        bt = 0
        bt = input()
            
        if bt == '1':
            import servomethod as sf
            print("서보 함수 호출")
            sf.servo_main()
                #break
                
        elif bt == '2':
            import trctmethod as tf
            print("센서 함수 호출")
            tf.trct_main()
                #break
        
        else :
            print("다시 입력해주세요")
            break
        
try:
    main_method()
    
finally:
    GPIO.cleanup()
    print("GPIO cleanup..")

