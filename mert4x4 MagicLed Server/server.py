#!/usr/bin/python

import socket
import serial
import time


print("mert4x4 tempLeds server!")
print(" ")
print("  __  __  _____  ____  _____  _  _  __  __ _  _   ")
print(" |  \/  || ____||  _ \|_   _|| || | \ \/ /| || | ")
print(" | |\/| ||  _|  | |_) | | |  | || |_ \  / | || |_")
print(" | |  | || |___ |  _ <  | |  |__   _|/  \ |__   _|")
print(" |_|  |_||_____||_| \_\ |_|     |_| /_/\_\   |_|  ")


try:
    file = open("data.4x4")
    ipfirst = file.readline()
    ip = ipfirst[:-1]
    ipfinal = ip.split(": ")
    print ipfinal[1]

    portfirst = file.readline()
    port = portfirst[:-1]
    portfinal = port.split(": ")
    print portfinal[1]

    deviceportfirst = file.readline()
    deviceport = deviceportfirst[:-1]
    deviceportfinal = deviceport.split(": ")
    print deviceportfinal[1]

    boundratefirst = file.readline()
    boundrate = boundratefirst[:-1]
    boundratefinal = boundrate.split(": ")
    print boundratefinal[1]
except:
    print("data.4x4 does not exist")

try:
    host = ipfinal[1]
    port = int(portfinal[1])

    s = socket.socket()
    host = str(host)
    port = int(port)
    s.bind((host, port))
    s.listen(5)
    print("server created...!")
    print(" ");
    PortNo = str(deviceportfinal[1])
    BoundRate = int(boundratefinal[1])
except:
    print("could not create server...")


try:
    data = "0"
    arduino = serial.Serial(PortNo, BoundRate)
    arduino.flushInput()
    print("connected to arduino...")
except:
    print("could not connect arduino to...")

while True:
	try:
		c, addr = s.accept()
		dataata = str(c.recv(1024))
		print(data)
		arduino.write(data + " \n")
		c.close()
	except:
		print(" ")
    
