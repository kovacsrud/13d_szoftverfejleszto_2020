#Osztály deklaráció



class Szemely:
    def __init__(self,nev,szuletesiEv):
        self.nev=nev
        self.szuletesiEv=szuletesiEv

    def Bemutatkozas(self):
        print("Jó napot "+self.nev+" vagyok.")

    def Nevvaltas(self,ujnev):
        self.nev=ujnev

    def EletkorSzoveg(self):
        print("Életkorom:"+str(2020-self.szuletesiEv))

    def Eletkor(self):
        return 2020-self.szuletesiEv

#példányosítás
szemely1=Szemely("Ubul",1998)

szemely2=Szemely("Zénó",2001)


szemely1.Bemutatkozas()
szemely1.Nevvaltas("Károly")
szemely1.EletkorSzoveg()
print(szemely1.Eletkor())
szemely1.Bemutatkozas()

szemely2.Bemutatkozas()

# Hogyan lehet megvalósítani az előző példát osztály nélkül




