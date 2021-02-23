
def oraperc(filmcim,jatekido):
    ora=0
    perc=0
    # a // művelet a maradékos osztás egész részét adja
    ora=jatekido//60
    perc=jatekido%60

    return "A(z)"+filmcim+" "+str(ora)+" óra "+str(perc)+" perc"

for i in range(0,3):
    filmcim=input("Adja meg a film címét!")
    jatekido=int(input("A film hossza percben:"))
    print(oraperc(filmcim,jatekido))