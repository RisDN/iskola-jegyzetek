print('3. feladat')
import modul as m
f = open('employees.txt', 'r', encoding="utf-8")
lista = []
for sor in f:
    lista.append(sor.strip())

dolgozok = []
for i in lista:
    vagott = i.split(';')
    dolgozok.append(m.Munkatars(vagott[0], vagott[1], vagott[2], vagott[3]))
print(f'3.2: a cégnél {len(dolgozok)} programozó dolgozik')
print(f'3.3: az alkalmazottak havi átlagjövedelme: ${round(m.atlagJovedelem(dolgozok), 1)}')
keresett = input('3.3: írd be a keresett nevet: ')
m.kereses(dolgozok, keresett)