
def lab2meter(lab):
    return lab*0.3048

lab=float(input("Adj meg hosszúságot lábban értve:"))

while lab!=0:
    print(lab, "láb az",lab2meter(lab),"méter")
    lab = float(input("Adj meg hosszúságot lábban értve:"))
