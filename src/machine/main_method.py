#import servomethod as sf #servomethod_function
#import trctmethod as tf #trctmethod_function
import RPi.GPIO as GPIO
import time
import servomethod as sf
import trctmethod as tf



def main_method():
    while True:
        #print(" 서보 함수 호출: 1 \n 센서함수 호출: 2")
        bt = 0
        bt = input()
            
        if bt == '1':
            sf.servo_main(bt)
            
        elif bt == '2':
            sf.servo_main(bt)
                
        elif bt == '3':
            sensor_state = tf.read_sensor()
            print( "센서 상태 : ", sensor_state )
        
        elif bt == 'x':
            break
        
        else :
            print("다시 입력해주세요")
        
try:
    main_method()
    
finally:
    GPIO.cleanup()
    print("GPIO cleanup..")

