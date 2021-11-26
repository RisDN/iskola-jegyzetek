import math
a = int(input("Add meg az A-t: "))
b = int(input("Add meg a B-t: "))
c = int(input("Add meg a C-t: "))

minusz_b = -1*b
#print("MinuszB:", minusz_b)

b_a_masodikon = math.pow(b, 2)
#print("BaMasodikon:", b_a_masodikon)

gyok_alatt = b_a_masodikon-(4*a*c)
#print("Gyök alatt vonás előtt: ", gyok_alatt)

gyokvonas_utan = math.sqrt(gyok_alatt)
#print("Gyökvonás utan:", gyokvonas_utan)

x1 = (minusz_b+gyokvonas_utan)/(2*a)
print("X1=", x1)

x2 = (minusz_b-gyokvonas_utan)/(2*a)
print("X2=", x2)
