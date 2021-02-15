
class Dolgozo:
    def __init__(self,nev,munkaviszony,alapfizetes):
        self.nev=nev
        self.munkaviszony=int(munkaviszony)
        self.alapfizetes=int(alapfizetes)

    def Fizetes(self):
        if self.munkaviszony>=10:
            return self.alapfizetes*1.3
        else:
            return self.alapfizetes*1.1


dolgozok=[]

for i in range(0,3):
    nev=input("A dolgozó neve:")
    munkaviszony=int(input("Hány éve dolgozik?"))
    alapfizetes=int(input("Alapfizetése:"))
    dolgozo=Dolgozo(nev,munkaviszony,alapfizetes)
    dolgozok.append(dolgozo)

for i in dolgozok:
    print(i.nev,i.munkaviszony,i.Fizetes())