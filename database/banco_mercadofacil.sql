create database merceariafacil;
use merceariafacil;

create table usuarios
(
	id int auto_increment primary key,
	nome varchar(100),
	email varchar(100),
	senha varchar(100)
);

create table produtos
(
	id int auto_increment primary key,
    nome varchar(100),
    preco decimal(10,2),
    quantidade int
);

create table vendas
(
	id int auto_increment primary key,
    usuario_id int,
    valor_total decimal(10,2),
    data datetime,
    foreign key(usuario_id) references usuario(id)
);

create table itens_venda
(
	id int auto_increment primary key,
    venda_id int,
    produto_id int,
    quantidade int,
    preco decimal(10,2),
    foreign key(venda_id) references vendas(id),
    foreign key(produto_id) references produtos(id)
);

