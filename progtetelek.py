
#Programozási tételek azaz elemi algoritmusok

szamok=[12,-21,33,167,88,-76,-19,320,-89]

negativak=[]
print(*range(0,len(szamok)))

for i in range(0,len(szamok)):
    if(szamok[i]<0):
        negativak.append(szamok[i])

print(negativak)

#Összegzés
osszeg=0
for i in range(0,len(szamok)):
    osszeg=osszeg+szamok[i]
    #osszeg+=szamok[i]
print(osszeg)

#Megszámlálás
darab=0
for i in range(0,len(szamok)):
    if(szamok[i]>-1):
        darab+=1

print(darab)

#Minimum,maximum kiválasztás
min=szamok[0]
max=szamok[0]

for i in range(0,len(szamok)):
    if(szamok[i]<min):
        min=szamok[i]
    if(szamok[i]>max):
        max=szamok[i]

print("Min:"+str(min))
print("Max:"+str(max))

#Rendezés,növekvő vagy akár csökkenő sorrendbe

for i in range(0,len(szamok)-1):
    for j in range(i+1,len(szamok)):
        if(szamok[i]<szamok[j]):
            temp=szamok[i]
            szamok[i]=szamok[j]
            szamok[j]=temp

print(szamok)
