USE CATALOGO_T
GO

INSERT INTO GENERO (nomeGenero)
VALUES ('AÇÃO'), ('ROMANCE'), ('AVENTURA'), ('TERROR');
GO

INSERT INTO FILME (idGenero, tituloFilme)
VALUES (1, 'Rambo'), (1, 'Vingadores'), (2, 'Ghost'), (2, 'Diário de uma paixão'), (NULL, 'HER'), (NULL, 'Homem-Aranha');
GO

UPDATE FILME SET tituloFilme = 'Rambo 2'
WHERE idFilme = 1
GO

SELECT * FROM GENERO
GO

SELECT * FROM FILME
GO

/*

DELETE FROM FILME
WHERE idFilme in(2,3)
GO

DELETE FROM GENERO
WHERE idGenero = 2

*/
