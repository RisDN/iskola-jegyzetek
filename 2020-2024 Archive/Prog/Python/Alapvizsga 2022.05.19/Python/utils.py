
def atlagKoltseg(lista):
    osszeg = 0
    for i in lista:
        osszeg += i.koltseg
    return osszeg/len(lista)

def legjobbKoltseguFilm(lista):
    filmek_aranyai = []
    for i in lista:
        filmek_aranyai.append(i.bevetel/i.koltseg)
    max = 0
    index = 0
    for i in range(len(filmek_aranyai)):
        if filmek_aranyai[i] > max:
            max = filmek_aranyai[i] 
            index = i
    return index

def kereses(lista, mit):
    egyezoek = []
    for i in lista:
        if i.bemutatas.split('-')[0] == mit:
            egyezoek.append(i.cim)
    return egyezoek