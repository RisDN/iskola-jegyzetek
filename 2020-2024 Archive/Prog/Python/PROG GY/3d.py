l = []
for x in range(3):
    for y in range(3):
        for z in range(3):
            if x == y and y == z:
                l.append(1)
            else:
                l.append(0)
print(l)

#eredmeny = 
# 1, 0, 0, 
# 0, 0, 0,
# 0, 0, 0,

# 0, 0, 0,
# 0, 1, 0,
# 0, 0, 0,

# 0, 0, 0,
# 0, 0, 0,
# 0, 0, 1
