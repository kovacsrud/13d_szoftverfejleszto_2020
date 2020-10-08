
#A Python alapból listákat kezel
#A tömbök elemszám kötött, a listáké nem

szamok=[10,133,45,667,54,34]

szamok.append(555)
szamok.append(416)

szamok.insert(0,111)
szamok.insert(3,333)

szamok.remove(333)

szamok.clear()

print(szamok)

nevekszama=int(input())
nevek=[]

for i in range(0,nevekszama):
        nevek.append(input())

print(nevek)



