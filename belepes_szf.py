import getpass
# coding: utf8

felhasznalo="bori99"
jelszo="qwerty"

# Kérjünk be felhasználónevet, majd jelszót, és ha megfelelo, akkor engedélyezze
# a belépést
# A jelszó lehetőség szerint ne jelenjen meg!


engedely=False

while engedely==False:
    user=input("Add meg a felhasználó nevét:".encode('cp1252'))

    #passw=input("A jelszó:")
    passw=getpass.getpass(prompt="A jelszó:")

    if user==felhasznalo and passw==jelszo:
        print("Belépés OK")
        engedely=True
    else:
        print("Belépés megtagadva!")

