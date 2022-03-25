# AUTÓPIAC 
# Egy használtautó kereskedésben kapható autók adatait tartalmazza az autopiac.txt fájl. 
# Az állományban soronként, pontosvesszővel elválasztva találhatók a következő adatok: az autó 
# rendszáma, az autó típusa, az autó gyártási éve és végül az autó ára. 
# Az állományban legfeljebb 40 autó adata található. 


# a) A program az indításakor beolvassa az adatokat az 
# autopiac.txt fájlból a megfelelő adatszerkezet(ek)be

import modul as m

lista = []
for i in open('autopiac.txt', 'r', encoding="utf-8"):
    vagott = i.strip().split(';')
    lista.append(m.Kocsi(vagott[0], vagott[1], vagott[2], vagott[3]))

# b) Mennyi a kereskedés autóinak összértéke?
print(f'Kocsik összértéke: {m.osszertek(lista)}')

# c) Hány Opel van az autók között?
print(f'{m.hanyOpel(lista)}db opel van a kocsik közt')

# d) Mi a legrégebbi autó típusa, évjárata és mennyi az ára?
legregebbiIndex = m.legregebbiIndex(lista)
print(f'A legrégebbi autó egy {lista[legregebbiIndex].gyev} évjáratú {lista[legregebbiIndex].modell} amely {lista[legregebbiIndex].ar} forintba kerül')

# e) Mennyi a Skodák átlagos ára
print(f'Skodák árainak átlaga: {m.skodaAtlag(lista)}')