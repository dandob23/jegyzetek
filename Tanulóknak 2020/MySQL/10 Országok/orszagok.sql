-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2017. Ápr 18. 15:15
-- Kiszolgáló verziója: 5.7.14
-- PHP verzió: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `orszagok2`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `adatok`
--

CREATE TABLE `adatok` (
  `allam` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `forma` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `terulet` int(11) NOT NULL,
  `nepesseg` int(11) NOT NULL,
  `foldresz` varchar(20) COLLATE utf8mb4_hungarian_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `adatok`
--

INSERT INTO `adatok` (`allam`, `forma`, `terulet`, `nepesseg`, `foldresz`) VALUES
('Kongói Demokratikus Köztársaság', 'köztársaság', 2344885, 36672, 'Afrika'),
('Zöld-foki Köztársaság', 'köztársaság', 4033, 369, 'Afrika'),
('Zimbabwe', 'köztársaság', 390759, 10402, 'Afrika'),
('Zambia', 'köztársaság', 752614, 8023, 'Afrika'),
('Venezuela', 'szövetségi köztársaság', 912050, 20249, 'Dél-Amerika'),
('Uruguay', 'köztársaság', 176215, 3131, 'Dél-Amerika'),
('Uganda', 'köztársaság', 241139, 17804, 'Afrika'),
('Tunézia', 'köztársaság', 163610, 8222, 'Afrika'),
('Trinidad és Tobago', 'köztársaság', 5128, 1263, 'Afrika'),
('Togo', 'köztársaság', 56785, 3349, 'Afrika'),
('Tanzánia', 'szövetségi köztársaság', 945087, 25635, 'Afrika'),
('Szváziföld', 'monarchia', 17363, 768, 'Afrika'),
('Szudán', 'köztársaság', 2505813, 24485, 'Afrika'),
('Szomália', 'köztársaság', 637657, 7339, 'Afrika'),
('Szenegál', 'köztársaság', 196722, 7172, 'Afrika'),
('Suriname', 'köztársaság', 163265, 404, 'Dél-Amerika'),
('Sierra Leone', 'köztársaság', 71740, 4376, 'Afrika'),
('Seychelle-szigetek', 'köztársaság', 454, 67, 'Afrika'),
('Sao Tomé és Príncipe', 'köztársaság', 1001, 118, 'Afrika'),
('Salvador', 'köztársaság', 21041, 5207, 'Közép-Amerika'),
('Saint Vicent', 'alkotmányos monarchia', 389, 110, 'Közép-Amerika'),
('Saint Lucia', 'alkotmányos monarchia', 616, 148, 'Közép-Amerika'),
('Saint Kitts és Nevis', 'alkotmányos monarchia', 262, 50, 'Közép-Amerika'),
('Ruanda', 'köztársaság', 26339, 7165, 'Afrika'),
('Peru', 'köztársaság', 1285216, 22454, 'Dél-Amerika'),
('Paraguay', 'köztársaság', 406752, 4157, 'Dél-Amerika'),
('Panama', 'köztársaság', 75517, 2515, 'Közép-Amerika'),
('Nyugat-Szahara', '(jelenleg megszállás alatt)', 266, 174, 'Afrika'),
('Nigéria', 'szövetségi köztársaság', 923768, 88515, 'Afrika'),
('Niger', 'köztársaság', 1267000, 7252, 'Afrika'),
('Nicaragua', 'köztársaság', 120254, 4130, 'Közép-Amerika'),
('Namíbia', 'köztársaság', 824292, 1402, 'Afrika'),
('Mozambik', 'köztársaság', 799380, 16593, 'Afrika'),
('Mexikó', 'szövetségi köztársaság', 1958201, 89538, 'Közép-Amerika'),
('Mauritius', 'köztársaság', 2040, 1084, 'Afrika'),
('Mauritánia', 'köztársaság', 1030700, 2036, 'Afrika'),
('Marokkó', 'örökletes monarchia', 446550, 24522, 'Afrika'),
('Mali', 'köztársaság', 1240192, 8156, 'Afrika'),
('Malawi', 'köztársaság', 118484, 8823, 'Afrika'),
('Madagaszkár', 'köztársaság', 587041, 11493, 'Afrika'),
('Líbia', 'köztársaság', 1775500, 4385, 'Afrika'),
('Libéria', 'köztársaság', 97754, 2580, 'Afrika'),
('Lesotho', 'alkotmányos monarchia', 30355, 1700, 'Afrika'),
('Kuba', 'köztársaság', 110860, 10822, 'Közép-Amerika'),
('Közép-Afrikai Köztársaság', 'köztársaság', 622984, 2895, 'Afrika'),
('Kongó', 'köztársaság', 342000, 1941, 'Afrika'),
('Kolumbia', 'köztársaság', 1141748, 33951, 'Dél-Amerika'),
('Kenya', 'köztársaság', 580367, 25700, 'Afrika'),
('Kanada', 'szövetségi állam', 9958319, 27409, 'Észak-Amerika'),
('Kamerun', 'köztársaság', 475445, 11540, 'Afrika'),
('Jamaica', 'alkotmányos monarchia', 10991, 2375, 'Közép-Amerika'),
('Honduras', 'köztársaság', 112088, 5105, 'Közép-Amerika'),
('Haiti', 'köztársaság', 27750, 6764, 'Közép-Amerika'),
('Guyana', 'köztársaság', 24969, 1024, 'Dél-Amerika'),
('Guinea', 'köztársaság', 245857, 6706, 'Afrika'),
('Guatemala', 'köztársaság', 108889, 10030, 'Közép-Amerika'),
('Grenada', 'alkotmányos monarchia', 344, 110, 'Közép-Amerika'),
('Ghána', 'köztársaság', 238537, 15400, 'Afrika'),
('Gambia', 'köztársaság', 11295, 878, 'Afrika'),
('Gabon', 'köztársaság', 267667, 1206, 'Afrika'),
('Etiópia', 'köztársaság', 1130138, 50000, 'Afrika'),
('Eritrea', 'köztársaság', 121144, 3325, 'Afrika'),
('Elefántcsontpart', 'köztársaság', 322462, 12098, 'Afrika'),
('Egyiptom', 'köztársaság', 997739, 55163, 'Afrika'),
('Egyenlítői- Guinea', 'köztársaság', 28051, 341, 'Afrika'),
('Ecuador', 'köztársaság', 272045, 10741, 'Dél-Amerika'),
('Dzsibuti', 'köztársaság', 23200, 520, 'Afrika'),
('Dominikai Köztársaság', 'köztársaság', 48422, 7313, 'Közép-Amerika'),
('Dominikai Közösség', 'köztársaság', 750, 81, 'Közép-Amerika'),
('Dél-Afrikai Köztársaság', 'szövetségi köztársaság', 1221037, 34492, 'Afrika'),
('Csád', 'köztársaság', 1284000, 5961, 'Afrika'),
('Costa Rica', 'köztársaság', 51100, 3064, 'Közép-Amerika'),
('Comore Szigetek', 'köztársaság', 1862, 503, 'Afrika'),
('Chile', 'köztársaság', 756626, 13813, 'Dél-Amerika'),
('Burundi', 'köztársaság', 27834, 5786, 'Afrika'),
('Burkina Faso', 'köztársaság', 274200, 9490, 'Afrika'),
('Brazília', 'szövetségi köztársaság', 8511966, 159224, 'Dél-Amerika'),
('Botswana', 'köztársaság', 582000, 1373, 'Afrika'),
('Bolívia', 'köztársaság', 1098581, 7832, 'Dél-Amerika'),
('Bissau-Guinea', 'köztársaság', 36125, 966, 'Afrika'),
('Benin', 'népi köztársaság', 112622, 4889, 'Afrika'),
('Barbados', 'alkotmányos monarchia', 430, 257, 'Közép-Amerika'),
('Bahama-szigetek', 'alkotmányos monarchia', 13939, 255, 'Közép-Amerika'),
('Argentína', 'szövetségi köztársaság', 2766889, 32609, 'Dél-Amerika'),
('Antigua és Barbuda', 'alkotmányos monarchia', 442, 86, 'Közép-Amerika'),
('Angola', 'köztársaság', 1246700, 10020, 'Afrika'),
('Amerikai Egyesült Államok', 'szövetségi köztársaság', 9809155, 257900, 'Észak-Amerika'),
('Algéria', 'népi demokratikus köztársaság', 2381741, 26600, 'Afrika');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `adatok`
--
ALTER TABLE `adatok`
  ADD PRIMARY KEY (`allam`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
