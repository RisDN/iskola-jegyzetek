from random import randint

jegyek = []
lehetosegek = [0, 0, 0, 0, 0]
osszeg = 0

for i in range(150):
    jegy = randint(1, 5)
    osszeg += jegy
    lehetosegek[jegy-1] += 1
    jegyek.append(jegy)

print(lehetosegek, '\n')
# Melyikből van a legtöbb?
max = 0
for i in range(1, len(lehetosegek)):
    if lehetosegek[i] > lehetosegek[max]:
        max = i
print(f'A(z) {max+1} jegyből van a legtöbb: ')

# Melyikből van a legkevesebb?
min = 0
for i in range(1, len(lehetosegek)):
    if lehetosegek[i] < lehetosegek[min]:
        min = i
print(f'A(z) {min+1} jegyből van a legtöbb: ')

# Van-e olyan osztályzat, amelynek a darabszáma pontosan az összes jegy 1/5 része?
i = 0
while i < len(lehetosegek) and lehetosegek[i] != len(jegyek)/5:
    i += 1

if i < len(lehetosegek): print("Van")
else: print("Nincs")

# Minden osztályzat előfordul legalább 25-ször?
i = 0
while i < len(lehetosegek) and lehetosegek[i] >= 25:
    i += 1

if i < len(lehetosegek): print("Nem mindegyik legalább 25")
else: print("Mindegyik legalább 25")



