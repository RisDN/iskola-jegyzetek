-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Máj 01. 16:25
-- Kiszolgáló verziója: 10.4.28-MariaDB
-- PHP verzió: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `allatkert`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `allatok`
--

CREATE TABLE `allatok` (
  `allat_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `latin_nev` text NOT NULL,
  `kategoria` char(1) NOT NULL,
  `elofordulas` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `allatok`
--

INSERT INTO `allatok` (`allat_id`, `nev`, `latin_nev`, `kategoria`, `elofordulas`) VALUES
(1, 'Szurikáta', 'Suricata suricatta', 'e', 'Dél-Afrika'),
(2, 'Alpaka', 'Vicugna pacos', 'e', 'Dél-Amerika'),
(3, 'Kéksárga ara', 'Ara ararauna', 'm', 'Dél-Amerika'),
(4, 'Rózsás flamingó', 'Phoenicopterus roseus', 'm', 'Dél-Európa, Afrika, Közép-Amerika, Dél-Ázsia'),
(5, 'Szélesszájú orrszarvú', 'Ceratotherium simum', 'e', 'Dél- és Kelet-Afrika'),
(6, 'Smaragdzöld piton', 'Morelia viridis', 'h', 'Délkelet-Ázsia és Ausztrália'),
(7, 'Alföldi zebra', 'Equus quagga', 'e', 'Közép- és Dél-Afrika'),
(8, 'Afrikai elefánt', 'Loxodonta africana', 'e', 'Közép- és Dél-Afrika'),
(9, 'Ausztrál királypapagáj', 'Alisterus scapularis', 'm', 'Kelet-Ausztrália'),
(10, 'Karmazsin rozella', 'Platycercus elegans', 'm', 'Kelet-Ausztrália'),
(11, 'Szalagos tigrispiton', 'Python bivittatus', 'h', 'Dél- és Délkelet-Ázsia'),
(12, 'Mosómedve', 'Procyon lotor', 'e', 'Észak-, Közép- és Dél-Amerika'),
(13, 'Oroszlán', 'Panthera leo', 'e', 'Afrika, India'),
(14, 'Óriástukán', 'Ramphastos toco', 'm', 'Dél-Amerika'),
(15, 'Kerecsensólyom', 'Falco cherrug', 'm', 'Európa és Ázsia'),
(16, 'Emu', 'Dromaius novaehollandiae', 'm', 'Ausztrália'),
(17, 'Királypingvin', 'Aptenodytes patagonicus', 'm', 'Antarktisz'),
(18, 'Uhu', 'Bubo bubo', 'm', 'Európa, Ázsia'),
(19, 'Barnamedve', 'Ursus arctos', 'e', 'Európa, Ázsia és Észak-Amerika'),
(20, 'Gabonasikló', 'Elaphe guttata', 'h', 'Észak-Amerika');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `hirlevel`
--

CREATE TABLE `hirlevel` (
  `hirlevel_id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `jegyek`
--

CREATE TABLE `jegyek` (
  `jegy_id` int(11) NOT NULL,
  `megnevezes` text NOT NULL,
  `jegytipus` char(1) NOT NULL,
  `reszletek` text NOT NULL,
  `ar` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `jegyek`
--

INSERT INTO `jegyek` (`jegy_id`, `megnevezes`, `jegytipus`, `reszletek`, `ar`) VALUES
(1, 'Felnőtt', '1', '', 3000),
(2, 'Diák', '1', 'Érvényes diákigazolvány felmutatásával', 2500),
(3, 'Nyugdíjas', '1', 'Nyugdíjas igazolvány felmutatásával', 2300),
(4, 'Gyermek', '1', '3-14 éves korig', 1500),
(5, 'Kisgyermek', '1', '3 éves kor alatt', 150),
(6, 'Családi jegy 2+1', '2', 'Két felnőt és egy gyermek részére', 6500),
(7, 'Családi jegy 2+2', '2', 'Két felnőt és két gyermek részére', 7500),
(8, 'Nagycsaládos jegy', '2', 'Két felnőt és három vagy több gyermek részére', 9000),
(9, 'Regisztrációs belépő', '1', 'Igazoltan fogyatékkal élők számára igénybe vehető. Az alábbi igazolványokat fogadjuk el: Magyar Vakok és Gyengénlátók Országos Szövetsége, Siketek és Nagyothallók Országos Szövetsége, Mozgáskorlátozottak Egyesületeinek Országos Szövetsége, Értelmi Fogyatékossággal Élők és Segítők Országos Éredekvédelmi Szövetsége, Autisták Országos Szövetsége', 600),
(10, 'Kisérő jegy', '1', 'Fogyatékkal élő személy kisérőjeként, max. 1 fő', 300),
(11, 'Pedagógus jegy', '1', 'Érvényes pedagógus igazolvánnyal', 1500),
(12, 'Csoportos felnőtt jegy', '3', 'Minimum 10 fős csoport esetén', 2400),
(13, 'Csoportos diákjegy', '3', 'Minimum 10 fő esetén, érvényes diákigazolvány felmutatásával', 2000),
(14, 'Csoportos nyugdíjas jegy', '3', 'Minimum 10 fő esetén, nyugdíjas igazolvány felmutatásával', 1800),
(15, 'Csoportos gyerekjegy', '3', 'Minimum 10 fő esetén, 3-14 éves korig', 1200);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `allatok`
--
ALTER TABLE `allatok`
  ADD PRIMARY KEY (`allat_id`);

--
-- A tábla indexei `hirlevel`
--
ALTER TABLE `hirlevel`
  ADD PRIMARY KEY (`hirlevel_id`);

--
-- A tábla indexei `jegyek`
--
ALTER TABLE `jegyek`
  ADD PRIMARY KEY (`jegy_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `allatok`
--
ALTER TABLE `allatok`
  MODIFY `allat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT a táblához `hirlevel`
--
ALTER TABLE `hirlevel`
  MODIFY `hirlevel_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `jegyek`
--
ALTER TABLE `jegyek`
  MODIFY `jegy_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
