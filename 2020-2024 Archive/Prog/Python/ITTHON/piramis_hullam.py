from time import sleep
gyorsasag = 0.09
while True:
    for i in range(0, 11, +1):
        print(i * '*')
        sleep(gyorsasag)
        
    for a in range(11, 0, -1):
        print(a * '*')
        sleep(gyorsasag)
