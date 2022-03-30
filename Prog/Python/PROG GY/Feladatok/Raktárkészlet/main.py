
import modul as m 

menu = True
termekek = []
for i in open('raktarkeszlet.txt', 'r', encoding="utf-8"):
    vagott = i.strip().split(',')
    termekek.append(m.Termek(vagott[0], vagott[1], vagott[2]))


while menu:
    print('\nMenü\n1. Raktárkészlet listázása\n2. A raktár termékeinek összértéke \n3. Kereső \n4. Hiánycikk kereső\n5. Kilépés')
    kerdes = input('Válassz egyet: ')
    try:
        kerdes = int(kerdes)
        if kerdes < 6 and kerdes > 0:
            if kerdes == 1: m.raktarKeszlet(termekek)
            if kerdes == 2: print(f'\nTermékek összértékek: {m.osszertek(termekek)} ft')
            if kerdes == 3: m.kereses(termekek)
            if kerdes == 4: m.hianyzo(termekek)
            if kerdes == 5: menu = False
        else:
            print('1-4-ig adj meg számot!')
    except:
        print('1-4-ig adj meg számot!')
