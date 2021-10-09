import RPi.GPIO as GPIO
import time
import servomethod2 as sf  #서보모터
import motormethod as mf  #모터
import trctmethod as tf   #센서1
import trctmethod2 as tf2 #좌우 센서
import soc                #통신

print('start')

soc.connect()
soc.send('<CLIENT_TYPE=CONTROL>')

"""
while True:
    ##서버통신##
    time.sleep(2)
    print('waiting server')
    recv_data = soc.recv()

    print(recv_data)
    if recv_data == '<CMD=REQUEST_START>':

        soc.send('<PI_TWO_STATE=START>')
        break
"""

def main_method():
    while True:
        
        recv_data = soc.recv()
        

        if recv_data == '<CMD=REQUEST_START>':
            soc.send('<PI_TWO_STATE=START>')

        ##서보모터 왼쪽##     
        
        if recv_data == '<CMD=CLASSIFY_LEFT>':
            sf.servo_main(recv_data)
            time.sleep(1)
            soc.send('<LINE_STATE=CLASSIFYING>')

            tf2.read_sensor()       
            soc.send('<LINE_STATE=COMPLETE>') ##왼쪽센서
            time.sleep(0.5)
            mf.motor_main('<CMD=BELT_STOP>')

        ##서보모터 오른쪽##
        
        elif recv_data == '<CMD=CLASSIFY_RIGHT>':
            sf.servo_main(recv_data)
            time.sleep(1)
            soc.send('<LINE_STATE=CLASSIFYING>')

            tf2.read_sensor()         
            soc.send('<LINE_STATE=COMPLETE>') ##오른쪽센서
            time.sleep(0.5)
            mf.motor_main('<CMD=BELT_STOP>')


        ##센서1 감지##
        elif recv_data == '<CMD=REQUEST_SENSOR_STATE>':
            sensor_state = tf.read_sensor()              
            print( "센서 상태 : ", sensor_state )
            if sensor_state == True:
                time.sleep(0.3)
                soc.send('<SENSOR_STATE=ON>')
                          
            elif sensor_state == False:
                time.sleep(0.3)
                soc.send('<SENSOR_STATE=OFF>')
                
            time.sleep(2)
            sensor_state = tf.read_sensor()

        ##센서 Passing##     
            if sensor_state == False:
                soc.send('<LINE_STATE=PASSING>')
              


        ##모터 Running##        
        
        elif recv_data == '<CMD=BELT_START>':
            mf.motor_main(recv_data)
            soc.send('<LINE_STATE=RUNNING>')


        ##모터 Stop##
        if recv_data == '<CMD=BELT_STOP>':
            mf.motor_main(recv_data)
            soc.send('<LINE_STATE=STOP>')
        
    
        elif recv_data == 'x':
            break
        
               
try:
    main_method()

    
finally:
    GPIO.cleanup()
    print("GPIO cleanup..")

