-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Dec 03. 21:35
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `post-gyakorlo`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `autok`
--

CREATE TABLE `autok` (
  `id` int(11) NOT NULL,
  `rendszam` text NOT NULL,
  `marka` text NOT NULL,
  `tipus` text NOT NULL,
  `evjarat` year(4) NOT NULL,
  `szin` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `autok`
--

INSERT INTO `autok` (`id`, `rendszam`, `marka`, `tipus`, `evjarat`, `szin`) VALUES
(1, 'aa bb-123', 'Ford', 'Focus', '1988', 'szürke'),
(2, 'DFG-888', 'Suzuki', 'Swift', '1996', 'fehér'),
(3, 'SSD-123', 'Suzuki', 'Swift', '2022', 'piros');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `klippek`
--

CREATE TABLE `klippek` (
  `id` int(11) NOT NULL,
  `eloado` text NOT NULL,
  `cim` text NOT NULL,
  `hossz` time NOT NULL,
  `youtube` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `klippek`
--

INSERT INTO `klippek` (`id`, `eloado`, `cim`, `hossz`, `youtube`) VALUES
(1, 'Thalia', 'Regresa A Mi', '00:04:00', 'https://youtu.be/mzphfi3DkXo?si=oKkNaIj4jJSYLMkw'),
(2, 'Faithless', 'Insomnia', '00:03:34', 'https://youtu.be/P8JEm4d6Wu4?si=iH62hfGI4vVVqn6g'),
(3, 'Madonna', 'Frozen', '00:05:29', 'https://youtu.be/XS088Opj9o0?si=WJ4sC4hjHNcUjYwa');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szallitas`
--

CREATE TABLE `szallitas` (
  `id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `irsz` int(11) NOT NULL,
  `varos` text NOT NULL,
  `utca` text NOT NULL,
  `hazszam` text NOT NULL,
  `emelet` text NOT NULL,
  `ajto` text NOT NULL,
  `tel` text NOT NULL,
  `erintesmentes` enum('i','n') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `szallitas`
--

INSERT INTO `szallitas` (`id`, `nev`, `irsz`, `varos`, `utca`, `hazszam`, `emelet`, `ajto`, `tel`, `erintesmentes`) VALUES
(1, 'BMSZC Verebély László Technikum', 1139, 'Budapest', 'Üteg utca', '13-15', '', '', '+36705022297', 'n'),
(2, 'Kiss Béla', 1067, 'Budapest', 'Ó utca', '12', '3', '1A', '+36201234567', 'i'),
(3, 'Nagy Laura', 1139, 'Budapest', 'Béke utca', '56', 'fsz', '3B', '+36301234567', 'i');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `szinesz`
--

CREATE TABLE `szinesz` (
  `id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `szuletes` date NOT NULL,
  `nemzet` text NOT NULL,
  `oscar_dij` enum('i','n') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `szinesz`
--

INSERT INTO `szinesz` (`id`, `nev`, `szuletes`, `nemzet`, `oscar_dij`) VALUES
(1, 'Brad Pitt', '1960-12-18', 'USA', 'i'),
(2, 'Jason Statham', '1967-07-26', 'Nagy-Britannia', 'n'),
(3, 'Leonardo DiCaprio', '1974-11-11', 'USA', 'i');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `tanulok`
--

CREATE TABLE `tanulok` (
  `id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `kor` int(11) NOT NULL,
  `lakhely` text NOT NULL,
  `nem` enum('f','n') NOT NULL,
  `agazat` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `tanulok`
--

INSERT INTO `tanulok` (`id`, `nev`, `kor`, `lakhely`, `nem`, `agazat`) VALUES
(1, 'Kiss Béla', 15, 'Dunakeszi', 'f', 'Informatika és távközlés'),
(2, 'Nagy Blanka', 17, 'Budapest', 'n', 'Rendészet és közszolgálat'),
(3, 'Lakatos László', 14, 'Fót', 'f', 'Elektronika és elektrotechnika');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `autok`
--
ALTER TABLE `autok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `klippek`
--
ALTER TABLE `klippek`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `szallitas`
--
ALTER TABLE `szallitas`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `szinesz`
--
ALTER TABLE `szinesz`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `tanulok`
--
ALTER TABLE `tanulok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `autok`
--
ALTER TABLE `autok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `klippek`
--
ALTER TABLE `klippek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `szallitas`
--
ALTER TABLE `szallitas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `szinesz`
--
ALTER TABLE `szinesz`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `tanulok`
--
ALTER TABLE `tanulok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
