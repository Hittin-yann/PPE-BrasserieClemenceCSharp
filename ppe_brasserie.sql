-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le :  Dim 18 oct. 2020 à 11:43
-- Version du serveur :  10.4.10-MariaDB
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `ppe_brasserie`
--

-- --------------------------------------------------------

--
-- Structure de la table `bio`
--

DROP TABLE IF EXISTS `bio`;
CREATE TABLE IF NOT EXISTS `bio` (
  `idIngredient` int(11) NOT NULL,
  `fournisseurIngredient` varchar(500) NOT NULL,
  `nomIngredient` varchar(500) NOT NULL,
  `numeroBio` int(11) DEFAULT NULL,
  PRIMARY KEY (`idIngredient`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `bio`
--

INSERT INTO `bio` (`idIngredient`, `fournisseurIngredient`, `nomIngredient`, `numeroBio`) VALUES
(1267, 'Yann', 'olive', 0),
(1272, 'yann', 'jambon', 0),
(1276, 'Dilan', 'menthe', 0);

-- --------------------------------------------------------

--
-- Structure de la table `composition`
--

DROP TABLE IF EXISTS `composition`;
CREATE TABLE IF NOT EXISTS `composition` (
  `idIngredient` int(11) NOT NULL,
  `idRecette` int(11) NOT NULL,
  `quantite` double NOT NULL,
  PRIMARY KEY (`idIngredient`,`idRecette`),
  KEY `composition_recette0_FK` (`idRecette`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `composition`
--

INSERT INTO `composition` (`idIngredient`, `idRecette`, `quantite`) VALUES
(1, 6, 3),
(2, 6, 4),
(1267, 5, 4),
(1271, 8, 5),
(1272, 8, 2),
(1276, 5, 6);

-- --------------------------------------------------------

--
-- Structure de la table `compte`
--

DROP TABLE IF EXISTS `compte`;
CREATE TABLE IF NOT EXISTS `compte` (
  `idCompte` int(11) NOT NULL AUTO_INCREMENT,
  `nomCompte` varchar(500) NOT NULL,
  `prenomCompte` varchar(500) NOT NULL,
  `utilisateurCompte` varchar(500) NOT NULL,
  `pwdCompte` varchar(500) NOT NULL,
  PRIMARY KEY (`idCompte`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `compte`
--

INSERT INTO `compte` (`idCompte`, `nomCompte`, `prenomCompte`, `utilisateurCompte`, `pwdCompte`) VALUES
(1, 'test', 'test', 'test', 'test'),
(2, 'Hittin', 'Yann', 'yhittin', '0550002D'),
(3, 'Quinet', 'Yanis', 'yquinet', '0550002D');

-- --------------------------------------------------------

--
-- Structure de la table `ingredient`
--

DROP TABLE IF EXISTS `ingredient`;
CREATE TABLE IF NOT EXISTS `ingredient` (
  `idIngredient` int(11) NOT NULL AUTO_INCREMENT,
  `fournisseurIngredient` varchar(500) NOT NULL,
  `nomIngredient` varchar(500) NOT NULL,
  PRIMARY KEY (`idIngredient`)
) ENGINE=InnoDB AUTO_INCREMENT=1277 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `ingredient`
--

INSERT INTO `ingredient` (`idIngredient`, `fournisseurIngredient`, `nomIngredient`) VALUES
(1, 'Marcel', 'piment'),
(2, 'Yanis', 'tomate'),
(1267, 'Yann', 'olive'),
(1271, 'Lilian', 'pomme'),
(1272, 'yann', 'jambon'),
(1276, 'Dilan', 'menthe');

-- --------------------------------------------------------

--
-- Structure de la table `recette`
--

DROP TABLE IF EXISTS `recette`;
CREATE TABLE IF NOT EXISTS `recette` (
  `idRecette` int(11) NOT NULL AUTO_INCREMENT,
  `nomRecette` varchar(50) NOT NULL,
  `dateCreation` varchar(50) NOT NULL,
  PRIMARY KEY (`idRecette`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `recette`
--

INSERT INTO `recette` (`idRecette`, `nomRecette`, `dateCreation`) VALUES
(5, 'bière olive/menthe', '09/09/2001'),
(6, 'bière pimenter', '15/09/2015'),
(8, 'bière de Yannou', '17/10/2020');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `bio`
--
ALTER TABLE `bio`
  ADD CONSTRAINT `bio_ingredient_FK` FOREIGN KEY (`idIngredient`) REFERENCES `ingredient` (`idIngredient`);

--
-- Contraintes pour la table `composition`
--
ALTER TABLE `composition`
  ADD CONSTRAINT `composition_ingredient_FK` FOREIGN KEY (`idIngredient`) REFERENCES `ingredient` (`idIngredient`),
  ADD CONSTRAINT `composition_recette0_FK` FOREIGN KEY (`idRecette`) REFERENCES `recette` (`idRecette`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
