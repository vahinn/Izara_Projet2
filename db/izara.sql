-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : mer. 17 mars 2021 à 12:27
-- Version du serveur :  10.4.17-MariaDB
-- Version de PHP : 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `izara`
--

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

CREATE TABLE `cours` (
  `REF_COURS` varchar(6) NOT NULL,
  `debut` datetime DEFAULT current_timestamp(),
  `fin` datetime DEFAULT current_timestamp(),
  `prof` int(11) DEFAULT NULL,
  `apprenant` int(11) DEFAULT NULL,
  `eleve` int(11) DEFAULT NULL,
  `reference_facture` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `facture`
--

CREATE TABLE `facture` (
  `REF_FACTURE` int(11) NOT NULL,
  `montant_facture` float DEFAULT NULL,
  `date_fact` datetime DEFAULT current_timestamp(),
  `isPaid` tinyint(1) DEFAULT NULL,
  `proprio` int(11) DEFAULT NULL,
  `paiement_reference` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `group`
--

CREATE TABLE `group` (
  `REF` int(11) NOT NULL,
  `nom_groupe` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `group`
--

INSERT INTO `group` (`REF`, `nom_groupe`) VALUES
(1, 'Parent'),
(2, 'Professeur'),
(3, 'Administrateur');

-- --------------------------------------------------------

--
-- Structure de la table `historiquepaiement`
--

CREATE TABLE `historiquepaiement` (
  `REF_HISTORY` int(11) NOT NULL,
  `heures_totale` float DEFAULT NULL,
  `montant` float DEFAULT NULL,
  `date_paiement` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `messages`
--

CREATE TABLE `messages` (
  `REF_MESSAGE` int(11) NOT NULL,
  `texte` text DEFAULT NULL,
  `sender` int(11) DEFAULT NULL,
  `receiver` int(11) DEFAULT NULL,
  `date_envoi` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `parrainage`
--

CREATE TABLE `parrainage` (
  `CODE_PARRAINAGE` varchar(15) NOT NULL,
  `texte` text DEFAULT NULL,
  `parent` int(11) DEFAULT NULL,
  `mail_prof` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `right`
--

CREATE TABLE `right` (
  `KEY` varchar(10) NOT NULL,
  `libelle` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `right_group`
--

CREATE TABLE `right_group` (
  `REF_GROUP` int(11) NOT NULL,
  `KEY_RIGHT` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `student`
--

CREATE TABLE `student` (
  `ID_STUDENT` int(11) NOT NULL,
  `nom` varchar(20) DEFAULT NULL,
  `classe` varchar(4) DEFAULT NULL,
  `parent` int(11) DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `users`
--

CREATE TABLE `users` (
  `ID` int(11) NOT NULL,
  `nom` varchar(25) DEFAULT NULL,
  `prenom` varchar(25) DEFAULT NULL,
  `mail` varchar(50) DEFAULT NULL,
  `password` varchar(250) DEFAULT NULL,
  `isActive` tinyint(1) DEFAULT NULL,
  `isValidate` tinyint(1) DEFAULT NULL,
  `validationDate` datetime DEFAULT current_timestamp(),
  `rate` float DEFAULT NULL,
  `niveau` varchar(15) DEFAULT NULL,
  `pdp` varchar(100) DEFAULT NULL,
  `tarifHoraire` float DEFAULT NULL,
  `reference_groupe` int(11) DEFAULT NULL,
  `code_parrainage` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `users`
--

INSERT INTO `users` (`ID`, `nom`, `prenom`, `mail`, `password`, `isActive`, `isValidate`, `validationDate`, `rate`, `niveau`, `pdp`, `tarifHoraire`, `reference_groupe`, `code_parrainage`) VALUES
(19, 'Ranary', 'test_Parent', 'test@parent.com', '317210366222432259211830225165226852401031495435200179136180691581924912021520070244', 0, 0, '2021-03-16 16:59:58', 0, '', NULL, 12, 2, NULL),
(20, 'Ranary', 'Test', 'test@mail.com', '1591342081291367612510115447234160197902082116319179274311130442099310821176240108', 1, 0, '2021-03-17 11:07:19', 0, '', NULL, 0, 1, NULL),
(21, 'jvhbjn', 'gjvhbjkn', 'gjhjbn', '317210366222432259211830225165226852401031495435200179136180691581924912021520070244', 1, 0, '2021-03-17 11:19:48', 0, '', NULL, 0, 1, NULL),
(22, '(--(', 'h(-', 'uuh', '1542419151110106150251461335522348178230162551011052522492152311152362062221019610141160', 1, 0, '0001-01-01 00:00:00', 0, 'uy', NULL, 0, 2, NULL);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `cours`
--
ALTER TABLE `cours`
  ADD PRIMARY KEY (`REF_COURS`),
  ADD KEY `FK_Cours_User_Prof` (`prof`),
  ADD KEY `FK_Cours_User_Apprenant` (`apprenant`),
  ADD KEY `FK_Cours_Student` (`eleve`),
  ADD KEY `FK_Cours_Facture` (`reference_facture`);

--
-- Index pour la table `facture`
--
ALTER TABLE `facture`
  ADD PRIMARY KEY (`REF_FACTURE`),
  ADD KEY `FK_Facture_User` (`proprio`),
  ADD KEY `FK_Facture_HistoriquePaiement` (`paiement_reference`);

--
-- Index pour la table `group`
--
ALTER TABLE `group`
  ADD PRIMARY KEY (`REF`);

--
-- Index pour la table `historiquepaiement`
--
ALTER TABLE `historiquepaiement`
  ADD PRIMARY KEY (`REF_HISTORY`);

--
-- Index pour la table `messages`
--
ALTER TABLE `messages`
  ADD PRIMARY KEY (`REF_MESSAGE`),
  ADD KEY `FK_Messages_User_Sender` (`sender`),
  ADD KEY `FK_Messages_User_Receiver` (`receiver`);

--
-- Index pour la table `parrainage`
--
ALTER TABLE `parrainage`
  ADD PRIMARY KEY (`CODE_PARRAINAGE`);

--
-- Index pour la table `right`
--
ALTER TABLE `right`
  ADD PRIMARY KEY (`KEY`);

--
-- Index pour la table `right_group`
--
ALTER TABLE `right_group`
  ADD PRIMARY KEY (`REF_GROUP`,`KEY_RIGHT`),
  ADD KEY `FK_Right_group_Right` (`KEY_RIGHT`);

--
-- Index pour la table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`ID_STUDENT`),
  ADD KEY `FK_Student_User` (`parent`);

--
-- Index pour la table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `FK_Users_Group` (`reference_groupe`),
  ADD KEY `FK_Users_Parrainage` (`code_parrainage`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `facture`
--
ALTER TABLE `facture`
  MODIFY `REF_FACTURE` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `group`
--
ALTER TABLE `group`
  MODIFY `REF` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT pour la table `historiquepaiement`
--
ALTER TABLE `historiquepaiement`
  MODIFY `REF_HISTORY` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `messages`
--
ALTER TABLE `messages`
  MODIFY `REF_MESSAGE` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `student`
--
ALTER TABLE `student`
  MODIFY `ID_STUDENT` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `cours`
--
ALTER TABLE `cours`
  ADD CONSTRAINT `FK_Cours_Facture` FOREIGN KEY (`reference_facture`) REFERENCES `facture` (`REF_FACTURE`),
  ADD CONSTRAINT `FK_Cours_Student` FOREIGN KEY (`eleve`) REFERENCES `student` (`ID_STUDENT`),
  ADD CONSTRAINT `FK_Cours_User_Apprenant` FOREIGN KEY (`apprenant`) REFERENCES `users` (`ID`),
  ADD CONSTRAINT `FK_Cours_User_Prof` FOREIGN KEY (`prof`) REFERENCES `users` (`ID`);

--
-- Contraintes pour la table `facture`
--
ALTER TABLE `facture`
  ADD CONSTRAINT `FK_Facture_HistoriquePaiement` FOREIGN KEY (`paiement_reference`) REFERENCES `historiquepaiement` (`REF_HISTORY`),
  ADD CONSTRAINT `FK_Facture_User` FOREIGN KEY (`proprio`) REFERENCES `users` (`ID`);

--
-- Contraintes pour la table `messages`
--
ALTER TABLE `messages`
  ADD CONSTRAINT `FK_Messages_User_Receiver` FOREIGN KEY (`receiver`) REFERENCES `users` (`ID`),
  ADD CONSTRAINT `FK_Messages_User_Sender` FOREIGN KEY (`sender`) REFERENCES `users` (`ID`);

--
-- Contraintes pour la table `right_group`
--
ALTER TABLE `right_group`
  ADD CONSTRAINT `FK_Right_group_Group` FOREIGN KEY (`REF_GROUP`) REFERENCES `group` (`REF`),
  ADD CONSTRAINT `FK_Right_group_Right` FOREIGN KEY (`KEY_RIGHT`) REFERENCES `right` (`KEY`);

--
-- Contraintes pour la table `student`
--
ALTER TABLE `student`
  ADD CONSTRAINT `FK_Student_User` FOREIGN KEY (`parent`) REFERENCES `users` (`ID`) ON DELETE CASCADE;

--
-- Contraintes pour la table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `FK_Users_Group` FOREIGN KEY (`reference_groupe`) REFERENCES `group` (`REF`),
  ADD CONSTRAINT `FK_Users_Parrainage` FOREIGN KEY (`code_parrainage`) REFERENCES `parrainage` (`CODE_PARRAINAGE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
