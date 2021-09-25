
import RPi.GPIO as GPIO
import time
import servomethod as sf
import trctmethod as tf
import motormethod as mf
import soc

print('start')

soc.connect()
soc.send('<CLIENT_TYPE=CONTROL>')

while True:
    time.sleep(2)
    print('waiting server')
    recv_data = soc.recv()
    if recv_data == 'START\n':
    #if recv_data == '<CMD=REQUEST_START>':
        soc.send('<PI_TWO_STATE=START>')
        break
   

def main_method():
    while True:
        
        recv_data = soc.recv()
            
        if recv_data == '1\n':
        #if recv_data == '<CMD=CLASSIFY_LEFT>':    
            sf.servo_main(recv_data)
            soc.send('<RECV_ACK>')

        elif recv_data == '2\n':
        #elif recv_data == '<CMD=CLASSIFY_RIGHT>':         
            sf.servo_main(recv_data)
            soc.send('<RECV_ACK>')

        elif recv_data == '3\n':
        #elif recv_data == '<CMD=REQUEST_SENSOR_STATE>':
            sensor_state = tf.read_sensor()
            print( "센서 상태 : ", sensor_state )
            if sensor_state == True:
                soc.send('<SENSOR_STATE=ON>')
            elif sensor_state == False:
                soc.send('<SENSOR_STATE=OFF>')

                
        elif recv_data == '4\n' :
        # elif recv_data == '<CMD=BELT_START>'
            mf.motor_main(recv_data)
            soc.send('<LINE_STATE=RUNNING>')


        elif recv_data == '5\n' :
        # elif recv_data == '<CMD=BELT_STOP>'
            mf.motor_main(recv_data)
            soc.send('<LINE_STATE=STOP>')
        
    
        elif recv_data == 'x\n':
            break
        
        
        
try:
    main_method()
    
finally:
    GPIO.cleanup()
    print("GPIO cleanup..")

