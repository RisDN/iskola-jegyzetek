
/* HÍREK */
Alakítsd ki a Hírek oldal tartalmát a "hirek" táblát felhasználva. A hírek időrendben inverzen legyenek, mindig a legújabb hír elöl.
A hírblokkok közt alkalmazz vízszintes vonalat elválasztásként.
Egy-egy hírblokk szerkezete:
 - Egy-egy hír címsora Címsor 2
 - A hírblokkon belül alkalmazandó grid töréspontja MD méretnél legyen, aránya: 8:4-hez (szöveg <> kép). MD méret alatt egymás alatt helyezkedjen el.
 - A dátumot bekezdésben helyezd el. Dátum formátuma: ÉV - PONT - SZÓKÖZ - HÓNAP - PONT - SZÓKÖZ - NAP - PONT, lásd a mintán.
 - Szöveges tartalmat bekezdésben helyezd el.
 - Kép tartalomnál az alt legyen a fájlnév.

/* VENDÉGKÖNYV */
Alakítsd ki a Vendégkönyv oldalt a "vendegkonyv" táblát felhasználva. A vendégkönyv bejegyzések időrendben inverzen legyenek, mindig a legújabb bejyegzés elöl.
A form és a bejegyzések közt alkalmazz vonalat elválasztásként.
Vendégkönyv Form:
 - Név:  -- text input mező
 - E-mail: -- e-mail input mező
 - Üzenet: -- textarea, 6 soros
 - Beküld: -- submit gomb
 - Kiemelés (*-ozott részhez és validálási szöveghez): piros betűszín és félkövér. Mezők alatt bekezdésben legyen elhelyezve.
Vendégkönyv validálás:
 - Üres mező nem lehet a form beküldése előtt:
	"NEM ADOTT MEG NEVET"
	"NEM ADOTT MEG E-MAIL CÍMET"
	"NEM ADOTT MEG ÜZENETET"
 - Az e-mail mező valid e-mail címet tartalmazhat:
	"NEM HELYES E-MAIL FORMÁTUM"
 - Error message elhelyezés --> Minden mező alatt vagy Alert-boxban
 - Sikeres validálás után a vendegkonyv töltődjön be.
Vendégkönyv hozzászólások:
 - Név kőtőjel e-mail cím címsor 5-ben helyezkedjen el.
 - E-mail cím linkje az Outlook-ot nyissa meg.
 - A dátumot bekezdésben helyezd el. Dátum formátuma: ÉV - PONT - SZÓKÖZ - HÓNAP - PONT - SZÓKÖZ - NAP - PONT, lásd a mintán.
 - A hozzászólás szöveges tartalmát bekezdésben helyezd el.

/* + Autentikációs feladat */
S fenti vendégkönyvhöz teljes autentikációt készítsen, csak autentikált felhasználó tudjon beleírni.
Szükséges elemek:
 - Regisztráció
 - Belépés
 - Profil
 - Kilépés
 - Jelszóváltoztatás
















