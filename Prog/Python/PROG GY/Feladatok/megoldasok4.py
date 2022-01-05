# 1.  Írjuk ki „ritkítva” a nevünket (minden karakter után tegyünk egy szóközt).
# nev = "Rostás András"
# for i in range(len(nev)):
#     print(nev[i], end=" ")


# 2. Írassuk ki a nevünket függőlegesen!
# nev = "Rostás András"
# for i in nev:
#     print(i)


# 3. Írassuk ki a nevünket átlósan!
# hely = " "
# nev = "Rostás András"
# i = -1
# while i < len(nev)-1:
#     i = i + 1
#     print(i*hely, nev[i])


# 4. Kérjünk be egy szót, majd írjuk ki * karakterekkel bekeretezve!
# szo = input("Adj meg egy szót: ")
# hossz = len(szo) + 2
# cs = "*"
# print(hossz * cs)
# print(f"{cs}{szo}{cs}")
# print(hossz * cs)


# 5. Kérjünk be egy tetszőleges szöveget, és írassuk ki fordítva
# szoveg = input("Tetszőleges szöveg: ")
# hossz = len(szoveg) -1 
# u = ""
# for i in range(hossz, -1, -1):
#     u+= szoveg[i]
# print(u)


# 6. Kérjünk be egy tetszőleges szöveget, és számoljuk meg, hogy hány "e" betű van benne!
# szoveg = input("Tetszőleges szöveg: ")
# hossz = len(szoveg)
# e = 0
# for i in range(hossz):
#     if szoveg[i] == "e" or szoveg[i] == "E":
#         e = e + 1
# print(e, "e betű van benne")


# 7. Számoljuk meg egy szövegben szereplő szavakat!
# szoveg = input("Szöveg: ")
# hossz = len(szoveg)
# s = 1
# for i in range(hossz):
#     if szoveg[i] == " ":
#         s = s + 1
# print("Ebben a mondatban", s, "db szó van")


# 8. Döntsd el a beírt mondat típusát! (kijelentő/kérdő/felszólító)
# szoveg = input("Szöveg: ")
# hossz = len(szoveg) -1
# vege = szoveg[hossz]
# if vege == "!":
#     print("A mondat felszolító")
# elif vege == "?":
#     print("A mondat kérdő")
# elif vege == ".":
#     print("A mondat kiejlentő")
# else:
#     print("Nem meghatározott")

# 9. Írassunk ki egy szöveget csupa nagybetűvel/ kisbetűvel.
# szoveg = input("Szöveg: ")
# nagy = szoveg.upper()
# print(nagy, "\n")
# kicsi = szoveg.lower()
# print(kicsi)


# 10. Kérjünk be egy szót, és cseréljük le az első karakterét nagybetűre!

# szoveg = input("Szöveg: ")
# hossz = len(szoveg) -1
# s = ""
# i = 0
# s += szoveg[0].upper()
# while i < hossz:
#     i = i + 1
#     s += szoveg[i]
# print(s)


# szoveg = input("Szöveg: ")
# print(szoveg.capitalize())


# 14 Kérjünk be egy szót és cseréljük le benne a magyar ékezetes betűket az angol ábécé megfelelő ékezet nélküli betűire.
# szo = input("Szó: ")
# szo = szo.replace("á", "a")
# szo = szo.replace("é", "e")
# szo = szo.replace("í", "i")
# szo = szo.replace("ö", "o")
# szo = szo.replace("ő", "o")
# szo = szo.replace("ü", "u")
# szo = szo.replace("ű", "u")
# print(szo)


#15 Olvassunk be egy szöveget, majd írjuk ki szavanként külön sorba! (Cseréljük le a szóközöket sortörésre!)
# szo = input("Szó: ")
# szo = szo.replace(" ", "\n")
<<<<<<< Updated upstream:Prog/Python/PROG GY/Feladatok/megoldasok4.py
# print(szo)
=======
# print(szo)
>>>>>>> Stashed changes:Prog/Python/PROG GY/Feladatok/12.01.py
