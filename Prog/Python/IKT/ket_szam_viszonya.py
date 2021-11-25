szam = int(input('Adj meg egy számot: '))
szam2 = int(input('Adj meg még egy számot: '))


if szam == szam2:
	print('A két szám egyenlő')

if szam < szam2:
	print('A második megadott szám a nagyobb! ', szam2)
else:
	print('Az első megadott szám a nagyobb! ', szam)

if szam == 0:
	print('Az első megadott szám 0!')
if szam2 == 0:
	print('A második megadott szám 0!')

if szam < 0:
	print('Az első megadott szám negatív!', szam)
if szam2 < 0:
	print('A második megadott szám negatív!', szam2)


