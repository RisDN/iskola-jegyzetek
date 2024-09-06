print('ax+b=0\n')
def start():
	a = int(input('A értéke: '))
	if a != 0:
		b = int(input('B értéke: '))
		x = (-b)/a
		print('X értéke:', x)
	else:
		print('Az A nem lehet 0!')
		start()
start()
