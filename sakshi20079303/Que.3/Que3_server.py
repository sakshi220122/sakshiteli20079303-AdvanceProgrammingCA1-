import socket
import sqlite3
import random

db=sqlite3.connect("Admission.db")
cur=db.cursor()

cur.execute("""CREATE TABLE IF NOT EXISTS students( 
            Application_no TEXT,
            Name TEXT,
            Address TEXT,
            Qualification TEXT,
            Course TEXT,
            Year TEXT,
            Month TEXT)  """)
db.commit()

s=socket.socket()
host="127.0.0.1"
port=5000
s.bind((host,port))
s.listen(1)

print("Server started.... waiting for client....")
while True:
   client,addr=s.accept()
   print("Client Connected")

   message=client.recv(1024).decode()
   items=message.split("|")
   Name=items[0]
   Address=items[1]
   Qualification=items[2]
   Course=items[3]
   Year=items[4]
   Month=items[5]

   Application_no="DBS"+str(random.randint(1000,9999))
   cur.execute("INSERT INTO students VALUES (?,?,?,?,?,?,?)",
               (Application_no,Name,Address,Qualification,Course,Year,Month))
   
   db.commit()
   client.send(Application_no.encode())
   client.close()