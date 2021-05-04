drop database gestion_eleves;
create database gestion_eleves;
use gestion_eleves;

drop table if exists etudiant;
create table etudiant(
id int primary key auto_increment not null,
identifiant varchar(60),
password varchar(60),
email varchar(60))engine=innodb;

drop table if exists notes;
create table notes(
id int primary key auto_increment not null,
matiere varchar(60),
note int,
moyenne int,
coefficient int)engine=innodb;

drop table if exists cours;
create table cours(
id int primary key auto_increment not null,
heureDebut time,
dureeCours int,
matiere varchar(60),
jourDeLaSemaine int,
classe varchar(60),
professeur varchar(60),
salle int)engine=innodb;

drop table if exists classe;
create table classe(
id int primary key auto_increment not null,
numClasse int,
anneeClasse varchar(60))engine=innodb;
