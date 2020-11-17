import random as rnd
import datetime as dt

class Szemely:
    def __init__(self,vezeteknev,keresztnev,szuletesiev,szuletesihely):
        self.vezeteknev=vezeteknev
        self.keresztnev=keresztnev
        self.szuletesiev=szuletesiev
        self.szuletesihely=szuletesihely
    def Eletkor(self):
        datum=dt.datetime.now()
        return datum.year-self.szuletesiev


def Listaz(lista):
    for i in range(0,len(lista)):
        print(lista[i].vezeteknev+" "+lista[i].keresztnev+","+str(lista[i].szuletesiev)+","+lista[i].szuletesihely)
    print("----------------------------------");

szemelyek=[]
adatszam=500

vezeteknevek=["Kovács","Kertész","Kis","Nagy","Muhari","Péli","Jámbor"]
keresztnevek=["Ágnes","László","Zsolt","Zsófia","János","Péter","Marcell","Éva"]
helyisegek=["Békéscsaba","Orosháza","Szeged","Bélmegyer","Ásotthalom","Miskolc","Sopron","Lenti"]


for i in range(0,adatszam):
    szemely=Szemely(
        vezeteknevek[rnd.randint(0,len(vezeteknevek)-1)],
        keresztnevek[rnd.randint(0,len(keresztnevek)-1)],
        rnd.randint(1930,2020),
        helyisegek[rnd.randint(0,len(helyisegek)-1)]
    )
    szemelyek.append(szemely)

print(len(szemelyek))

#for i in range(0,len(szemelyek)):
#    print(szemelyek[i].vezeteknev+" "+szemelyek[i].keresztnev+","+str(szemelyek[i].szuletesiev)+","+szemelyek[i].szuletesihely)
Listaz(szemelyek)

kisek=[]

for i in range(0,len(szemelyek)):
    if szemelyek[i].vezeteknev=="Kis":
        kisek.append(szemelyek[i])

print(len(kisek))
#for i in range(0,len(kisek)):
#    print(kisek[i].vezeteknev)
Listaz(kisek)

f_kisek=list(filter(lambda x:x.vezeteknev=="Kis",szemelyek))

print(len(f_kisek))

nyugdijasok=list(filter(lambda x:x.szuletesiev>=1930 and x.szuletesiev<=1950,szemelyek))

#for i in range(0,len(nyugdijasok)):
#    print(nyugdijasok[i].keresztnev+","+str(nyugdijasok[i].szuletesiev))
Listaz(nyugdijasok)

kbetusek=list(filter(lambda x:x.vezeteknev.startswith("K"),szemelyek))

#for i in range(0,len(kbetusek)):
#    print(kbetusek[i].vezeteknev+","+str(kbetusek[i].szuletesiev))
Listaz(kbetusek)

harmincasok=list(filter(lambda x:x.Eletkor()==30,szemelyek))

Listaz(harmincasok)

# Ahol az életkor 40 és 60 év között van