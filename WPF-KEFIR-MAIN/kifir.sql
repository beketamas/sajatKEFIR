-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Feb 04. 16:23
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
-- Adatbázis: `kifir`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `diakok`
--

CREATE TABLE `diakok` (
  `OM_Azonosito` varchar(11) NOT NULL,
  `Neve` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `SzuletesiDatum` varchar(255) DEFAULT NULL,
  `ErtesitesiCime` varchar(255) DEFAULT NULL,
  `Matematika` int(4) DEFAULT NULL,
  `Magyar` int(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `diakok`
--

INSERT INTO `diakok` (`OM_Azonosito`, `Neve`, `Email`, `SzuletesiDatum`, `ErtesitesiCime`, `Matematika`, `Magyar`) VALUES
('18345678901', 'Tóth Péter', 'peter.toth@example.com', '2001-2-10', 'Szeged, Rákóczi út 78.', 78, 82),
('29456789012', 'Varga Edit', 'edit.varga@example.com', '2000-11-3', 'Pécs, Szabadság tér 34.', 90, 75),
('30459776642', 'Kiss Kata', 'kata.kiss@example.com', '2002-4-25', 'Nyíregyháza, Bessenyei utca 456.', 89, 84),
('32401683481', 'Fekete András', 'andras.fekete@example.com', '2004-6-8', 'Eger, Dobó tér 789.', 87, 76),
('34567890123', 'Kiss András', 'andras.kiss@example.com', '2002-4-28', 'Miskolc, Ady utca 45.', 88, 91),
('37068217468', 'Horváth Gergő', 'gergo.horvath@example.com', '2002-7-18', 'Miskolc, Bajnai út 567.', 79, 82),
('37567410094', 'Varga Anna', 'anna.varga@example.com', '2004-1-30', 'Győr, Arany János utca 890.', 95, 91),
('45924560004', 'Tóth Zsuzsa', 'zsuzsa.toth@example.com', '2003-11-5', 'Pécs, Szent István utca 234.', 88, 75),
('52777694987', 'Nagy Bence', 'eszter.nagy@example.com', '2002-9-22', 'Debrecen, Petőfi tér 456.', 92, 89),
('60629090248', 'Balogh István', 'istvan.balogh@example.com', '2003-2-14', 'Kecskemét, Szabadság tér 1011.', 93, 88),
('60851528440', 'Szabó Gábor', 'gabor.szabo@example.com', '2004-3-10', 'Szeged, Dugonics tér 789.', -1, -1),
('65234567890', 'Nagy Eszter', 'eszter.nagy@example.com', '1999-8-22', 'Debrecen, Petőfi tér 56.', -1, -1),
('66632400831', 'Molnár Péter', 'peter.molnar@example.com', '2003-8-12', 'Szombathely, Kossuth tér 123.', 81, 73),
('72123456789', 'Kovács János', 'janos.kovacs@example.com', '2000-5-15', 'Budapest, Kossuth utca 123.', -1, -1),
('94345649754', 'Kovács Tamás', 'janos.kovacs@example.com', '2003-5-15', 'Budapest, Kossuth utca 123.', -1, -1);

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `diakok`
--
ALTER TABLE `diakok`
  ADD PRIMARY KEY (`OM_Azonosito`),
  ADD KEY `OM_Azonosito` (`OM_Azonosito`),
  ADD KEY `Neve` (`Neve`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
