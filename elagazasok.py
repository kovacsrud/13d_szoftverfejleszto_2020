# -*- coding: utf-8 -*-
"""
Created on Thu Sep 24 12:09:45 2020

@author: SysAdmin
"""
#elágazások

a=0
# egyszeres egyágú elágazás
if (a>0):
    print("A szám pozitív!")

# Többszörös szelekció
if (a>0):
    print("A szám pozitív")
elif(a==0):    
    print("A szám nulla")
else:
    print("A szám negatív!")    
    
b=10    

if(b>0):
    print("Nagyobb mint 0")
elif(b>5):
    print("Nagyobb mint 5")
elif(b>10):
    print("Nagyobb mint 10")        
else:
    print("Valami más")        
    

d=30

# Ha d értéke 50 és 200 között van
# akkor az a szöveg jelenjen meg, hogy "megfelelő"
# egyébként az hogy "nem megfelelő"

if(d>50 and d<200):
    print("Megfelelő")
else:
    print("Nem megfelelő")    



print("Program vége")    