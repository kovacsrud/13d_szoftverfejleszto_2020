# Függvények, alprogramok

def kiir():
    print("Hello")
    print("Szia")
    print("Szevasz")

def masikKiir(szoveg):
    print(szoveg)

def nevKiir(veznev,keresztnev):
    print(veznev+" "+keresztnev)

def osszead(a,b,c):
    return a+b+c

print("Alprogramok")
kiir()
kiir()
kiir()
masikKiir("Ez már okosabb")
masikKiir(123)
nevKiir("Nagy","Ubul")

c=osszead(10,20,30)
print(c)
print(osszead(10,20,30))