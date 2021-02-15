
def Atlagfogyasztas(km,liter):
    return liter/(km/100)

tankoltliter=float(input("Hány liter üzemanyagot tankolt?:"))

megtettkm=float(input("Hány km-t tett meg?:"))

atlagfogyasztas=Atlagfogyasztas(megtettkm,tankoltliter)

print("Megtett km:",megtettkm,"Tankolt mennyiség:",tankoltliter,"Átlagos fogyasztás:",atlagfogyasztas)