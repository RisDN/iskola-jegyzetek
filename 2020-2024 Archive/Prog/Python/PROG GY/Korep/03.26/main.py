import modul as m

# 1. Feladat
# A program olvassa be a titanic.txt állományban lév adatokat,
# és tárolja el egy olyan adatszerkezetben, ami a további 
# feladatok megoldására alkalmas! A fájlban legfeljebb 20 sor van.
f = open('titanic.txt', 'r', encoding="utf-8")
lista = []
for i in f:
    vagott = i.strip().split(';')
    lista.append(m.Kategoria(vagott[0], vagott[1], vagott[2]))

# 2. Feladat
# Határozza meg, és írja ki a képerny re a minta szerint, 
# hogy az állományban hány kategória (adatsor) található!
kategoriak = []
for i in lista:
    if i.nev not in kategoriak:
        kategoriak.append(i.nev)
print(f'2. feladat: {len(kategoriak)} db')

# 3. Feladat
# Állapítsa meg és írja ki a képernyőre a minta szerint, 
# hogy a kategóriákban összesen hány személy található! 

osszeg = 0
for i in lista:
    osszeg += i.tulelok + i.eltuntek
print(f'3. feladat: {osszeg} fő')

# 4. Feladat
# Kérjen be a felhasználótól kereséshez egy kulcsszót vagy
# a kulcsszó egy részét! Állapítsa meg, hogy a megadott karakterlánc 
# megtalálható-e a kategóriák neveiben! A keresés eredményét Van találat!,
# vagy Nincs találat! formában írja ki a képernyőre! 

kereses = input('4. feladat: Kulcsszó: ')
i = 0
while i < len(lista) and kereses.lower() not in lista[i].nev.lower():
    i += 1
if i < len(lista): 
    
    print('        Van találat!')
    # 5. Feladat
    # Ha az előző feladatban volt találat a kategóriára, akkor
    # listázza ki a keresésnek megfelelő kategóriák nevét és a kategóriákba 
    # sorolt utasok létszámát a minta szerint! 
    print('5. feladat: ')
    for i in lista:
        if kereses.lower() in i.nev.lower():
            print(f'        {i.nev} {i.tulelok + i.eltuntek} fő')


else: print('Nincs!')


# 6. Feladat
# Készítsen listát azon kategóriákról, ahol az eltűntek aránya meghaladta a 60%-ot!
# Az elkészült listát írja ki a képernyőre a minta szerint!
print('6. feladat: ')
for i in lista:
    if i.eltuntek > 0:
        osszeg = i.tulelok + i.eltuntek # Összesen mennyien voltak az osztalyon (100%)
        hatvan = osszeg*0.60
        if hatvan < i.eltuntek:
            print(f'        {i.nev}')

# 7. Feladat
# Határozza meg és írja ki a képernyőre a minta szerint, hogy melyik kategóriában volt a
# legtöbb túlélő! Feltételezheti, hogy a kategóriák nem tartalmaznak azonos számú túlélőt. 

max = lista[0].tulelok
index = 0
for i in range(1, len(lista)):
    if lista[i].tulelok > max:
        max = lista[i].tulelok
        index = i
print(f'7. feladat: {lista[index].nev}')