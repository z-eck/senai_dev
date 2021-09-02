USE LOCADORA_T
GO

INSERT INTO CLIENTE (nomeCliente, cpfCliente, cnhCliente)
VALUES ('Enzo', '123.456.789-00',1234567890), ('Valentina','888.888.888-88',8888888888), ('João','009.876.543-21',1098765432), ('Maria','131.313.131-31',1313131313);
GO

INSERT INTO MARCA (nomeMarca)
VALUES ('GM'), ('Ford'), ('Fiat');
GO

INSERT INTO MODELO (nomeModelo)
VALUES ('Onix'), ('Fiesta'), ('Argo');
GO

INSERT INTO VEICULO (idMarca, idModelo, placaVeiculo)
VALUES (1, 1, 'AAA1111'), (2, 2, 'BBB2222'), (3, 3, 'CCC3333'), (3, 3, 'DDD4444');
GO

INSERT INTO ALUGUEL (idCliente, idVeiculo, dataAquisicao, dataDevolucao)
VALUES (1, 1, '20/08/2021', '20/09/2021'), (3, 2, '13/08/2021', '20/08/2021'), (2, 1, '21/09/2021', '21/10/2021'), (2, 2, '21/08/2021', '28/08/2021'), (1, 3, '01/09/2021', '30/09/2021'), (3, 4, '09/10/2021', '08/10/2022'), (4, 4, '10/08/2021', '08/10/2021'), (1, 2, '29/08/2021', '05/09/2021');
GO

INSERT INTO EMPRESA (nomeEmpresa)
VALUES ('Cleber Motors');
GO
