from random import randint

jegyek = []
for i in range(6):
    jegyek.append(randint(1, 5))

print(jegyek)

# B.	Egy diák évvégi jegyeinek ismeretében döntse el a program, hogy bukott-e a diák!
# megbukott = False
# for i in range(len(jegyek)):
#     if jegyek[i] == 1:
#         megbukott = True
#         break
# if megbukott: print("Megbukott!")
# if not megbukott: print("Átment!")

# B.	Egy diák évvégi jegyeinek ismeretében döntse el a program, hogy van-e 3-asnál rosszabb jegye a diáknak!
# van = False
# for i in range(len(jegyek)):
#     if jegyek[i] < 3:
#         van = True
# if van: print("Van nagyobb mint három!")
# if not van: print("Van kissebb mint három!")

# C.	Egy diák évvégi jegyeinek ismeretében döntse el a program, hogy kitűnő-e a diák (minden jegye 5 )!

