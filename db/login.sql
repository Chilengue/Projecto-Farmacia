create database farmacia;

create table  login
(
    ID int  identity(1, 1) primary key,
    Nome varchar (200) not null,
    email varchar (50) unique not null,
    sexo varchar (30) not null,
    data_nasc year not null,
    codigo varchar (30) not null,
    codigo varchar(30) not null,
    perfil binary not null
)

create 