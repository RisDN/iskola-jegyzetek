import random as r


def listaveletlen(lista,hossz,tol,ig):
    for i in range (hossz):
        lista.append(r.randint(tol,ig))

def kiirtfolytonosan(list,elvalaszto):
    for i in list:
        print(f"{i}",end=elvalaszto)

def osszegzes(lista ):
    osszeg=0
    for i in lista:
        osszeg+=i
    return osszeg


def maxertek(lista):
    max = lista[0]
    for i in range (1,len(lista)):
        if lista[i] > max: 
            max = lista[i]
    return max

def maxindex(lista):
    max=0
    for i in range (1,len(lista)):
        if lista[i] > lista[max]:
            max = i
    return max

def megszamol(lista,mit):
    db=0
    for i in lista:
        if i==mit:
            db+=1
    return db

def minindex(lista):
    min=0
    for i in range (1,len(lista)):
        if lista[i] < lista[min]:
            min = i
    return min    



def minertek(lista):
    min = lista[0]
    for i in range (1,len(lista)):
        if lista[i] < min: 
            min = lista[i]
    return min