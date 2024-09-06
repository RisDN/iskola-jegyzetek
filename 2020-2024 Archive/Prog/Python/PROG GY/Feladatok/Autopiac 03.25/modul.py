class Kocsi:
    def __init__(self, rendszam, modell, gyev, ar):
        self.rendszam = rendszam        
        self.modell = modell
        self.gyev = int(gyev)
        self.ar = int(ar)

def osszertek(lista):
    osszeg = 0
    for i in lista:
        osszeg += i.ar 
    return osszeg

def hanyOpel(lista):
    db = 0
    for i in lista:
        if i.modell == 'Opel':
            db += 1
    return db

def legregebbiIndex(lista):
    min = lista[0].gyev
    index = 0
    for i in range(len(lista)):
        if lista[i].gyev < min:
            min = lista[i].gyev
            index = i
    return index

def skodaAtlag(lista):
    osszeg = 0 
    db = 0
    for i in lista:
        if i.modell == 'Skoda':
            db += 1
            osszeg += i.ar
    return osszeg/db 