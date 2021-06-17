import datetime as dt

class Auto:
    def __init__(self,rendszam,marka,tipus,gyartev,km):
        self.rendszam=rendszam
        self.marka=marka
        self.tipus=tipus
        self.gyartev=int(gyartev)
        self.km=int(km)
    def Kor(self):
        return dt.datetime.now().year-self.gyartev
    def EvenkentFutott(self):
        return self.km/self.Kor()

autok=[]

mennyit=int(input("Hány autót fogunk tárolni:"))

for i in range(0,mennyit):
    rendszam=input("Rendszám:")
    marka=input("Márka:")
    tipus=input("Típus:")
    gyartev=input("Gyártás éve:")
    km=input("Futott km:")
    auto=Auto(rendszam,marka,tipus,gyartev,km)
    autok.append(auto)

for i in autok:
    print(i.rendszam,i.marka,i.tipus,i.gyartev,i.Kor(),i.EvenkentFutott())
