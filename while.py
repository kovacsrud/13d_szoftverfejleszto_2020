
# while elöltesztelő ciklus


# Írjon programot ami bekér két egész számot (a,b), majd elvégzi
# a következő műveletet c=a/b és utána kiírja c értékét

a=int(input())
b=int(input())
#b nem lehet 0!
while(b==0):
    print("Rossz! Ne legyen 0!")
    b = int(input())

c=a/b

print(c)


