## Kérjünk be hőmérséklet értékeket addig, amíg 0-t nem adnak meg
## Írjuk ki, hogy hány pozitív és hány negatív értéket adtak meg!

pozitiv=0
negativ=0
nulla=0

ho=int(input())

while(ho!=-100):
    if(ho==0):
        nulla+=1
    elif(ho>0):
        pozitiv+=1
    else:
        negativ+=1
    ho = int(input())

print("Pozitív:"+str(pozitiv))
print("Negatív:"+str(negativ))
print("Nulla:"+str(nulla))
