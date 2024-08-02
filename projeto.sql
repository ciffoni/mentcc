create database projeto;
use projeto;
create table usuario(
cod_usuario int primary key auto_increment,
nome varchar(60),
email varchar(60),
senha varchar(45),
cargo int(3)
);