# Python ismeretek

Fejlesztő környezet: Anaconda->Spyder

Egyszerű szöveg kííratása:
```python
print("Hello World!")
print('Hello World')
```
Számok esetében az eredmény jelenik meg:
```python
print(2+8+21)
print((2*10)+251)
```

A nullával való osztás hibát okoz(division by zero):
```python
print(10/0)
```
Karakterek esetében a + összefűzést jelent.
```python
print('2'+'2')
```
Háromszor kiírja a szöveget
```python
print("valami "*3)
```
Hatványozás
```python
print(2**2)
```
### Változók

A változók a memória valamely részét jelentik, ahol értéket tárolhatunk. A változót egy névvel azonosítjuk.

```python
a=10
b=2
```
Pythonban a változók típusának beállítása automatikus, a változóba beírt érték típusa alapján végzi a nyelv.

### Értékadó utasítások

```python
a=10
b=2

a=a+b
a=a*b

print(a)
```
**Értékadások rövidített formában**
```python
a+=b
a*=b
a-=b
a/=b
```
### Bevitel a felhasználótól, az input() függvény

Alaphelyzetben az input() szöveges adatot tesz a változóba.
```c#
a=input()
b=input()

print(a+b)
```
### Bevitel egész típusú változóba
Itt az int() függvény alakítja át a szöveges adatot szám típusúra.
```python
a=int(input())
b=int(input())

print(a+b)
```
