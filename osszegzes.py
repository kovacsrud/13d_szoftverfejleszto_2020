szamok=[129,416,338,122,456,199,896,623]
#Mennyi a tömb elemeinek összege?

osszeg=0

for i in szamok:
    osszeg+=i

print("Az összeg:"+str(osszeg))

#Megvalósítás range-el
osszeg=0

for i in range(0,len(szamok)):
    osszeg+=szamok[i]

print("Az összeg:"+str(osszeg))
print("Az elemek átlaga:"+str(osszeg/len(szamok)))

#Készítsük el az összegzést while ciklussal!
osszeg=0
elem=0
while (elem<len(szamok)):
    osszeg+=szamok[elem]
    print(elem)
    elem+=1

print("Az összeg:"+str(osszeg))
print("Az elemek átlaga:"+str(osszeg/len(szamok)))
