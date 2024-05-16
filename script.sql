/*
Criando O BD */

create database bdProjeto;
use bdProjeto;

/*
usando o bd
*/

create table tbCliente(
codcli int primary key auto_increment,
nome varchar(50),
telefone varchar(20),
email varchar(50)
);
select * from tbCliente;
