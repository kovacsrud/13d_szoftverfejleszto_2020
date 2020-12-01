
from collections import OrderedDict

class Hianyzo:
    def __init__(self,nev,osztaly,elsonap,utolsonap,mulasztottorak):
        self.nev=nev
        self.osztaly=osztaly
        self.elsonap=int(elsonap)
        self.utolsonap=int(utolsonap)
        self.mulasztottorak=int(mulasztottorak)


hianyzasok=[]

#Fájl betöltés és feldolgozás

fajl=open("szeptember.csv",'r')

#első sor átlépése
fajl.readline()

#a fájl sorainak feldolgozása
for i in fajl:
    elemek=i.strip().split(';')
    hianyzo=Hianyzo(elemek[0],elemek[1],elemek[2],elemek[3],elemek[4])
    hianyzasok.append(hianyzo)

fajl.close()

print(len(hianyzasok))
#Hány órát mulasztottak a diákok ebben a hónapban?

mulasztottorak=0

for i in hianyzasok:
    mulasztottorak+=i.mulasztottorak

print("Mulasztott órák száma:{}".format(mulasztottorak))

benap=int(input("Adjon meg egy napot 1 és 30 között:"))
benev=input("Adjon meg egy nevet:")

# Megállapítjuk, hogy hiányzott e az előbb bekért név
hianyzott=list(filter(lambda x:x.nev==benev,hianyzasok))

if len(hianyzott)>0:
    print("Hiányzott szeptemberben!")
else:
    print("Nem hiányzott szeptemberben!")

# Az előző feladat megoldása ciklussal
hianyzott_=False

for i in hianyzasok:
    if i.nev==benev:
        hianyzott_=True
        break

if hianyzott_:
    print("Hiányzott szeptemberben!")
else:
    print("Nem hiányzott szeptemberben!")
#Adott napon hiányzók kiszűrése listába, kiíratás
napihianyzok=list(filter(lambda x:x.elsonap>=benap and x.utolsonap<=benap,hianyzasok))

for i in napihianyzok:
    print("{},{}".format(i.nev,i.osztaly))

#Adott napon hiányzók kiíratása

for i in hianyzasok:
    if (i.elsonap>=benap) and (i.utolsonap<=benap):
        print("{},{}".format(i.nev, i.osztaly))


osszesites={}



for i in hianyzasok:
    if i.osztaly in osszesites:
        osszesites[i.osztaly]+=i.mulasztottorak
    else:
        osszesites[i.osztaly]=i.mulasztottorak

# Az előzőleg létrehozott szótár kiíratása
for i,j in osszesites.items():
    print("Osztály:{},Érték:{}".format(i,j))

#Kulcsok szerint rendezett szótár
rendezett=OrderedDict(sorted(osszesites.items()))

#Csökkenő sorrend beállításd a rendezés során
rendezett=OrderedDict(sorted(osszesites.items(),reverse=True))
print(rendezett)

fajl=open("osszesites.csv",'w')

for i,j in rendezett.items():
    fajl.write("{};{}\n".format(i,j))

fajl.close()
print("Fájlba írás kész!")
