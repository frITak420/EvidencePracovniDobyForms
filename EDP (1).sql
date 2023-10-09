CREATE TABLE `Zakaznici` (
  `Id` integer PRIMARY KEY AUTO_INCREMENT,
  `Nazev` varchar(255),
  `Ulice` varchar(255),
  `Mesto` varchar(255),
  `PSC` varchar(6),
  `IC` varchar(8),
  `DIC` varchar(10)
);

CREATE TABLE `Projekty` (
  `Id` integer PRIMARY KEY AUTO_INCREMENT,
  `Nazev` varchar(255),
  `HodinovaSazba` decimal(19,4),
  `IdZakaznik` integer,
  `IdUzivatel` integer
);

CREATE TABLE `Cinnosti` (
  `Id` integer PRIMARY KEY,
  `PopisCinnosti` varchar(255),
  `Zacatek` datetime,
  `Konec` datetime,
  `IdProjekt` integer,
  `IdUzivatel` int
);

CREATE TABLE `Uzivatele` (
  `Id` integer PRIMARY KEY AUTO_INCREMENT,
  `Nazev` varchar(255),
  `Prijemni` varchar(255),
  `PrihlasovaciJmeno` varchar(255),
  `Heslo` varchar(255)
);

ALTER TABLE `Cinnosti` ADD FOREIGN KEY (`IdProjekt`) REFERENCES `Projekty` (`Id`);

ALTER TABLE `Projekty` ADD FOREIGN KEY (`IdZakaznik`) REFERENCES `Zakaznici` (`Id`);

ALTER TABLE `Cinnosti` ADD FOREIGN KEY (`IdUzivatel`) REFERENCES `Uzivatele` (`Id`);
