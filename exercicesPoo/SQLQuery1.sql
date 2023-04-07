CREATE TABLE personne(
--id int PRIMARY KEY,
id_personne int not null,
nom varchar(200) not null,
prenom varchar(200) not null,
telephone varchar(10) not null,
id int not null,
CONSTRAINT pk_personne_id PRIMARY KEY (id),
CONSTRAINT fk_departement_id FOREIGN KEY (id) REFERENCES departement(id)
);


CREATE TABLE departement(
id int PRIMARY KEY,
nom varchar not null
);

drop table personne;
drop table departement;

ALTER TABLE personne DROP COLUMN telephone;
Alter table personne add telephone varchar;

CREATE TABLE compte(
compte_id int primary key,
pseudo varchar(50) not null,
mot_de_passe varchar(50) not null,
email varchar(255) not null,
dtae_creation datetime,
derniere_connexion varchar(50)
);

CREATE TABLE compte_role(
compte_id int,
role_id int,
date_ajout datetime,
CONSTRAINT fk_compte_compte_role_compte_id FOREIGN KEY (compte_id) REFERENCES compte(compte_id),
CONSTRAINT fk_lerole_compte_role_role_id FOREIGN KEY (role_id) REFERENCES lerole(role_id)
);

CREATE TABLE lerole(
role_id int PRIMARY KEY,
libelle varchar(50)
);

drop table compte_role;
drop table _role;



-- Correction Exercice slide 30

CREATE TABLE professeur(
id int PRIMARY KEY,
prenom varchar(50) not null,
nom varchar(50) not null,
n_classe int not null,
n_departement int not null,
email varchar(255) not null,
telephone varchar(10) not null);

 

CREATE TABLE etudiant(
id int primary key,
prenom varchar(50) not null,
nom varchar(50) not null,
n_classe int not null,
date_diplome datetime,
--telephone varchar(10) not null
);

 

CREATE TABLE etudiant_professeur (
etudiant_id int,
prof_id int,
CONSTRAINT fk_etudiant_etudiant_id FOREIGN KEY (etudiant_id) REFERENCES etudiant(id),
CONSTRAINT fk_professeur_prof_id FOREIGN KEY (prof_id) REFERENCES professeur(id)
);

 

CREATE TABLE etudiant_telephone(
etudiant_id int,
telephone varchar(10) PRIMARY KEY,
CONSTRAINT fk_telephone_etudiant_id FOREIGN KEY (etudiant_id) REFERENCES etudiant(id)
);

INSERT INTO etudiant (id, prenom, nom, n_classe)
values (4, 'tati', 'titi', 105);

INSERT INTO etudiant(date_diplome) values ('01-01-2021');

SELECT nom FROM etudiant ORDER BY nom DESC;
SELECT count(nom) nom FROM etudiant GROUP BY nom;

CREATE TABLE livre(
id int primary key identity(1,1),
titre varchar(50) not null,
auteur varchar(50)not null,
editeur varchar(50)not null,
date_publication date not null,
isbn_10 varchar(10) not null,
isbn_13 varchar(15) not null
);

drop table livre;

INSERT INTO livre (titre, auteur, editeur, date_publication, isbn_10, isbn_13)
VALUES
('Poil de Carrottes','Jules Renard','Livre de Poche','1999-08-25','2253160431','978-2253160434'),
('Les Fourberies de Scapin','Molière','Hachette Education','2016-04-13','2013949677','978-2013949675'),
('Les Cahiers de Douai','Arthur Rimbaud','Nathan','2018-05-04','2091891231','978-2091891231'),
('Cyrano de Bergerac','Edmond Rostand','Nathan','2018-05-03','2091887005','978-2091887005'),
('Dom Juan','Molière','Nathan','2018-08-23','2091891185','978-2091891187'),
('Le Cid','Corneille','Nathan','2017-08-24','2091887595','978-2091887593'),
('Les Fausses Confidences','Marivaux','Nathan','2020-08-20','2091512184','978-2091512181'),
('Les Fleurs du Mal','Charles Baudelaire','Nathan','2020-01-02','2091864951','978-2091864952'),
('Le rouge et le noir','Stendhal','Folio CLassique','1967-01-01','2070412393','978-2070412396'),
('Madame Bovary','Gustave Flaubert','Livre de Poche','2019-05-22','2253183466','978-2253183464'),
('La Chartreuse de Parme','Stendhal','Livre de Poche','2020-09-01','2253160687','978-2253160687'),
('La Rabouilleuse','Honoré de Balzac','Editeur indépendant','2020-04-12','XXXXXXXXXX','979-8636546696'),
('Illusions perdues','Honoré de Balzac','Livre de Poche','2006-08-23','2253085707','978-2253085706'),
('L''Education sentimentale','Gustave Flaubert','Livre de Poche','2002-05-16','2253010693','978-2253010692'),
('Mort sur le Nil','Agatha Christie','Livre de Poche','2014-08-20','201005640X','978-2010056406'),
('Le crime de l''Orient-Express','Agatha Christies','Livre de Poche','2014-08-20','2010009274','978-2010009273'),
('Un cadavre dans la bibliothèque','Agatha Christie','Livre de Poche','2015-06-03','2012202403','978-2012202405'),
('Le train bleu','Agatha Christie','Livre de Poche','2014-08-14','2010056450','978-2010056451'),
('Entretiens sur la multitude du monde','Jean-Claude Carrière','Odile Jacob','2002-09-21','2738110770','978-2738110770'),
('Discours de la méthode','René Descartes','Editeur indépendant','2017-02-03','XXXXXXXXXX','979-8649135313'),
('La République','Platon','Livre de Poche','2016-06-22','2081386690','978-2081386693'),
('Les Politiques','Aristote','Flammarion','2015-04-22','2081358778','978-2081358775'),
('Le Banquet','Platon','Flammarion','2015-04-22','2081382644','978-2081382640'),
('Le gai savoir','Platon','Editeur indépendant','2019-07-05','XXXXXXXXXX','979-8658807928'),
('Stop aux réseaux sociaux ! 10 bonnes raisons de s''en méfier et de s''en libérer','Jaron Lanier','DE BOECK SUP','2020-03-17','2807329098','978-2807329096'),
('Transformer votre vie: 19 pistes pour améliorer mes relations, me libérer de mes pensées négatives et réaliser mes rêves !','Julie Guerrière Pacifique','Club Positif','2020-01-22','2373181797','978-2373181791'),
('Remédier à l''insatisfaction: Un guide pratique pour faire face aux problèmes de la vie quotidienne','Carlo di Portago','Editeur indépendant','2020-11-22','XXXXXXXXXX','979-8569448883'),
('Lève-toi et Vends !','Nicolas Caron','Editeur indépendant','2017-09-28','1723716723','978-1723716720'),
('Pensée positive et optimisme: Les deux grands principes pour réussir sa vie ','Christian Dubois','Editeur indépendant','2021-01-07','XXXXXXXXXX','979-8591746797'),
('LE GUIDE DE LA PENSÉE POSITIVE: Comment maîtriser le pouvoir de la pensée pour vivre heureux et atteindre ses objectifs','Vincent Crivelli','Editeur indépendant','2021-02-02','XXXXXXXXXX','979-8703516423');



