import random
 
valasz = {} 
 
wau = True
while wau:
 nev = input("Mi a neved: ")
 print("")
 
 print(">Kezdődhet a játék<" "\n" "Üdvözöllek: " + nev )
 print("")
 
 bot = random.randint(1,6)
 jatekos = random.randint(1,6)
 print("A te számmod: ",jatekos, "\n" "Ellenfeled száma: ",bot,"\n")
 if jatekos < bot:
 	print("Az ellenfél győzött!")
 elif jatekos > bot:
 	print("Te győztél!")
 else:
 	print("Döntetlen!")
 
 valasz = nev
 
 repeat = input("Szeretnél még játszani? :")
 
 if repeat == "nem":
 	wau = False
 	print("Viszlát!" "\n" "------------------------------")
 if repeat == "igen":
	 wau = True