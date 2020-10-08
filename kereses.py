import random as rnd

nevek=['Ubul','Elek','Jakab','Tamás','Eleonóra']

keres='Tamás'
megvan=False

for i in nevek:
    if(i==keres):
        megvan=True
        break


print(megvan)

print(keres in nevek)

print(rnd.randint(0,100))

for i in range(0,20):
    print(rnd.randint(0,100))

lanyok=['Éva','Erika','Anikó','Anita','Jolán']
fiuk=['Géza','Lajos','Endre','Gyula','Sándor']

for i in range(0,10):
    fiu=fiuk[rnd.randint(0,4)]
    lany=lanyok[rnd.randint(0,4)]
    print(str(fiu)+"-"+str(lany))

## írjon ciklust, amely generál 10-40db 1 és 100 közötti véletlen számot, és kiírja ezeket
darabszam=0
for i in range(0,rnd.randint(10,40)):
    print(rnd.randint(1,100))
    darabszam+=1

