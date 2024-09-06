def start():
	napszam = input('Kérlek adj meg egy számot (1-7)')
	try:
		napszam = int(napszam)
		print('Ma', nap_szamitas(napszam), 'van')
	except:
		start()


def nap_szamitas(nap):
	if nap == 1: return 'hétfő'
	if nap == 2: return 'kedd'
	if nap == 3: return 'szerda'
	if nap == 4: return 'csütörtök'
	if nap == 5: return 'péntek'
	if nap == 6: return 'szombat'
	if nap == 7: return 'vasárnap'

start()