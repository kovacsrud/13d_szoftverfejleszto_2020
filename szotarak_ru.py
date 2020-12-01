import random as rnd
# Szótár adatszerkezet
# A szótár kulcs-érték párokat tárol. A kulcs csak egyszer szerepelhet a szótárban

testtomegek={}

testtomegek['Béla']=86
testtomegek['Ilona']=71
testtomegek['Zalán']=96
testtomegek['Elek']=62

print(testtomegek)
print(testtomegek.keys())
print(testtomegek.values())
print(testtomegek.items())

for i in testtomegek:
    print(i+","+str(testtomegek[i]))

for i in testtomegek.keys():
    print(i + "," + str(testtomegek[i]))

for i,j in testtomegek.items():
    print("Kulcs:{},Érték:{}".format(i,j))

# Utolsó elem kivétele a szótárból
#testtomegek.popitem()
#print(testtomegek)
#testtomegek.popitem()
#Adott kulcsú elem kivétele a szótárból
testtomegek.pop('Elek')
testtomegek.pop('Béla')
print(testtomegek)
#Szótár ürítése
testtomegek.clear()

autok=["Audi","Skoda","Bmw","Seat","Opel","Honda","Fiat","Dacia","Toyota"]

autoadatok=[]
elemszam=1000

for i in range(0,elemszam):
    autoadatok.append(autok[rnd.randint(0,len(autok)-1)])

print(autoadatok)

# Szótár építése
autoszotar={}

for i in autoadatok:
    if i in autoszotar:
        autoszotar[i]+=1
    else:
        autoszotar[i]=1


print(autoszotar)

for i,j in autoszotar.items():
    print("{}->{}".format(i,j))