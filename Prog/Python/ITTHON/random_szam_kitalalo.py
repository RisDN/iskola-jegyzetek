import random
probalkozasok = 1
vonal = '--------------------------------------------'

def tippeles(random_szam):
	global probalkozasok
	tipp = input('Tippelj, mi lehet az: ')
	try:
		tipp = int(tipp)
		while random_szam != tipp:
			probalkozasok = probalkozasok + 1
			if random_szam < tipp:
				tipp = int(input(f'{vonal}\n#{probalkozasok} | Kevesebb!\nTippelj újra: '))
			if random_szam > tipp:
				tipp = int(input(f'{vonal}\n#{probalkozasok} | Több!\nTippelj újra: '))
		else:
			print(f'{vonal}\nEltaláltad!\nA szám amire gondoltam a {random_szam} volt\nEzt {probalkozasok} tippelésből találtad ki!')
	except:
		tippeles(random_szam)

def start():
	print(vonal, '\nGondoltam egy egyész számra 1 és 100 között.\n' + vonal)
	random_szam = random.randint(1, 100)
	tippeles(random_szam)

start()