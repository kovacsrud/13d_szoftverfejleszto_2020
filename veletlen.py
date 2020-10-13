import random as rnd

#Elemszám meghatározása
elemszam=rnd.randint(10,20)

#Üres lista létrehozása
szamok=[]

#ciklus amíg a megadott számú elemmel fel nem töltjük a listát
for i in range(0,elemszam):
    szamok.append(rnd.randint(100,1000))

#leellenőrizzük
print(szamok)

#összeg meghatározása
osszeg=0

for i in szamok:
    osszeg+=i

print("Az összeg:"+str(osszeg))
print("Az átlag:"+str(osszeg/len(szamok)))



