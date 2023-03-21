CREATE DATABASE Livros;

USE Livros;
GO;

CREATE TABLE Livro
(
    Id         INTEGER IDENTITY (1, 1),
    Titulo     NVARCHAR(MAX) NOT NULL,
    Autor      NVARCHAR(MAX) NOT NULL,
    Editor     NVARCHAR(MAX) NOT NULL,
    DataCompra DATE          NOT NULL,
    Estado     BIT           NOT NULL,
    PRIMARY KEY (Id)
);