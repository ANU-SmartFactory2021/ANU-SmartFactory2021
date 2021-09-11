from gpiozero import Motor
import time

motor= Motor(forward=20, backward =21)

while True:
    print('모터 회전 방향: Forward')
    motor.forward(speed=0.3)
    time.sleep(5)
    
    print('모터회전 방향: Backward')
    motor.backward(speed=0.5)
    time.sleep(5)
    
    