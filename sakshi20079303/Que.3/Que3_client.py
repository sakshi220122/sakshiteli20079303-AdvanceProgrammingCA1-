import socket

s=socket.socket()
s.connect(("127.0.0.1",5000))

print("Enter Your Details : ")

Name=input("Name: ")
Address=input("Address :")
Qualification=input("Qualification :")
Course=input("Course: ")
Year=input("Start Year: ")
Month=input("Start Month: ")

message=Name + "|" + Address + "|" + Qualification + "|" + Course + "|" + Year + "|" + Month 

s.send(message.encode())

Application_no=s.recv(1024).decode()
print("\n Your Application Number Is : ",Application_no)

s.close()