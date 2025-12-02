## Password Generator

Un générateur de mots de passe simple développé en C#.
Ce projet permet de créer des mots de passe sécurisés en fonction de la taille choisi par l’utilisateur.


## Table des matieres

- [Fonctionnalites](#fonctionnalites)
- [Installation](#installation)
- [Technologies](#technologies)
- [Securite](#securite)
- [Enseignements du projet](#enseignements-du-projet)
- [Auteur](#auteur)


## Fonctionnalites

- Génération de mots de passe aléatoires
- Choix de la longueur
- Inclusions :
  * Lettres majuscules
  * Lettres minuscules
  * Chiffres
  * Caractères spéciaux
- Interface console simple et intuitive

## Installation

1) Clonner le dépôt :

```bash
git clone https://github.com/ton-profil/password-generator.git
```
2) Se rendre dans le dossier :

```bash
cd PasswordGeneratorConsole
```
3) Compiler le projet :

```bash
dotnet build
```
4) Lancer l'application :

```bash
dotnet run
```

## Technologies

- C#
- .NET (version à préciser)
- IDE : Visual Studio / VS Code

## Securite

Ce générateur crée des mots de passe aléatoires à usage personnel.
 * Ne stocke pas les mots de passe dans des fichiers ou logs
 * Toujours vérifier la politique de sécurité selon votre contexte d’utilisation.

## Ameliorations futures

- Interface graphique (WPF ou WinForms)
- Vérification du niveau de sécurité du mot de passe
- Génération multiple
- Export en fichier sécurisé

## Enseignements du projet

Ce projet m’a permis de pratiquer et de consolider plusieurs concepts essentiels en C# :

- Utilisation de la classe Random pour générer des valeurs aléatoires
- Manipulation des conditions : if, else if, else
- Utilisation de la boucle for
- Conversion de types, notamment string → int avec int.Parse()
- Utilisation de la propriété .Length pour obtenir la taille d’une chaîne

## Auteur

- Nom : Cyril Coirault
- GitHub : [NRNOIR](https://github.com/NRNoir)
- [LinkedIn](https://www.linkedin.com/in/cyril-coirault-37585511a/)
