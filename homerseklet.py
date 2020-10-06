## Kérjünk be hőmérséklet adatokat addig amíg negatív értéket nem adnak
## meg.
##Számoljuk meg, hány értéket adtak meg

homerseklet=int(input())
darabszam=1

while(homerseklet>-1):
    print("Darabszám:" + str(darabszam))
    darabszam+=1
    homerseklet = int(input())

print("Ennyit adtak meg:"+str(darabszam))

print("Vége")