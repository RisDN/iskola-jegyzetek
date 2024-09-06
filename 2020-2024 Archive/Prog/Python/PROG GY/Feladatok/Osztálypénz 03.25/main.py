
import modul as m

lista = []

for i in open('osztalypenz.txt', 'r', encoding="utf-8"):
    vagott = i.strip().split(';')
    lista.append(m.Tanulo(vagott[0], vagott[1], vagott[2], vagott[3], vagott[4], vagott[5], vagott[6]))

osszeg = 0
for i in lista:
    osszeg += i.penz
print(f'Összes osztálypénz: {osszeg}')

for i in lista:
    if i.penz < 4000:
        print(f'{i.neve} {i.lakcim}')


kereses = input('Adj meg egy name: ')
i = 0
while i < len(lista) and lista[i].neve.lower() != kereses.lower():
    i += 1 
if i < len(lista):
    print(f'{lista[i].neve} ennyi pénzt fizetett be eddig: {lista[i].penz}')
else:
    print('Nincs')
