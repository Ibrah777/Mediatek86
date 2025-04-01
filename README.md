# MediaTek86 — Gestion du personnel

Application Windows Forms C# développée dans le cadre de l'**Atelier 2 — BTS SIO SLAM** (CNED).  
Contexte : ESN InfoTech Services 86 — mission pour le réseau de médiathèques MediaTek86.

---

## Fonctionnalités

**Connexion sécurisée**
- Authentification login + mot de passe hashé en SHA2-256

**Gestion du personnel**
- Afficher la liste du personnel
- Ajouter / Modifier / Supprimer un membre du personnel
- Affectation à un service (Administratif, Médiation culturelle, Prêt)

**Gestion des absences**
- Afficher les absences d'un personnel (ordre chronologique inverse)
- Ajouter / Modifier / Supprimer une absence
- Contrôle des chevauchements de dates
- Motifs : Vacances, Maladie, Motif familial, Congé parental

---

## Architecture MVC

```
mediatek86/
├── bddmanager/
│   └── BddManager.cs              # Singleton connexion MySQL
├── controller/
│   └── FrmMediaTekController.cs   # Contrôleur principal
├── dal/
│   ├── Access.cs                  # Classe mère DAL
│   ├── PersonnelAccess.cs         # CRUD personnel
│   ├── AbsenceAccess.cs           # CRUD absences + contrôle chevauchements
│   ├── ServiceAccess.cs           # Lecture services
│   ├── MotifAccess.cs             # Lecture motifs
│   └── ResponsableAccess.cs       # Vérification connexion
├── model/
│   ├── Personnel.cs
│   ├── Absence.cs
│   ├── Service.cs
│   ├── Motif.cs
│   └── Responsable.cs
├── view/
│   ├── FrmConnexion.cs            # Fenêtre de connexion
│   └── FrmMediaTek.cs             # Fenêtre principale
├── App.config                     # Chaîne de connexion MySQL
└── mediatek86.sql                 # Script BDD complet
```

---

## Installation

**Prérequis** : Visual Studio 2022, XAMPP/WAMP (MySQL), MySQL Connector NET 9.1

1. Importer `mediatek86.sql` dans phpMyAdmin
2. Ouvrir `mediatek86.sln` dans Visual Studio
3. Vérifier la référence `MySql.Data.dll`
4. Lancer (F5)

**Identifiants par défaut** : `admin` / `Admin123`

---

## Compétences mobilisées (BTS SIO)

- Mettre en place et vérifier les niveaux d'habilitation associés à un service
- Architecture MVC + couche DAL + pattern Singleton
- Base de données MySQL — requêtes préparées, JOIN, CASCADE
- WinForms .NET Framework 4.8

---

## Auteur

**Ibrahima Dione** — BTS SIO SLAM (CNED, 2025-)  
[LinkedIn](https://www.linkedin.com/in/el-hadj-ibrahima-dione777/)
