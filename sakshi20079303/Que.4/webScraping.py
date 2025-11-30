import requests
from bs4 import BeautifulSoup
import csv

hotelData = []

print("Scraping Hotel A...")

with open("hotelA.html", "r", encoding="utf-8") as f:
    soup1 = BeautifulSoup(f.read(), "html.parser")

rooms1 = soup1.find_all("div", class_="room-card")

for r in rooms1:
    name = r.find("h3").text.strip()

    price_tag = r.find("div", class_="price")
    price = price_tag.text.strip() if price_tag else ""

    hotelData.append(["Hotel A", name, price])


print("Scraping Hotel B...")

with open("hotelB.html", "r", encoding="utf-8") as f:
    soup2 = BeautifulSoup(f.read(), "html.parser")

rooms2 = soup2.find_all("div", class_="room-card")

for r in rooms2:
    name = r.find("h3").text.strip()
    price = r.find("span", class_="price").text.strip()  

    hotelData.append(["Hotel B", name, price])

print("Saving to csv...")

with open("HotelRooms.csv", "w", newline="", encoding="utf-8") as f:
    writer = csv.writer(f)
    writer.writerow(["Hotel", "Room", "Price"])
    writer.writerows(hotelData)

print("CSV saved as HotelRooms.csv")

print("\nReading csv data:\n")

with open("HotelRooms.csv", "r", encoding="utf-8") as f:
    reader = csv.DictReader(f)
    for row in reader:
        print(row)

print("\nDone!")
