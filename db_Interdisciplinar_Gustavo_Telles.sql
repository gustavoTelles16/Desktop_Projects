create database db_EasyTech_Gerenciamento;
use db_EasyTech_Gerenciamento;

create table tb_Cliente 
(
	id_Cliente int auto_increment not null,
    nome_Cliente varchar (50) not null,
    cpf_Cliente char (11) not null,
    endereco_Cliente varchar (100),
    telefone_Cliente varchar (11) not null,
    constraint pk_Cliente primary key (id_Cliente),
    constraint un_CPF_Cliente unique (cpf_Cliente)
);

create table tb_Modulo
(
	id_Modulo int auto_increment not null,
    id_Cliente_Modulo int not null,
    nome_Modulo varchar (30) not null,
    modelo_Modulo varchar (30) not null,
    marca_Modulo varchar (30) not null,
    garantia_Modulo char (1) not null,
    data_Manutencao date not null,
    data_entrada date not null,
    status_Modulo varchar (30) not null,
    defeito_Modulo varchar (100) not null,
    classificacao_defeito varchar (30) not null,
    uso_Componentes varchar (100),
    antigo_Firmware varchar (30),
    atual_Firmware varchar (30), 
    constraint pk_Modulo primary key (id_Modulo),
    constraint fk_Cliente_Modulo foreign key (id_Cliente_Modulo)
    references tb_Cliente (id_Cliente)
);

create table tb_Tecnico
(
	id_Tecnico int auto_increment not null,
    nome_Tecnico varchar (50),
    cpf_Tecnico char (11) not null,
    telefone_Tecnico varchar(11) not null,
    endereco_Tecnico varchar (100),
    constraint pk_Tecnico primary key (id_Tecnico),
    constraint un_CPF_Tecnico unique (cpf_Tecnico)
);

create table tb_Componente
(
	id_Componente int auto_increment not null,
    id_Componente_Modulo int not null,
    nome_Componente varchar (30) not null,
    descricao_Componente varchar (100) not null,
    data_compra date,
    preco_Componente numeric (7,2),
    constraint pk_Componente primary key (id_Componente),
    constraint fk_Componente foreign key (id_Componente_Modulo)
    references tb_Modulo (id_Modulo)
);

create table tb_Estoque
(
	id_Componente_Estoque int not null,
    quantidade_Componente int (3) not null,
    disponibilidade_Componente char (1) not null,
    constraint fk_Estoque foreign key (id_Componente_Estoque)
    references tb_Componente (id_Componente)
);

create table tb_Manutencao_Modulo
(
	id_Numero_GRM int auto_increment not null,
    id_Cliente_Manutencao int not null,
    id_Tecnico_Manutencao int not null,
    id_Modulo_Manutencao int not null,
    id_Componente_Manutencao int,    
    constraint pk_Numero_GRM primary key (id_Numero_GRM),
    constraint fk_Cliente_Manutencao foreign key (id_Cliente_Manutencao)
    references tb_Cliente (id_Cliente),
    constraint fk_Tecnico_Manutencao foreign key (id_Tecnico_Manutencao)
    references tb_Tecnico (id_Tecnico),
    constraint fk_Modulo_Manutencao foreign key (id_Modulo_Manutencao)
    references tb_Modulo (id_Modulo),
	constraint fk_Componente_Manutencao foreign key (id_Componente_Manutencao)
    references tb_Componente (id_Componente)
);

select * from tb_Estoque;

start transaction;

insert into tb_Cliente (nome_Cliente, cpf_Cliente, endereco_Cliente, telefone_Cliente)
values 
('Roberto Gomes Alves', '12345678912', 'Rua das Oliveiras, 55 - Juquitiba', '11987654321'), 
('Fabiana Araujo Neves', '09876543210', 'Rua das Orquídeas, 60 - Taboão da Serra', '11912345678'),
('Gabriel Ferreira Costa', '32165498710', 'Rua dos Amendoins, 87 - Embu das Artes', '11932165487');

insert into tb_Modulo (nome_Modulo, marca_Modulo, garantia_Modulo, data_Manutencao, data_entrada, status_Modulo, defeito_Modulo, classificacao_defeito, uso_Componentes_antigo_Firmware, atual_FirmWare)
values
('Modulo 1', 'Modelo 1', 'Marca 1', 'S', '11/14/2023', '2023/10/11', 'Quebrado', 'Peça quebrada', 'Leve', 'Componente 1', 'Firmware 0', 'Firmware 1'),
('Modulo 2', 'Modelo 2', 'Marca 2', 'N', '07/21/2023', '07/25/2023', 'Quebrado', 'Peça quebrada', 'Moderado', 'Componente 2', 'Firmware 98', 'Firmware 99'),
('Modulo 3', 'Modelo 3', 'Marca 3', 'S', '05/08/2023', '05/10/2023', 'Quebrado', 'Peça quebrada', 'Grave', 'Componente 3', 'Firmware 87', 'Firmware 88');

insert into tb_Tecnico (nome_Tecnico, cpf_Tecnico, telefone_Tecnico, endereco_Tecnico)
values
('Fernando Henrique Lima', '91283475612', '11947825136', 'Rua das Margaridas, 89 - São Paulo'),
('Victor Costa da Silva', '35689741259', '11934789651', 'Rua dos Girassóis, 115 - Boa Vista'),
('Carlos Henrique da Silva', '12478965423', '11932145689', 'Rua dos Rolchinóis, 225 - Campinas'); 

insert into tb_Componente (nome_Componente, descricao_Componente, data_compra, preco_Componente)
values
('Componente 1', 'Componente que vai no módulo 1', '2023/11/05', 75.00),
('Componente 2', 'Componente que vai no módulo 2', '2023/07/20', 125.00),
('Componente 3', 'Componente que vai no módulo 3', '2023/05/05', 50.00);

insert into tb_Estoque (quantidade_Componente, disponibilidade_Componente)
values 
(50, 'S'),
(75, 'S'),
(25, 'S');

select * from tb_Cliente;

select * from tb_Modulo;

select * from tb_Tecnico;

select * from tb_Tecnico;

select * from tb_Estoque;