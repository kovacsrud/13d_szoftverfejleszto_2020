import random


def nevelo(szo):
    maganhangzok='aáeéiíoóöőuúüű'
    if szo[0].lower() in maganhangzok:
        return 'Az'
    else:
        return 'A'

def jelzo():
    return random.choice(['piros','nagy','könnyed'])


for i in range(0,3):
    bekertszo=input("Adj meg egy szót:")
    print(nevelo(bekertszo)+" "+bekertszo+" "+jelzo()+".")