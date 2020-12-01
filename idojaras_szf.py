from _collections import OrderedDict
class Idoadat:
    def __init__(self,ev,honap,nap,ora,homerseklet,szelsebesseg,paratartalom):
        self.ev=int(ev)
        self.honap=int(honap)
        self.nap=int(nap)
        self.ora=int(ora)
        self.homerseklet=float(homerseklet)
        self.szelsebesseg=float(szelsebesseg)
        self.paratartalom=float(paratartalom)


idoadatok=[]

#Fájl betöltés->feldolgozás

fajl=open("g:/idojaras.csv",'r')

fajl.readline()

for i in fajl:
    elemek=i.strip().split(';')
    idoadat=Idoadat(elemek[0],elemek[1],elemek[2],elemek[3],
                    elemek[4].replace(',','.'),
                    elemek[5].replace(',','.'),
                    elemek[6].replace(',','.'))
    idoadatok.append(idoadat)

print(len(idoadatok))

# Évenként hány sor adatot tartalmaz a lista
# szótár -> kulcs-érték párokat tartalmaz

#Üres szótár létrehozása
evesadat={}

for i in idoadatok:
    if i.ev in evesadat:
        evesadat[i.ev]+=1
    else:
        evesadat[i.ev]=1

print(evesadat)

r_evesadat=OrderedDict(sorted(evesadat.items()))

print(r_evesadat)

evhoadat={}

for i in idoadatok:
    kulcs="{}.{}".format(i.ev,i.honap)
    if kulcs in evhoadat:
        evhoadat[kulcs]+=1
    else:
        evhoadat[kulcs]=1

print(evhoadat)

r_evhoadat=OrderedDict(sorted(evhoadat.items()))

print(r_evhoadat)

evhoadat={}

for i in idoadatok:
    kulcs=(i.ev,i.honap)
    if kulcs in evhoadat:
        evhoadat[kulcs]+=1
    else:
        evhoadat[kulcs]=1

print(evhoadat)

r_evhoadat=OrderedDict(sorted(evhoadat.items()))

print(r_evhoadat)

# Tuple -> olyan lista, amelynek az elemeit nem lehet megváltoztatni

tup=(2,4,6,8,10)
print(tup[1])
#tup[1]=234

# Határozzuk meg, hogy az egyes évek hónapjaiban mekkora volt a maximális hőmérséklet!
maxho={}

for i in idoadatok:
    kulcs=(i.ev,i.honap)
    if kulcs in maxho:
        if i.homerseklet>maxho[kulcs]:
            maxho[kulcs]=i.homerseklet
    else:
        maxho[kulcs]=i.homerseklet

print(maxho)

r_maxhoadat=OrderedDict(sorted(maxho.items()))

print(r_maxhoadat)

minho={}

for i in idoadatok:
    kulcs=(i.ev,i.honap)
    if kulcs in minho:
        if i.homerseklet<minho[kulcs]:
            minho[kulcs]=i.homerseklet
    else:
        minho[kulcs]=i.homerseklet

print(minho)

r_minhoadat=OrderedDict(sorted(minho.items()))

print(r_minhoadat)

# Határozzuk meg az egyes évek hónapjainak átlaghőmérsékletét!
atlagho={}

for i in idoadatok:
    kulcs=(i.ev,i.honap)
    if kulcs in atlagho:
        atlagho[kulcs][0]+=i.homerseklet
        atlagho[kulcs][1]+=1
    else:
        atlagho[kulcs]=[i.homerseklet,1]


print(atlagho)

for i,j in atlagho.items():
    print("{}.{}:{}".format(i[0],i[1],j[0]/j[1]))