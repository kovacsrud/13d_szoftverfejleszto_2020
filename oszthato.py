
a=int(input("Adj meg egy számot:"))
b=int(input("Adj meg egy másik számot:"))

if a%3==0:
    print(a,"osztható 3-al")
elif b%3==0:
    print(b, "osztható 3-al")
else:
    print(a,b,"osztható 3-al")
