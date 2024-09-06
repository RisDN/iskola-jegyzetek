vonal = '-----------------------------------'
print(vonal)
def start():
    szam1 = input('Kérlek adj meg egy számot: ')
    try:
        szam1 = int(szam1)
        szam2 = input('Kérlek adj meg még egy számot: ')
        try:
            szam2 = int(szam2)
            muvelet = input('Kérlek add meg, milyen műveletet szeretnél végrehajtani (*, /, +, -): ')
            if muvelet == '-' or '+' or '/' or '*':
                if muvelet == '-':
                    print(f'{vonal}\nEredmény: {szam1}{muvelet}{szam2}={szam1 - szam2}')
                if muvelet == '+':
                    print(f'{vonal}\nEredmény: {szam1}{muvelet}{szam2}={szam1 + szam2}')
                if muvelet == '/':
                    print(f'{vonal}\nEredmény: {szam1}{muvelet}{szam2}={szam1 / szam2}')
                if muvelet == '*':
                    print(f'{vonal}\nEredmény: {szam1}{muvelet}{szam2}={szam1 * szam2}')
            else:
                print('Kérlek valós műveleti jelent adj meg!')
                start()
        except:
            print('Egy számot adj meg!')
            start()
    except:
        print('Egy számot adj meg!')
        start()


start()
