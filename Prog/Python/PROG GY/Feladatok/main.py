a = int(input('Kérlek adj meg egy szémot: '))

i = 0
s = 0
o = 0
while i < a:
    i = i + 1
    if a%i == 0:
        o += i
        s = s + 1
        print(f'#{s} {i} x {int(a/i)} = {a}')

if s == 2:
    print('A megadott szám prím.')
else:
    print(f'A megdott számnak {s} osztója van, összegük a {o}')