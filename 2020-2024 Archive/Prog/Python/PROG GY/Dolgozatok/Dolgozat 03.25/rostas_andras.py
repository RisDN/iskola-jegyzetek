
import modul as m

f = open('iranyitoszamok.txt', 'r', encoding="utf-8")

lista = []
for i in f:
    vagott = i.strip().split(';')
    lista.append(m.Telepules(vagott[1], vagott[0]))

kereses = int(input('Adj meg egy irányítószámot: '))
eredmeny = m.kereses(lista, kereses)
