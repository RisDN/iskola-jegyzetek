#-------------------------------------------#
# 1.
# Írj egy Python programot, amely 
# bekér három számot a felhasználótól és kiírja a 
# képernyőre a legkisebb értéket ezek közül!

# a = int(input("Első szám: "))
# b = int(input("Második szám: "))
# c = int(input("Harmadik szám: "))
# legkissebb = 0
# if a < b and a < c:
#     legkissebb = a
# if b < a and b < c:
#     legkissebb = b
# if c < a and c < b:
#     legkissebb = c
# print(f"A legkissebb szám a {legkissebb}")
#-------------------------------------------#

#-------------------------------------------#
# 2.
# Írj egy Python programot, amelybekér három 
# számot a felhasználótól és kiírja a 
# képernyőre a  legnagyobb értéket ezek közül!

# a = int(input("Első szám: "))
# b = int(input("Második szám: "))
# c = int(input("Harmadik szám: "))
# legnagyobb = 0
# if a > b and a > c :
#     legnagyobb = a
# if b > a and b > c :
#     legnagyobb = b
# if c > a and c > b :
#     legnagyobb = c
# print(f"A legnagyobb szám a {legnagyobb}")
#-------------------------------------------#

#-------------------------------------------#
# 3.
# Írj egy Python programot, amelybekér egy dolgozat
# pontszámot (x) a felhasználótól és kiír 
# egy érdemjegyet  az alábbiak szerint!
# 1: x<50; 2: 50 <= x <60; 3: 60<=x<70; 4: 70<=x<85; 5: x>=85

# # Figyelni arra, hogy a feladat megemlítette, hogy X-nek kell lennie a változónknak.
# # Segít a megadott példa, a feltételek felírásában.
# x = int(input("Kérlek add meg pontszámodat: "))
# erdemjegy = 1
# if x<50: # ha x kissebb mint 50
#     erdemjegy = 1
# elif 50 <= x and x < 60: # ha x nagyobb, vagy egyenlő mint 50 és x kissebb mint 60 (tulajdonképpen ha 50 és 60 között)
#     erdemjegy = 2
# elif 60 <= x and x < 70:
#     erdemjegy = 3
# elif 70 <= x and x < 85:
#     erdemjegy = 4
# elif x >= 85: # ha nagyobb vagy egyenlő mint 85
#     erdemjegy = 5
#print(erdemjegy)
#-------------------------------------------#

#-------------------------------------------#
# 4.
# Írj egy Python programot, amely bekér egy 
# egész számot a felhasználótól és kiírja a képernyőre,
# hogy osztható-e (igen/nem) a szám 3-mal vagy 5-tel! 

# % operátor
# Maradék képzés (modulo vagy remainder). 
# Ez az operátor azt mondja meg, hogy két tört osztásának mennyi a maradéka.

# szam = int(input("Szám: "))
# if szam%3 != 0:
#     print("Nem osztható hárommal!")
# else:
#     print("Osztható hárommal!")
# if szam%5 != 0:
#     print("Nem osztható öttel!")
# else:
#     print("Osztható öttel!")
#-------------------------------------------#

#-------------------------------------------#
# 5. (faszság)
# Írj egy Python programot, amely bekér három számot a 
# felhasználótól és kiírja a képernyőre, hogy a számok 
# közül bármelyik kettőnek az összege egyenlő-e a harmadik számmal!

# a = int(input("Első szám: "))
# b = int(input("Második szám: "))
# c = int(input("Harmadik szám: "))
# if a+b == c:
#     print("Az első és második szám összege egyenlő a harmadik számmal.")
# if a+c == b:
#     print("Az első és a harmadik szám összege egyenlő a második számmal.")
# if b+a == c:
#     print("A második és az első szám összege egyenlő a harmadik számmal.")
# if b+c == a:
#     print("A második és a harmadik szám összege egyenlő az első számmal.")
# if c+a == b:
#     print("A harmadik és az első szám összege egyenlő a második számmal.")
# if c+b == a:
#     print("A harmadik és a második szám összege egyenlő az első számmal.")
#-------------------------------------------#

#-------------------------------------------#
# 5. 
# Írj egy Python programot, amely bekér három 
# egész számot a felhasználótól és kiírja a képernyőre,
# hogy mind a három páros szám-e (igen/nem)!

# a = int(input("Első szám: "))
# b = int(input("Második szám: "))
# c = int(input("Harmadik szám: "))
# if a%2 == 0 and b%2 == 0 and c%2 == 0:
#     print("Az összes szám páros!")
# else:
#     print("Nem páros az összes szám")
#-------------------------------------------#

#-------------------------------------------#
# 7.
# Írj egy Python programot, amelybekér két szót
# a felhasználótól és ABC sorrendben 
# kiírja őket a képernyőre!

# szo1 = input("Első szó: ")
# szo2 = input("Második szó: ")
# if szo1 < szo2:
#     print(szo1)
#     print(szo2)
# else:
#     print(szo2)
#     print(szo1)
#-------------------------------------------#

#-------------------------------------------#
# 8.
# Írj egy Python programot, amely bekér egy  
# pozitív egész számot a felhasználótól és  
# kiírja a képernyőre azokat a pozitív hárommal 
# osztható számokat, amelyek kisebbek az adott számnál!

# szam = int(input("Adj meg egy pozitív egész számot: "))
# if szam <= 0:
#     print("Pozitív egész számot!")
# else:
#     for i in range(szam):
#         if i != 0:
#             if i % 3 == 0:
#                 print(i)
#-------------------------------------------#

#-------------------------------------------#
# 9.
# Írj egy Python programot, amely bekér két pozitív
# egész számot a felhasználótól és kiírja a képernyőre 
# azokat a páros számokat, amelyek a két adott érték
# közötti zárt intervallumban találhatóak!

# szam1 = int(input("Első szám: "))
# szam2 = int(input("Második szám: "))
# if szam1 < szam2:
#     for i in range(szam1, szam2, +1):
#         if i != szam1:
#             if i % 2 == 0:
#                 print(i)
# elif szam1 > szam2:
#     for i in range(szam2, szam1, +1):
#         if i != szam2:
#             if i % 2 == 0:
#                 print(i)
#-------------------------------------------#

#-------------------------------------------#
# 10.
# Írj egy Python programot, amely bekér egy  
# 20-nál nem nagyobb pozitív egész számot  
# a felhasználótól és kiírja a képernyőrea START 
# szót úgy, hogy előtte annyi szóköz legyen amennyi 
# a megadott szám értéke!

# szam = int(input("Szám: "))
# hely = " "
# if szam < 20:
#     print(hely*szam, "START")
# else:
#     print("20-nál kissebbnek kell lennie!")
#-------------------------------------------#
