-- Em teoria, se fosse para pegar do início, seria assim:

-- DDL

CREATE DATABASE RENTAL_T
GO

USE RENTAL_T
GO

CREATE TABLE CLIENTE (

	idCliente SMALLINT PRIMARY KEY IDENTITY(1,1),
	nomeCliente VARCHAR(20) NOT NULL,
  sobrenomeCliente VARCHAR(20) NOT NULL,
	cpfCliente CHAR(14) NOT NULL UNIQUE,
	cnhCliente CHAR(10) NOT NULL UNIQUE

);
GO

CREATE TABLE MARCA (

	idMarca TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeMarca VARCHAR(20) NOT NULL UNIQUE

);
GO

CREATE TABLE MODELO (

	idModelo TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeModelo VARCHAR(20) NOT NULL UNIQUE

);
GO

CREATE TABLE VEICULO (

	idVeiculo SMALLINT PRIMARY KEY IDENTITY(1,1),
	idMarca TINYINT FOREIGN KEY REFERENCES MARCA(idMarca),
	idModelo TINYINT FOREIGN KEY REFERENCES MODELO(idModelo),
	placaVeiculo CHAR(7) NOT NULL UNIQUE

);
GO

CREATE TABLE ALUGUEL (
	
	idAluguel INT PRIMARY KEY IDENTITY(1,1),
	idCliente SMALLINT FOREIGN KEY REFERENCES CLIENTE(idCliente),
	idVeiculo SMALLINT FOREIGN KEY REFERENCES VEICULO(idVeiculo),
	dataAquisicao DATE,
	dataDevolucao DATE

);
GO

CREATE TABLE EMPRESA (
	
	idEmpresa TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeEmpresa VARCHAR(40) NOT NULL UNIQUE

);
GO

-- Mas como alterei apenas a "Locadora" existente, então foi isso que foi adicionado:

ALTER TABLE CLIENTE
ADD sobrenomeCliente VARCHAR(20);
GO

-- Aqui no meio vem a adição de dados nos campos através do script DML

ALTER TABLE CLIENTE
ALTER COLUMN sobrenomeCliente VARCHAR(20) NOT NULL;
GO
