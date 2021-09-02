CREATE DATABASE CATALOGO_T
GO

USE CATALOGO_T
GO

CREATE TABLE GENERO (

	idGenero TINYINT PRIMARY KEY IDENTITY(1,1),
	nomeGenero VARCHAR(20) NOT NULL

);
GO

CREATE TABLE FILME (

	idFilme SMALLINT PRIMARY KEY IDENTITY(1,1),
	idGenero TINYINT FOREIGN KEY REFERENCES GENERO(idGenero),
	tituloFilme VARCHAR(50) NOT NULL

);
GO

-- Assim dá para comentar
/*
e assim também
*/

-- Dropar um Banco:
/*
DROP DATABASE CATALOGO_T
GO
*/

-- Dropar uma coluna:
/* 
ALTER TABLE FILME
DROP COLUMN tituloFilme
*/

-- Adicionar uma coluna:
/*
ALTER TABLE FILME
ADD tituloFilme VARCHAR(50) NOT NULL UNIQUE;
*/

-- Renomear um Banco de Dados:
-- 1º Forma, é ir no pesquisador do banco, e clicar com botão direito e renomear.
-- a 2º Forma, por código (claro), é assim:
/*
USE master;
GO

ALTER DATABASE CATALOGO_T SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO

ALTER DATABASE CATALOGO_T MODIFY NAME = CATALOGO_DE_FILMES;
GO

ALTER DATABASE CATALOGO_DE_FILMES SET MULTI_USER;
GO

-- E neste processo, está alterado o nome, mas contudo, as infos no nome lógico, ainda estarão com o nome antigo, e usamos isso aqui para atualizar:

ALTER DATABASE CATALOGO_DE_FILMES MODIFY FILE (
	NAME = CATALOGO_T
	,NEWNAME = CATALOGO_DE_FILMES
	,FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CATALOGO_DE_FILMES.mdf'
);
GO

ALTER DATABASE CATALOGO_DE_FILMES MODIFY FILE (
	NAME = CATALOGO_T_log
	,NEWNAME = CATALOGO_DE_FILMES_log
	,FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\CATALOGO_DE_FILMES_log.ldf'
);
GO

-- Peguei essa explicação deste site: https://www.brunodba.com/2019/06/20/renomeando-um-banco-de-dados/ :D

*/
