-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Jan 06. 01:53
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
-- Adatbázis: `szaloncukor`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termekek`
--

CREATE TABLE `termekek` (
  `id` int(11) NOT NULL,
  `marka` text NOT NULL,
  `iz` text NOT NULL,
  `suly` int(11) NOT NULL,
  `ar` int(11) NOT NULL,
  `plusz18` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `termekek`
--

INSERT INTO `termekek` (`id`, `marka`, `iz`, `suly`, `ar`, `plusz18`) VALUES
(1, 'Tibi', 'Sajttorta', 330, 999, 0),
(2, 'Szamos', 'Csokoládékrémmel töltött marcipán', 250, 2799, 0),
(3, 'Sthümer', 'Tojáslikőr', 100, 999, 1),
(4, '', '', 100, 1000, 0),
(5, 'Bonbonetti', 'Vajkaramella', 120, 1100, 0),
(6, 'Bonbonetti', 'Tojáslikör,', 150, 2000, 1),
(7, 'Angyalkás', 'Zselés', 100, 1100, 0),
(8, 'Bonbonetti', 'Mákos', 100, 2000, 0),
(9, 'Bonbonetti', 'Mákos', 100, 2000, 0),
(10, 'Bonbonetti', 'Mákos', 1, 1, 0);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `termekek`
--
ALTER TABLE `termekek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `termekek`
--
ALTER TABLE `termekek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
