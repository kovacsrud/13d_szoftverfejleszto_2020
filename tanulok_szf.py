class Tanulo:
    def __init__(self,vezeteknev,keresztnev,osztaly,szuletesiev):
        self.vezeteknev=vezeteknev
        self.keresztnev=keresztnev
        self.osztaly=osztaly
        self.szuletesiev=int(szuletesiev)

    def Eletkor(self):
        return 2021-self.szuletesiev


tanulo=Tanulo("Nagy","Jupát","9/n",2002)

print(tanulo.vezeteknev,tanulo.keresztnev,tanulo.szuletesiev,tanulo.Eletkor())

tanulok=[]
tanulok.append(tanulo)

for i in range(0,3):
    vezneve=input("Vezetékneve:")
    kerneve=input("Keresztneve:")
    osztalya=input("Osztálya:")
    szuleve=int(input("Születési éve"))
    tanulo=Tanulo(vezneve,kerneve,osztalya,szuleve)
    tanulok.append(tanulo)

for i in tanulok:
    print(i.vezeteknev, i.keresztnev, i.szuletesiev, i.Eletkor())

