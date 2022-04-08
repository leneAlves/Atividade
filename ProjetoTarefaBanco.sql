create database projetotarefa;

use projetotarefa;

create table tbtarefa(
	id int auto_increment primary key,
	titulo varchar(50),
    assunto varchar(50),
    data datetime,
	importancia varchar(200)
);