USE LOCADORA_T
GO

--- listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro

SELECT idAluguel, nomeCliente, nomeModelo, dataAquisicao, dataDevolucao FROM ALUGUEL
INNER JOIN CLIENTE
ON ALUGUEL.idCliente = CLIENTE.idCliente
INNER JOIN VEICULO
ON ALUGUEL.idVeiculo = VEICULO.idVeiculo
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo;

/* 

--com a marca:

SELECT idAluguel, nomeCliente, nomeMarca, nomeModelo, dataAquisicao, dataDevolucao FROM ALUGUEL
INNER JOIN CLIENTE
ON ALUGUEL.idCliente = CLIENTE.idCliente
INNER JOIN VEICULO
ON ALUGUEL.idVeiculo = VEICULO.idVeiculo
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo
INNER JOIN MARCA
ON VEICULO.idMarca = MARCA.idMarca; 

*/

-- listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro

SELECT idAluguel, nomeCliente, nomeModelo, dataAquisicao, dataDevolucao FROM ALUGUEL
INNER JOIN CLIENTE
ON ALUGUEL.idCliente = CLIENTE.idCliente
INNER JOIN VEICULO
ON ALUGUEL.idVeiculo = VEICULO.idVeiculo
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo
WHERE nomeCliente = 'Enzo';

/* 
-- com a marca:

SELECT idAluguel, nomeCliente, nomeMarca, nomeModelo, dataAquisicao, dataDevolucao FROM ALUGUEL
INNER JOIN CLIENTE
ON ALUGUEL.idCliente = CLIENTE.idCliente
INNER JOIN VEICULO
ON ALUGUEL.idVeiculo = VEICULO.idVeiculo
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo
INNER JOIN MARCA
ON VEICULO.idMarca = MARCA.idMarca
WHERE nomeCliente = 'Enzo'; 

*/
