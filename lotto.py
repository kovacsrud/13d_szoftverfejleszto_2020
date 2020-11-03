from colorama import Fore,Back,Style
import random as rnd

tippek=[]
nyeroszamok=[]

print("Hány számmal játszunk?:")
hanySzam=int(input())
print("Hány számból sorsolunk?:")
osszSzam=int(input())
#Tippelés
for i in range(0,hanySzam):
    print("Tipp "+str(i+1)+":")
    atmeneti=int(input())
    while (atmeneti<1 or atmeneti>osszSzam or atmeneti in tippek):
            print("Rossz tipp, újra! " + str(i+1) + ":")
            atmeneti = int(input())
    tippek.append(atmeneti)

print(tippek)

#Sorsolás
for i in range(0,hanySzam):
    atmeneti=rnd.randint(1,osszSzam)
    while (atmeneti in nyeroszamok):
        atmeneti = rnd.randint(1, osszSzam)
    nyeroszamok.append(atmeneti)

print(nyeroszamok)

talalat=0
for i in range(0,hanySzam):
    if (tippek[i] in nyeroszamok):
        talalat+=1

print("Talalat:"+str(talalat))
#Feladat : Írassa ki ciklussal a tippeket,
# jelölje színnel az eltalált számokat(ha vannak)

for i in range(0,len(tippek)):
    if(tippek[i] in nyeroszamok):
        print(Fore.BLUE,Back.YELLOW+str(tippek[i])+Style.RESET_ALL)
    else:
        print(tippek[i])

