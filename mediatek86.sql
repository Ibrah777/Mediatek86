-- Création de la base de données MediaTek86
CREATE DATABASE IF NOT EXISTS mediatek86 CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE mediatek86;

-- Création de l'utilisateur applicatif
CREATE USER IF NOT EXISTS 'userMediatek'@'localhost' IDENTIFIED BY 'mdpMediatek';
GRANT ALL PRIVILEGES ON mediatek86.* TO 'userMediatek'@'localhost';
FLUSH PRIVILEGES;

-- Table responsable (1 seule ligne)
CREATE TABLE IF NOT EXISTS responsable (
    login VARCHAR(64) NOT NULL,
    pwd   VARCHAR(64) NOT NULL
);

-- Table service
CREATE TABLE IF NOT EXISTS service (
    idservice  INT AUTO_INCREMENT PRIMARY KEY,
    nomservice VARCHAR(100) NOT NULL
);

-- Table motif
CREATE TABLE IF NOT EXISTS motif (
    idmotif INT AUTO_INCREMENT PRIMARY KEY,
    libelle VARCHAR(100) NOT NULL
);

-- Table personnel
CREATE TABLE IF NOT EXISTS personnel (
    idpersonnel INT AUTO_INCREMENT PRIMARY KEY,
    nom         VARCHAR(50)  NOT NULL,
    prenom      VARCHAR(50)  NOT NULL,
    tel         VARCHAR(20),
    mail        VARCHAR(100),
    idservice   INT NOT NULL,
    FOREIGN KEY (idservice) REFERENCES service(idservice)
);

-- Table absence
CREATE TABLE IF NOT EXISTS absence (
    idabsence   INT AUTO_INCREMENT PRIMARY KEY,
    datedebut   DATE NOT NULL,
    datefin     DATE NOT NULL,
    idmotif     INT NOT NULL,
    idpersonnel INT NOT NULL,
    FOREIGN KEY (idmotif)     REFERENCES motif(idmotif),
    FOREIGN KEY (idpersonnel) REFERENCES personnel(idpersonnel) ON DELETE CASCADE
);

-- Données de base
INSERT INTO responsable (login, pwd) VALUES ('admin', SHA2('Admin123', 256));

INSERT INTO service (nomservice) VALUES
    ('Administratif'),
    ('Médiation culturelle'),
    ('Prêt');

INSERT INTO motif (libelle) VALUES
    ('Congé parental'),
    ('Maladie'),
    ('Motif familial'),
    ('Vacances');

-- Personnel de test
INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES
    ('Dione',    'Ibrahima', '06 12 34 56 78', 'ibrahima@mediatek.fr', 1),
    ('Martin',   'Sophie',   '07 98 76 54 32', 'sophie@mediatek.fr',   2),
    ('Dupont',   'Kevin',    '06 55 44 33 22', 'kevin@mediatek.fr',    3),
    ('Leblanc',  'Julie',    '06 11 22 33 44', 'julie@mediatek.fr',    1),
    ('Moreau',   'Thomas',   '07 55 66 77 88', 'thomas@mediatek.fr',   2),
    ('Bernard',  'Claire',   '06 99 88 77 66', 'claire@mediatek.fr',   3),
    ('Petit',    'Lucas',    '07 44 33 22 11', 'lucas@mediatek.fr',    1),
    ('Robert',   'Emma',     '06 33 22 11 00', 'emma@mediatek.fr',     2),
    ('Richard',  'Noah',     '07 77 66 55 44', 'noah@mediatek.fr',     3),
    ('Simon',    'Léa',      '06 22 11 00 99', 'lea@mediatek.fr',      1);

-- Absences de test
INSERT INTO absence (datedebut, datefin, idmotif, idpersonnel) VALUES
    ('2025-01-06', '2025-01-17', 4, 1),
    ('2025-02-10', '2025-02-14', 2, 2),
    ('2025-03-03', '2025-03-07', 3, 3),
    ('2025-04-14', '2025-04-25', 4, 4),
    ('2025-05-01', '2025-05-02', 3, 5),
    ('2025-06-23', '2025-07-04', 4, 6),
    ('2025-07-07', '2025-07-18', 4, 7),
    ('2025-08-04', '2025-08-15', 4, 8),
    ('2025-09-01', '2025-09-05', 2, 9),
    ('2025-10-20', '2025-10-24', 3, 10),
    ('2025-11-03', '2025-11-07', 2, 1),
    ('2025-12-22', '2025-12-31', 4, 2);

-- Script complet v�rifi�
