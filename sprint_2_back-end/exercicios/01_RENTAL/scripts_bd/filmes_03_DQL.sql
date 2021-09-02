-- Listar todos os Clientes

SELECT * FROM CLIENTE

-- Ou

SELECT idCliente, nomeCliente, sobrenomeCliente, cpfCliente, cnhCliente, idCliente FROM CLIENTE -- Sim, selecionei duas vezes o idCliente para melhor visualização da tabela

-- Listar todos os veículos com suas respectivas marcas e modelos

SELECT idVeiculo, nomeMarca, nomeModelo FROM VEICULO
INNER JOIN MARCA
ON VEICULO.idMarca = MARCA.idMarca
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo;

--- Listar todos os alugueis mostrando o nome, sobrenome e cnh do cliente, a marca e o modelo do carro alugado, e quando ele foi iniciado o período de uso e o último dia de uso do veículo

SELECT idAluguel, nomeCliente, sobrenomeCliente, cnhCliente, nomeMarca, nomeModelo, dataAquisicao, dataDevolucao FROM ALUGUEL
INNER JOIN CLIENTE
ON ALUGUEL.idCliente = CLIENTE.idCliente
INNER JOIN VEICULO
ON ALUGUEL.idVeiculo = VEICULO.idVeiculo
INNER JOIN MARCA
ON VEICULO.idMarca = MARCA.idMarca
INNER JOIN MODELO
ON VEICULO.idModelo = MODELO.idModelo;
