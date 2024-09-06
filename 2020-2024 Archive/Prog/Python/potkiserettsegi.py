ig = int(input("Add meg az igazolatlan órák számát: "))
if ig < 10:
    print("Figelmeztetést kap!")
elif ig > 10 and ig < 30:
    print("Osztályfőnoki megrovást kap!")
elif ig > 30 and ig < 60:
    print("Igazgatói megrovást kap!")
elif ig > 60:
    print("Felfüggesztést kap!")
    
   

import random
lista = []
for x in range(10):
    lista.append(random.randint(40, 120))
    

jok = []
for i in lista:
    if i % 5 == 0 and i % 4 != 0:
        jok.append(i)
        print(i, end=', ')

print(f'A számok átlaga: {sum(jok)/len(jok)}')


sorok = int(input("Add meg a sorok számát: "))
oszlopok = int(input("Add meg az oszlopok számát: "))

szoveg = ""
for i in range(sorok):
    szoveg = ""
    if i%2 == 0:
        eppen = "X"
        for a in range(oszlopok):
            szoveg += eppen
            if eppen == "X":
                eppen = "O"
            else:
                eppen = "X"
        print(szoveg)
    else:
        eppen = "O"
        for a in range(oszlopok):
            szoveg += eppen
            if eppen == "X":
                eppen = "O"
            else:
                eppen = "X"
        print(szoveg)
        
        
import random 

szam = random.randint(-80, -10)
db = 0
for i in range(szam, 1, +1):
    print(i, end=" ")
    if i % 10 == 8:
        db += 1
print(f"\n{db} darab szám végződik 8-asra")