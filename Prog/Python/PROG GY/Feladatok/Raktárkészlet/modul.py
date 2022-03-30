

class Termek:
    def __init__(self, nev, egysegar, mennyiseg):
        self.nev = nev 
        self.egysegar = int(egysegar)
        self.mennyiseg = int(mennyiseg)


def raktarKeszlet(lista):
    print('\nRaktárkészlet: ')
    for i in lista:
        print(f'{i.nev}\t{i.egysegar} ft\t{i.mennyiseg} db')

def osszertek(lista):
    osszeg = 0
    for i in lista:
        osszeg += i.egysegar
    return osszeg

def kereses(lista):
    mit = input('\nMelyik terméket keresed: ')
    i = 0 
    while i < len(lista) and lista[i].nev != mit:
        i += 1
    if i < len(lista):
        print(f'A(z) {lista[i].nev} adatai:')
        print(f'Egységár: {lista[i].egysegar} ft')
        print(f'Mennyiség: {lista[i].mennyiseg} db')
    else:
        print('Nincsen ilyen termék!')

def hianyzo(lista):
    print('\nHiányzó termékek: ')
    for i in lista:
        if i.mennyiseg == 0:
            print(i.nev)