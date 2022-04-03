
def halmaz_letrehozas(neve):
    print()
    lista = []
    i = 1
    bekeres = input(f"'{neve}' halmaz {i}. eleme: ")
    lista.append(int(bekeres))
    while True:
        i += 1
        bekeres = input(f"'{neve}' halmaz {i}. eleme: ")
        if bekeres == '': break
        else:
            if int(bekeres) not in lista:
                lista.append(int(bekeres))
            else:
                i = i-1
                print(f"HIBA! a(z) {bekeres} már benne van a(z) '{neve}' halmazban!")
    print(f"'{neve}' halmaz feltöltése befejeződött!")
    return lista

def halmazok_metszete(a, b):
    lista = []
    for i in a:
        for y in b:
            if i == y: 
                lista.append(i)
    return lista