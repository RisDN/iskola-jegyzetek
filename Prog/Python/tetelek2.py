from operator import index
from random import randint

M = []
R = []

for i in range(12):
    M.append(randint(50, 150))
    R.append(randint(50, 150))

print(M)
print(R)
print()
# Mennyi papírt gyűjtött az év során a két csapat külön-külön, illetve együtt?
M_OSSZEG = 0
R_OSSZEG = 0

for m, r in zip(M, R):
    M_OSSZEG += m
    R_OSSZEG += r

print("Papírgyűjtési adatok:")
print(f"Mókus: {int(M_OSSZEG/len(M))}kg")
print(f"Réka: {int(R_OSSZEG/len(R))}kg")

# Hány olyan hónap volt, amikor együtt 200 kg-nál több papírt gyűjtöttek?
db = 0
for m, r in zip(M, R):
    if m+r>200:
        db += 1
print(db, "db olyan hónap volt, amikor együtt 200 kg-nál több papírt gyűjtöttek")

# Hány olyan hónap volt, amikor a Mókus csapat több papírt gyűjtött?
db = 0
for m, r in zip(M, R):
    if m > r:
        db += 1
print(db, "db olyan hónap volt, amikor a Mókus csapat több papírt gyűjtött")

# Volt-e olyan hónap, amikor 200 kg-nál kevesebb papírt gyűjtöttek?
db = 0
for m, r in zip(M, R):
    if m+r<200:
        db += 1
print(db, "db olyan hónap, amikor 200 kg-nál kevesebb papírt gyűjtöttek")

# Mennyi volt a legtöbb havi gyűjtött papírmennyiség, 
# és azt melyik csapat gyűjtötte melyik hónapban?

maxM = 0
for i in range(len(M)):
    if M[i] > M[maxM]:
        maxM = i 
        
maxR = 0
for i in range(len(R)):
    if R[i] > R[maxR]:
        maxR = i 

if M[maxM] > R[maxR]: print(f"A mókus csapat gyűjtött többet a {maxM+1}. hónapban")
else: print(f"A Róka csapat gyűjtött többet a {maxR+1}. hónapban")





