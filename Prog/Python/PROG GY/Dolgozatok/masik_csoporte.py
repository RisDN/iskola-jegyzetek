import random
 
i = 0
helyes = 0
helytelen = 0
while i < 5:
    i = i + 1
    szam1 = random.randint(10, 99)
    szam2 = random.randint(10, 99)
    print(f"\n{i}. kör")
    print(szam1, szam2)
    print(f"A két szám összege {szam1+szam2}, különbsége {szam1-szam2} Mi lehet ez a két szám? ")
    tipp1 = int(input("Első szám: "))
    tipp2 = int(input("Második szám: "))
    if tipp1 == szam1 and tipp2 == szam2:
        print("Helyes")
        helyes = helyes + 1
    elif tipp2 == szam1 and tipp1 == szam2:
        print("Helyes")
        helyes = helyes + 1
    else:
        print("Helytelen")
        helytelen = helytelen + 1
else:
    print(f"Vége!\nPontszám: {helyes}/5")
