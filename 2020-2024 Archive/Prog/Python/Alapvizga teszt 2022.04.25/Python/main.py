import math
print('1. feladat:')
x = int(input('Kérem a hatványalapot: '))
n = int(input('Kérem a sorozat hosszát: '))
print(f'{x} első {n} hatványa')
for i in range(1, n+1):
    print(int(math.pow(x, i)), end=" ")

print('\n2. feladat:\nÁrlista:')
print('-------------------------')
print('|pesszó kávé:\t80Ft\t|')
print('|hosszú kávé:\t90Ft\t|')
print('|cappuchino:\t100Ft\t|')
print('|extra cukor:\t+10Ft\t|')
print('|saját pohárba:\t-15Ft\t|')
print('------------------------')

milyen_kave = input('Milyen kávét szeretnél? ')
extra_cukor = input('Kérsz bele extra cukrot? (I/N)? ')
van_sajat_poharad = input('Van saját poharad? (I/N)? ')
fizetendo = 0
if milyen_kave == 'presszó': fizetendo = fizetendo + 80
elif milyen_kave == 'hosszú': fizetendo = fizetendo + 90
elif milyen_kave == 'cappuchino': fizetendo = fizetendo + 100
if extra_cukor == 'I' or extra_cukor == 'i': fizetendo = fizetendo + 10
if van_sajat_poharad == 'I' or van_sajat_poharad == 'i': fizetendo = fizetendo - 15
print(f'A kávéd {fizetendo}Ft-ba kerül!')

class Termek:
    def __init__(self, gomb, termek, ar, db):
        self.gomb = gomb 
        self.termek = termek 
        self.ar = int(ar) 
        self.db = int(db)

termekek = []
f = open('vm.txt', 'r', encoding="utf-8")
for sor in f:
    vagott = sor.strip().split(';')
    termekek.append(Termek(vagott[0], vagott[1], vagott[2], vagott[3]))

print(f'\nf3.3: Az automatában {len(termekek)} különböző termék van')

min = termekek[0].ar
index = 0
for i in range(1, len(termekek)):
    if termekek[i].ar > min:
        min = termekek[i].ar
        index = i
print(f'f3.4: A legolcsóbb termék a(z) {termekek[index].termek} ({termekek[index].ar}Ft)')

osszes_udito = 0
for i in termekek:
    if i.termek.split(' ')[2] == 'ml)':
        osszes_udito += int(i.termek.split(' ')[1].replace('(', '')) * i.db

print(f'f3.5: Összesen {round(osszes_udito/1000, 2)} liter üdítőital van még az automatában')

penz = 0
for i in termekek:
    penz += i.ar * (12 - i.db)
print(f'f3.6: Összesen {penz}Ft van az automatában')
