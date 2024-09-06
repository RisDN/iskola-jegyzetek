# 1. feladat
karakterlanc = input('Írjon be egy legalább 9 karakterből álló szöveget: ')
if len(karakterlanc) > 8:
    for i in range(len(karakterlanc)-1, -1, -1):
        print(karakterlanc[i].lower(), end='')
else: print(f'a(z) {karakterlanc} kevesebb, mint 9 karakter hosszú!')

# 2. feladat
print('')
print('paradicsom: \t1199 Ft/Kg')
print('paprika: \t1349 Ft/Kg')
print('vöröshagyma: \t289  Ft/Kg')

arak = {
    "paradicsom": 1119,
    "paprika": 1349,
    "vöröshagyma": 289
}
vasarlasban = True 
fizetendo = 0
while vasarlasban:
    akare = input('Kíván vásárolni? ') == 'igen'
    if akare:
        melyik = input('     Melyik termékből? ')
        if melyik in arak:
            mennyiseg = float(input(f'     Hány kg {melyik}(o)t szeretne? '))
            fizetendo += arak[melyik] * mennyiseg
        else:
            print('     Nincs ilyen termék!')
    else:
        vasarlasban = False
        print('Köszönjük a vásárlást!')
        print(f'Fizetendő összeg: {int(fizetendo)}Ft')

# 3. feladat
print('')
class Film:
    def __init__(self, cim, fazis, bemutatas, koltseg, bevetel):
            self.cim = cim 
            self.fazis = int(fazis)
            self.bemutatas = bemutatas
            self.koltseg = int(koltseg)
            self.bevetel = int(bevetel)

filmek = []
for i in open('marvel.txt', 'r', encoding="utf-8"):
    vagott = i.strip().split(';')
    filmek.append(Film(vagott[0], vagott[1], vagott[2], vagott[3], vagott[4]))

from utils import atlagKoltseg
from utils import legjobbKoltseguFilm
from utils import kereses
print(f'3.1: {len(filmek)} filmje van a marvel moziverzumának')
print(f'3.2: a filmek átlagos gyártási költésge: ${round(atlagKoltseg(filmek), 2)}M')
print(f'3.3: a leghatékonyabb film címe: {filmek[legjobbKoltseguFilm(filmek)].cim}')
keresett_evszam = input(f'3.4: írjon be egy évszámot: ')
print(f'a {keresett_evszam}-ban/ben megjelent marvel filmek: ')
for i in kereses(filmek, keresett_evszam):
    print(f'    {i}')