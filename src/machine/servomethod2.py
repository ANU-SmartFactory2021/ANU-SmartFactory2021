import pigpio
from time import sleep
pi = pigpio.pi()
sleep(2)
pi.set_servo_pulsewidth(17, 0)



def servo_main( btn ):
   
    ## 왼쪽 서보모터##
    if btn == '<CMD=CLASSIFY_LEFT>' :
        print("양품모터동작")
        sleep(1)
        pi.set_servo_pulsewidth(17, 1000)
        sleep(0.25)
        pi.set_servo_pulsewidth(17, 0)
        

    ##오른쪽 서보모터##
    elif btn == '<CMD=CLASSIFY_RIGHT>' :
        print("불량모터동작")
        sleep(1)
        pi.set_servo_pulsewidth(17, 600)
        sleep(0.25)
        pi.set_servo_pulsewidth(17, 0)

