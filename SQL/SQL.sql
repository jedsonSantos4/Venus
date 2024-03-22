

CREATE TABLE Produto (
    Id int NOT NULL AUTO_INCREMENT,
    DataCriacao     DATETIME DEFAULT CURRENT_TIMESTAMP,
    DataModificacao_time DATETIME ON UPDATE CURRENT_TIMESTAMP,
    CodigoProduto int,
    Nome varchar(255) NOT NULL,
    Descricao varchar(255),
    DataEntrada DATETIME,
    DataSaida DATETIME,
    QuantidadeEntrada int,
    QuantidadeSaida int,
    Defeito int,
    PRIMARY KEY (Id)
);