# 2021.10.13
csoport = input('Melyik csoportot szeretnéd megnézni?')

if csoport == 'a' or csoport == 'A':
	melyik = 'szárát'
elif csoport == 'b' or csoport == 'B':
	melyik = 'oldalát'


a = int(input('Kérlek add meg a háromszög A ' + melyik + ': '))
b = int(input('Kérlek add meg a háromszög B ' + melyik + ': '))
c = int(input('Kérlek add meg a háromszög C ' + melyik + ': '))

if a == b:
	if b == c:
		print('Egyenlő szárú!')
	elif c != a:
		print('Nem egyenlő!')
else:
	print('Nem egyenlő!')