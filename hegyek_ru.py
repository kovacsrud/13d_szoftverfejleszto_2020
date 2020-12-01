
class Hegycsucs:
    def __init__(self,hegycsucsneve,hegyseg,magassag):
        self.hegycsucsneve=hegycsucsneve
        self.hegyseg=hegyseg
        self.magassag=int(magassag)


hegysegek=[]

#Fájl megnyitása olvasásra
fajl=open("g:/hegyekMo.txt",'r',encoding="utf-8")

fajl.readline()

for i in fajl:
    elemek=i.strip().split(';')
    hegycsucs=Hegycsucs(elemek[0],elemek[1],elemek[2])
    hegysegek.append(hegycsucs)

fajl.close()

print("Az állományban {} sor található".format(len(hegysegek)))

#Átlagmagasság meghatározása

osszmagassag=0

for i in hegysegek:
    osszmagassag+=i.magassag

print("Az átlagos magasság:{} m".format(osszmagassag/len(hegysegek)))

maxmagassag=0

for i in hegysegek:
    if i.magassag>maxmagassag:
        maxmagassag=i.magassag

maxcsucs=list(filter(lambda x:x.magassag==maxmagassag,hegysegek))

print("A legmagasabb:{},{} m".format(maxcsucs[0].hegycsucsneve,maxcsucs[0].magassag))

maxcsucs2=max(hegysegek,key=lambda x:x.magassag)


print("A legmagasabb:{},{} m".format(maxcsucs2.hegycsucsneve,maxcsucs2.magassag))

print("Adjon meg egy magasságot:",end="")
bemagassag=int(input())

borzsony=list(filter(lambda x:x.hegyseg=="Börzsöny" and x.magassag>bemagassag,hegysegek))

if len(borzsony)>0:
    print("Van {} m magasságnál magasabb".format(bemagassag))
else:
    print("Nincs {} m magasságnál magasabb".format(bemagassag))


#3000 lábnál magasabbak
magassag3000=list(filter(lambda x:x.magassag*3.28>3000,hegysegek))

print("3000 lábnál magasabb hegycsúcsok száma:{}".format(len(magassag3000)))

stat={}

for i in hegysegek:
    if i.hegyseg in stat:
        stat[i.hegyseg]+=1
    else:
        stat[i.hegyseg]=1

for i,j in stat.items():
    print("{} - {} db".format(i,j))

bukkvidek=list(filter(lambda x:x.hegyseg=="Bükk-vidék",hegysegek))

fajl=open("bukk-videk.txt",'w',encoding="utf-8")

fajl.write("Hegycsúcs neve;Magasság láb\n")

for i in bukkvidek:
    fajl.write("{};{:0.1f}".format(i.hegycsucsneve,i.magassag*3.28).strip('0').strip('.'))
    fajl.write("\n")
    


fajl.close()




