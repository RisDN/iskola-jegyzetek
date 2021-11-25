import random
botnyert = 0
usernyert = 0

print("\n", "Kő | Papír | Olló", "\n")
def szamitas(bote, be):
    global botnyert
    global usernyert
    print("")
    if be == "Kilepes":
        quit()

    if bote == be:
        print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
        print(f"Robot: {bote}")
        print(f"Tied: {be}")
        print(f"Eredmény: Döntetlen!")

    # Kő a bottól
    if bote == "Kő":
        if be == "Papír":
            usernyert = usernyert + 1
            print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
            print(f"Robot: {bote}")
            print(f"Tied: {be}")
            print("Eredmény: Nyertél!")
        if be == "Olló":
            botnyert = botnyert + 1
            print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
            print(f"Robot: {bote}")
            print(f"Tied: {be}")
            print("Eredmény: Vesztettél!")

    # Papír a bottól
    if bote == "Papír":
        if be == "Olló":
            usernyert = usernyert + 1
            print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
            print(f"Robot: {bote}")
            print(f"Tied: {be}")
            print("Eredmény: Nyertél!")
        if be == "Kő":
            botnyert = botnyert + 1
            print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
            print(f"Robot: {bote}")
            print(f"Tied: {be}")
            print("Eredmény: Vesztettél!")

    # Olló a bottól
    if bote == "Olló":
        if be == "Kő":
            usernyert = usernyert + 1
            print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
            print(f"Robot: {bote}")
            print(f"Tied: {be}")
            print("Eredmény: Nyertél!")
        if be == "Papír":
            botnyert = botnyert + 1
            print(f"Eredményjelző: [Robot {botnyert}] - [Te {usernyert}]")
            print(f"Robot: {bote}")
            print(f"Tied: {be}")
            print("Eredmény: Vesztettél!")
    kerdes()

def kerdes():
    bot = random.randint(1, 3)
    print("")
    bemenet = input("Add meg a választásodat: ")
    if bot == 1:
        botv = "Kő"
    if bot == 2:
        botv = "Papír"
    if bot == 3:
        botv = "Olló"
    vegsobe = bemenet.capitalize()
    szamitas(botv, vegsobe)

kerdes()