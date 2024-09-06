
def nyeremenySzamitas(megadott_szam):
	if megadott_szam == 1: return '0'
	if megadott_szam == 2: return '1500'
	if megadott_szam == 3: return '18000'
	if megadott_szam == 4: return '10000000'
	if megadott_szam == 5: return '150000000000'
	else: return ''

def start():
	talalatok_szama = input('Kérlek add meg találataid számát: ')
	try:
		talalatok_szama = int(talalatok_szama)
		print('Az ön nyereménye ' + nyeremenySzamitas(talalatok_szama) + ' Ft')
	except:
		start()

start()
