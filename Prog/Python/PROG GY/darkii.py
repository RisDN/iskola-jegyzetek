import asdad as f


szamok = []
f.listaveletlen(szamok,100,-38,70)
f.kiirtfolytonosan(szamok,",")
osszeg=f.osszegzes(szamok)
max=f.maxertek(szamok)
min = f.minertek(szamok)
print(f"\na számok osszege {osszeg}")
print(f"a szamok atlaga {osszeg/len(szamok)}")
print(f"A legnagyobb szam {max}")
print(f"A legkisebb szam {min}")
print(f"a legnagyobb szam helye {f.maxindex(szamok)+1}")
print(f"a legkisebb szam helye {f.minindex(szamok)+1}")
print(f"a legnagyobb szam {f.megszamol(szamok,max)} alkalommal furdel elo        ")


