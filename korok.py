import math
import random as rnd


class Kor:
    def __init__(self,sugar):
        self.sugar=sugar

    def Kerulet(self):
        return 2*self.sugar*math.pi

    def Terulet(self):
        return self.sugar*self.sugar*math.pi


kor=Kor(20)

print(kor.sugar)
print(kor.Kerulet())
print(kor.Terulet())

korok=[]

for i in range(0,100):
    kor=Kor(rnd.randint(1,50))
    korok.append(kor)

print(len(korok))

for i in range(0,100):
    print("Kerület:"+str(korok[i].Kerulet())+","+"Terület:"+str(korok[i].Terulet()))

kiskorok=list(filter(lambda x:x.Kerulet()<100,korok))

