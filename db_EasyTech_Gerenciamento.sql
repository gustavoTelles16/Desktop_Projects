create database db_EasyTech_Gerenciamento;
use db_EasyTech_Gerenciamento;

create table tb_Cliente 
(
	id int auto_increment,
    nome varchar (50) not null,
    cpf char (11) not null,
    endereco varchar (100),
    telefone varchar (11) not null,
    constraint pk_Cliente primary key (id),
    constraint un_Cliente_CPF unique (cpf)
);

create table tb_Modulo
(
	id int auto_increment,
    id_Modulo_Cliente int,
    nome varchar (30) not null,
    modelo varchar (30) not null,
    marca varchar (30) not null,
    garantia char (1) not null,
    data_Manutencao date not null,
    data_Entrada date not null,
    status_Modulo varchar (30) not null,
    defeito varchar (100) not null,
    classificacao_Defeito varchar (30) not null,
    componentes_Modulo varchar (100),
    antigo_Firmware varchar (30),
    atual_Firmware varchar (30), 
    constraint pk_Modulo primary key (id),
    constraint fk_Modulo_Cliente foreign key (id_Modulo_Cliente)
    references tb_Cliente (id)
);

create table tb_Tecnico
(
	id int auto_increment,
    nome varchar (50) not null,
    cpf char (11) not null,
    telefone varchar(11) not null,
    endereco varchar (100),
    constraint pk_Tecnico primary key (id),
    constraint un_Tecnico_CPF unique (cpf)
);

create table tb_Componente
(
	id int auto_increment,
    id_Componente_Modulo int,
    nome varchar (30) not null,
    descricao varchar (100) not null,
    data_Compra date,
    preco numeric (7,2),
    constraint pk_Componente primary key (id),
    constraint fk_Componente_Modulo foreign key (id_Componente_Modulo)
    references tb_Modulo (id)
);

create table tb_Estoque
(
	id_Estoque_Componente int,
    quantidade smallint not null,
    disponibilidade char (1) not null,
    constraint fk_Estoque_Componente foreign key (id_Estoque_Componente)
    references tb_Componente (id)
);

create table tb_Manutencao_Modulo
(
	id_Numero_GRM int auto_increment,
    id_Manutencao_Cliente int,
    id_Manutencao_Tecnico int,
    id_Manutencao_Modulo int,
    id_Manutencao_Componente int,    
    constraint pk_Manutencao_Modulo primary key (id_Numero_GRM),
    constraint fk_Manutencao_Cliente foreign key (id_Manutencao_Cliente)
    references tb_Cliente (id),
    constraint fk_Manutencao_Tecnico foreign key (id_Manutencao_Tecnico)
    references tb_Tecnico (id),
    constraint fk_Manutencao_Modulo foreign key (id_Manutencao_Modulo)
    references tb_Modulo (id),
	constraint fk_Manutencao_Componente foreign key (id_Manutencao_Componente)
    references tb_Componente (id)
);

start transaction;

insert into tb_Cliente (nome, cpf, endereco, telefone)
values 
('Roberto Gomes Alves', '12345678912', 'Rua das Oliveiras, 55 - Juquitiba', '11987654321'), 
('Fabiana Araujo Neves', '09876543210', 'Rua das Orquídeas, 60 - Taboão da Serra', '11912345678'),
('Gabriel Ferreira Costa', '32165498710', 'Rua dos Amendoins, 87 - Embu das Artes', '11932165487');

insert into tb_Modulo (nome, modelo, marca, garantia, data_Manutencao, data_Entrada, status_Modulo, defeito, classificacao_Defeito, componentes_Modulo, antigo_Firmware, atual_FirmWare)
values
('Módulo 1', 'Modelo 1', 'Marca 1', 'S', '2023-11-14', '2023-11-10', 'Quebrado', 'Peça quebrada', 'Leve', 'Componente 1', 'Firmware 0', 'Firmware 1'),
('Módulo 2', 'Modelo 2', 'Marca 2', 'N', '2023-07-21', '2023-07-25', 'Quebrado', 'Peça quebrada', 'Moderado', 'Componente 2', 'Firmware 98', 'Firmware 99'),
('Módulo 3', 'Modelo 3', 'Marca 3', 'S', '2023-08-05', '2023-10-05', 'Quebrado', 'Peça quebrada', 'Grave', 'Componente 3', 'Firmware 87', 'Firmware 88');

insert into tb_Tecnico (nome, cpf, telefone, endereco)
values
('Fernando Henrique Lima', '91283475612', '11947825136', 'Rua das Margaridas, 89 - São Paulo'),
('Victor Costa da Silva', '35689741259', '11934789651', 'Rua dos Girassóis, 115 - Boa Vista'),
('Carlos Henrique da Silva', '12478965423', '11932145689', 'Rua dos Rolchinóis, 225 - Campinas'); 

insert into tb_Componente (nome, descricao, data_Compra, preco)
values
('Componente 1', 'Componente que vai no módulo 1', '2023-11-05', 75.00),
('Componente 2', 'Componente que vai no módulo 2', '2023-07-20', 125.00),
('Componente 3', 'Componente que vai no módulo 3', '2023-05-05', 50.00);

insert into tb_Estoque (quantidade, disponibilidade)
values 
(50, 'S'),
(75, 'S'),
(25, 'S');

select * from tb_Cliente;

select * from tb_Modulo;

select * from tb_Tecnico;

select * from tb_Estoque;

commit;

start transaction;

select cl.id, m.id 
from tb_Cliente as cl
inner join tb_Modulo as m
on cl.id = m.id;

select co.id, e.id_Estoque_Componente 
from tb_Componentes as co
left join tb_Estoque as e
on co.id = e.id_Estoque_Componente;