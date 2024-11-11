-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Nov 03. 21:59
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
-- Adatbázis: `jaras-nagykata`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `telepulesek`
--

CREATE TABLE `telepulesek` (
  `id` int(11) NOT NULL,
  `nev` text NOT NULL,
  `cimer` int(11) NOT NULL,
  `jogallas` text NOT NULL,
  `weboldal` text NOT NULL,
  `iranyitoszam` int(11) NOT NULL,
  `terulet` int(11) NOT NULL,
  `nepesseg` int(11) NOT NULL,
  `lakas` int(11) NOT NULL,
  `terkep` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `telepulesek`
--

INSERT INTO `telepulesek` (`id`, `nev`, `cimer`, `jogallas`, `weboldal`, `iranyitoszam`, `terulet`, `nepesseg`, `lakas`, `terkep`) VALUES
(1, 'Mende', 3692, 'község', 'www.mende.hu', 2235, 2715, 4127, 1509, 'maps.app.goo.gl/8NTBvrD5wVnVFjZL8'),
(2, 'Szentmártonkáta', 28653, 'nagyközség', 'szentmartonkata.asp.lgov.hu', 2254, 5218, 4883, 1999, 'maps.app.goo.gl/7YzqDtkaQBmTykgY8'),
(3, 'Tápióbicske', 15015, 'község', 'www.tapiobicske.hu', 2764, 4848, 3571, 1507, 'maps.app.goo.gl/ib88n46u9ssGiMoG8'),
(4, 'Tápiógyörgye', 17303, 'község', 'www.tapiogyorgye.hu', 2767, 5331, 3493, 1493, 'maps.app.goo.gl/KVhh7YqCtSmCAWd18'),
(5, 'Tápiószentmárton', 14571, 'nagyközség', 'www.tapioszentmarton.hu', 2711, 10291, 5721, 2517, 'maps.app.goo.gl/6UhZWUHGSgj9JceU7'),
(6, 'Nagykáta', 13435, 'város', 'www.nagykata.hu', 2760, 8161, 11985, 4943, 'maps.app.goo.gl/wF5XFbKbGBCTadS66'),
(7, 'Farmos', 9122, 'község', 'www.farmos.hu', 2765, 4012, 3453, 1563, 'maps.app.goo.gl/JFnmtovjwRYQz9ou6'),
(8, 'Tápiószecső', 31796, 'nagyközség', 'www.tapioszecso.hu', 2251, 3838, 6171, 2400, 'maps.app.goo.gl/Ee1PCTCKtjubyfew8'),
(9, 'Tápiószele', 14146, 'város', 'www.tapioszele.hu', 2766, 3699, 5928, 2365, 'maps.app.goo.gl/ndka8y43juVAcH9x6'),
(10, 'Sülysáp', 21713, 'város', 'www.sulysap.hu', 2241, 4719, 8501, 3146, 'maps.app.goo.gl/Ru8gx4w4cNatdEvw6'),
(11, 'Tápióság', 9405, 'község', 'www.tapiosag.hu', 2253, 3354, 2716, 1148, 'maps.app.goo.gl/BoxeF7m1W2726CNs9'),
(12, 'Úri', 28644, 'község', 'www.uri.hu', 2244, 2219, 2552, 986, 'maps.app.goo.gl/svaxWudoT38RnXXU6'),
(13, 'Szentlőrinckáta', 7542, 'község', 'www.szentlorinckata.hu', 2255, 2015, 1904, 834, 'maps.app.goo.gl/YdMrpDcMrQrEBCcC9'),
(14, 'Tóalmás', 21467, 'község', 'www.toalmas.hu', 2252, 3940, 3990, 1639, 'maps.app.goo.gl/tgw2f68opmkvybXb9'),
(15, 'Kóka', 31361, 'község', 'koka.asp.lgov.hu', 2243, 4436, 4419, 1841, 'maps.app.goo.gl/AqgZzhoLye9ZdB24A');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `telepulesek`
--
ALTER TABLE `telepulesek`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `telepulesek`
--
ALTER TABLE `telepulesek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
