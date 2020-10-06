# -*- coding: utf-8 -*-
"""
Created on Tue Sep 29 07:57:37 2020

@author: SysAdmin
"""
a="valami"

b="ValAmi"

print(a+b)

# Kis -vagy nagybetűsre alakítás

print(b.lower())
print(a.upper())

if(a.upper()==b.upper()):
    print("Megegyeznek")
else:
    print("Nem egyeznek meg")    


# Kezdete, vége
    
print(a.startswith("va"))    
print(a.endswith("ami"))    
    
# Tartalmaz-e a szöveg egy kisebb szövegrészt

print(a.find("laza"))

# Hányszor tartalmazza a megadott szöveget

print(a.count("la"))


# Karakter, szövegrész cseréje
print(a.replace("a","b"))

# Ellenőrzések ,szám-e, karakter-e

c="a"
print(c.isdigit())

print(c.isalnum())

# Szöveg darabolása

adat="Kiss Elek,1989,Szeged,442669"

adatok=adat.split(",")

print(adatok)

# Szövegrész kiemelése

datum="2019.12.23"

ev=datum[0:4]
print(ev)
honap=datum[5:7]
print(honap)

nap=datum[8:]
print(nap)

## Az utolsó 3 karakter
print(datum[-3:])

## Az összes karakter az utolsó 3 kivételével
print(datum[:-3])


