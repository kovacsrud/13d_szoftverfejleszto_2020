
import random as rnd

def randomLista(db,also,felso):
    lista=[]
    for i in range(0,db):
        lista.append(rnd.randint(also,felso))
    return lista

def osszeg(lista):
    osszeg=0
    for i in range(0,len(lista)):
        osszeg+=lista[i]
    return osszeg

def atlag(lista):
    osszeg=0
    for i in range(0,len(lista)):
        osszeg+=lista[i]
    return osszeg/len(lista)

def min(lista):
    min=lista[0]
    for i in range(0,len(lista)):
        if(lista[i]<min):
            min=lista[i]
    return min

def max(lista):
    max=lista[0]
    for i in range(0,len(lista)):
        if(lista[i]>max):
            max=lista[i]
    return max

szamok=randomLista(189,-100,100)
szamok2=randomLista(30,-100,100)

#print(szamok)
#print(szamok2)
print("Összeg:"+str(osszeg(szamok)))
print("Átlag:"+str(atlag(szamok)))
print("Min:"+str(min(szamok)))
print("Max:"+str(max(szamok)))







