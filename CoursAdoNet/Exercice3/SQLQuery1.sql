CREATE TABLE compte_bancaire (
id_compte int primary key identity (1,1)not null,
solde int,
id_client int constraint fk_client_id_client foreign key (id_client) references client(id_client));


CREATE TABLE client(
id_client int primary key identity (1,1) not null,
nom varchar(200) not null,
prenom varchar(200) not null,
);

CREATE TABLE operation(
numero int primary key not null,
montant decimal,
statut varchar(100) not null);