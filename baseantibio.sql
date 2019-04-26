-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 26 Avril 2019 à 15:58
-- Version du serveur :  5.6.15-log
-- Version de PHP :  5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `baseantibio`
--

-- --------------------------------------------------------

--
-- Structure de la table `antibiotique`
--

CREATE TABLE IF NOT EXISTS `antibiotique` (
  `libelle` varchar(50) NOT NULL,
  `libelleG` varchar(50) NOT NULL,
  `doseKilo` decimal(5,2) DEFAULT NULL,
  `unite` varchar(50) NOT NULL,
  `nombreParJour` int(11) NOT NULL,
  `laCategorie` char(50) NOT NULL,
  UNIQUE KEY `libelle` (`libelle`),
  KEY `categorieLibelle` (`laCategorie`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Contenu de la table `antibiotique`
--

INSERT INTO `antibiotique` (`libelle`, `libelleG`, `doseKilo`, `unite`, `nombreParJour`, `laCategorie`) VALUES
('Amikacine', 'Amiklin', '15.00', 'mg', 1, 'Aminoglycosides'),
('Gentamicine', 'Geramycine', '6.00', 'mg/kg', 1, 'Aminoglycosides'),
('Netilmicine', 'Netromycine', '6.00', 'mg/kg', 1, 'Aminoglycosides'),
('Tobramycine', 'Obracine', '6.00', 'mg/kg', 1, 'Aminoglycosides'),
('Amphotéricine B', 'Fungizone', '0.70', 'mg/kg', 1, 'AntiFongiques'),
('Fluconazole', 'Diflucan', '300.00', 'mg', 1, 'AntiFongiques'),
('Itraconazole', 'Sporanox', '200.00', 'mg', 1, 'AntiFongiques'),
('Voriconazole', 'Vfen', '5.00', 'mg/kg', 2, 'AntiFongiques'),
('Aciclovir', 'Zovirax i.v', '7.00', 'mg/kg', 3, 'Antiviraux'),
('Aciclovir p.o', 'Zovirax', '200.00', 'mg/kg', 3, 'Antiviraux'),
('Valaciclorvir', 'Valtrex', '700.00', 'mg', 2, 'Antiviraux');

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

CREATE TABLE IF NOT EXISTS `categorie` (
  `libelle` char(50) CHARACTER SET latin1 NOT NULL,
  UNIQUE KEY `libelle` (`libelle`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Contenu de la table `categorie`
--

INSERT INTO `categorie` (`libelle`) VALUES
('Aminoglycosides'),
('AntiFongiques'),
('Antiviraux'),
('Carbapénèmes'),
('Céphalosporines'),
('Macrolides'),
('Pénicillines');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
