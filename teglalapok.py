import random as rnd

class Teglalap:
    def __init__(self,aOldal,bOldal):
        self.aOldal=aOldal
        self.bOldal=bOldal

    def Kerulet(self):
        return (self.aOldal+self.bOldal)*2

    def Terulet(self):
        return self.aOldal*self.bOldal


teglalapok=[]

for i in range(0,50):
    teglalap=Teglalap(rnd.randint(10,30),rnd.randint(10,30))
    teglalapok.append(teglalap)

print(len(teglalapok))

for i in range(0,len(teglalapok)):
    print(teglalapok[i].Kerulet())

#kiválogatás
nagyok=[]

for i in range(0,len(teglalapok)):
    if teglalapok[i].Kerulet()>=100:
        nagyok.append(teglalapok[i])

#kiíratás
for i in range(0,len(nagyok)):
    print(nagyok[i].Kerulet())

#kiválogatás filterrel
fnagyok=list(filter(lambda x:x.Kerulet()>=100,teglalapok))

for i in range(0,len(fnagyok)):
    print(fnagyok[i].Kerulet())