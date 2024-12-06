# 1. feladat
SELECT fnev FROM futar;

# 2. feladat
SELECT pizza.pnev, pizza.par FROM pizza;

# 3. feladat
SELECT AVG(pizza.par) FROM pizza;

# 4. feladat
SELECT pizza.pnev FROM pizza WHERE pizza.par < 2000;

# 5. feladat
SELECT futar.fnev FROM futar, rendeles WHERE rendeles.fazon = futar.fazon LIMIT 1;

# 6. feladat 
SELECT vevo.vnev FROM vevo, rendeles WHERE vevo.vazon = rendeles.vazon AND HOUR(rendeles.idopont) < 12;

# 7. feladat
SELECT DISTINCT pizza.pnev FROM vevo, rendeles, pizza, tetel WHERE vevo.vnev = "Morgó" AND vevo.vazon = rendeles.vazon AND tetel.razon = rendeles.razon AND tetel.pazon = pizza.pazon;

# 8. feladat
