from modul2 import halmaz_letrehozas
from modul2 import halmazok_metszete
halmaz_A = halmaz_letrehozas('A')
halmaz_B = halmaz_letrehozas('B')
print(f"'A'∩'B' metszete: {halmazok_metszete(halmaz_A, halmaz_B)}")