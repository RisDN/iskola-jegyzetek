class Telepules:
    def __init__(self, neve, irszm):
        self.neve = neve 
        self.irszm = int(irszm)


def kereses(lista, mit):
    i = 0 
    while i < len(lista) and lista[i].irszm != mit:
        i += 1
    if i < len(lista): print(f'A {mit} írányítószámhoz {lista[i].neve} tartozik')
    else: print('Nincs ilyen írányítószám')