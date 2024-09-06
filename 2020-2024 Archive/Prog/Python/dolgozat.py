#Készíts programot, mely rulettjátékot szimulál, és a "pörgetések" eredményét dolgozza fel. A számok 
#tárolására hozz létre egy listát! A szabvány európai típusú rulett kerék 37 számot tartalmaz, 0-tól 36-
#ig.
#A program írja a képernyőre sorfolytonosan, egymás mellé 20 pörgetés eredményét, majd 
#válaszoljon a következő kérdésekre!
#

from random import randint

lista = []

for i in range(20):
    eredmeny = randint(0, 36)
    lista.append(eredmeny)
    print(eredmeny, end=', ')

print('\n')

# Átlaguk
osszeg = 0
for i in lista:
    osszeg += i 
print('A számok átlaga:', osszeg/len(lista))

# Hányszor pörgettünk 5-el osztható számot?
otosok = 0
for i in lista:
    if i%5 == 0:
        otosok += 1
print(otosok, 'alkalommal pörgettünk 5-tel osztható számot')

# Szerepel-e a pörgetett számok között a 18-as?
i = 0
while i < len(lista) and lista[i] != 18:
    i += 1
if i < len(lista): print('Volt benne 18-as')
else: print('Nem volt benne 18-as') 

#Hányadik pörgetés a legnagyobb, és mennyi az értéke?
max = 0
for i in lista:
    if i > max:
        max = i

for i in range(len(lista)):
    if lista[i] == max:
        index = i 
print(f'A(z) {max} volt a legnagyobb a(z) {index+1}. dobásra.')
