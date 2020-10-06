# Tömbök
# Alapvetően a Python-ban lista van




szamok=[12,23,45,556,778,882,122,556,334,667]

print(szamok)

print(len(szamok))

for i in range(0,len(szamok)):
    print(str(i)+" "+str(szamok[i]))


print("Ez már nem része a ciklusnak")

# For ciklus az elemek bejárására
for i in szamok:
    print(i)

#range függvény

r=range(0,20)
print(*r)



