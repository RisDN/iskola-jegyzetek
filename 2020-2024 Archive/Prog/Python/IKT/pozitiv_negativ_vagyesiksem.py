def start():
	szam = input('Kérlek adj meg egy számot: ')
	try:
		szam = int(szam)
		if szam > 0:
			print('A szám pozitív!')
		elif szam < 0:
			print('A szám negatív')
		else:
			print('A szám sem pozitív sem negatív!')
	except:
		print('\nKérlek egy egyész számot adj meg!')
		start()

start()