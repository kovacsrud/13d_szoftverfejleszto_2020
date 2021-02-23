
# Az alábbi osztály felhasználásával készítsen programot, amely
# hajók adatait kéri be, azokat egy listában tárolja, majd kiírja

# bővítse ki az osztályt úgy hogy képes legyen a hajó
# csomóban mért sebességének a tárolására
# készítsen metódust a hajó sebességének a km/h -ban való meghatározására

class Hajo:
    def __init__(self,nev,sebessegcsomo):
        self.nev=nev
        self.sebessegcsomo=float(sebessegcsomo)

    def sebessegkmh(self):
        return self.sebessegcsomo*1.85

hajok=[]

for i in range(0,3):
    hajonev=input("Add meg a hajó nevét:")
    hajosebesseg=float(input("A hajó sebessége csomóban:"))
    hajo=Hajo(hajonev,hajosebesseg)
    hajok.append(hajo)

for i in hajok:
    print(i.nev,i.sebessegcsomo,i.sebessegkmh())

