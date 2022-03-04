# Internetforgalom 
# Szeptember hónapban feljegyeztük, hogy egy felhasználó 
# hány kilobyte adatot forgalmazott a mobil internet kapcsolatán. 
# Ezeket az adatokat tartalmazza a net.txt állomány.
# Az állomány 30 adatot tartalmaz, SORONKÉNT EGYET!


def osszegzes(lista):
    osszeg=0
    for i in lista:
        osszeg+=i
    return osszeg

def max(lista):
    max = 0
    for i in range(1, len(lista)):
        if lista[i] > max:
            max=lista[i]
    return max

def min(lista):
    min = lista[0]
    for i in range(1, len(lista)):
        if lista[i] < min:
            min = lista[i]
    return min

def mbSzamlalas(lista):
    db = 0
    for i in lista:
        if i / 1024 > 1:
            db += 1
    return db

# A PROGRAM INDULÁSAKOR beolvassa az adatokat és 
ff = open('net.txt', 'r')
netadatok = []
x = 0
# eltárolja az netadatok nevű listában. 
for i in ff:
    x += 1
    netadatok.append(int(i))
    print(f'{x}: {i}', end="") # a lista elemeit kiírja a képernyőre az alábbi formában: 

# Add meg az összes adatforgalmat! 
print(f'\nÖsszes adathasználat: {osszegzes(netadatok)}kb')

# Mennyi volt a legmagasabb napi adatforgalmazás? 
print(f'Legnagyobb napi adathasználat: {max(netadatok)}')

# Mennyi volt a legalacsonyabb napi adatforgalmazás? 
print(f'Legalacsonyabb napi adathasználat: {min(netadatok)}')

# Hány kilobyte volt az átlagos adatfelhasználás? 
# Írd bele egy atlag.txt nevű fájlba!
osszeg = 0
for i in netadatok:
    osszeg += i
atlag = open('atlag.txt', 'w')
atlag.write(str(osszeg/len(netadatok)))

# Hányszor volt 1 MB-nál nagyobb az adatforgalom?
# Ennek a feladatnak a megoldásához definiálj saját függvényt!
print(f'{mbSzamlalas(netadatok)}-szer volt 1 MB-nál nagyobb az adatforgalom?')
