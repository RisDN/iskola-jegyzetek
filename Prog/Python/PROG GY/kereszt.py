map = [1]

a = 0
for i in range(24):
    a = a + 1
    if a == 6:
        map.append(1)
        a = 0
    else:
        map.append(0)

print(map)

#eredmeny = 1, 0, 0, 0, 0, 
#           0, 1, 0, 0, 0,
#           0, 0, 1, 0, 0,
#           0, 0, 0, 1, 0, 
#           0, 0, 0, 0, 1
