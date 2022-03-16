class Munkatars:
    def __init__(self, nev, jovedelem, sze, hely):
        self.nev = nev 
        self.jovedelem = jovedelem
        self.sze = int(sze)
        self.hely = hely


def atlagJovedelem(lista):
    osszeg = 0
    for i in lista:
        osszeg += int(i.jovedelem.replace('$', '')) / 12
    return osszeg/len(lista)

def kereses(lista, mit):
    vane = False
    for i in lista:
        if i.nev.lower() == mit.lower():
            vane = True 
            print(f'    életkor: {2022-i.sze}')
            print(f'    székhely: {i.hely}')
            print(f'    havi fizetés: {round((int(i.jovedelem.replace("$", ""))/12)*361.51)} HUF')
    if not vane: print('nincs ilyen nevű alkalmazott a cégnél')
