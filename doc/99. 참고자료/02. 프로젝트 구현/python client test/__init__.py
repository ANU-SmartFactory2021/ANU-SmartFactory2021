
import soc
import time
import datetime

soc.connect()

while True :
	time.sleep( 1 )
	recv_str = soc.recv()

	now = datetime.datetime.now()
	date_time = now.strftime("%H:%M:%S")
	print( date_time + " : " + recv_str )

	if recv_str.__contains__( "CMD" ) :
		if recv_str.__contains__( "REQUEST_START" ) :
			soc.send( "<PI_ONE_STATE=START>" )

		if recv_str.__contains__( "CAPTURE_START" ) :
			soc.send( "<ACK>" )

