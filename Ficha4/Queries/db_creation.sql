-- noinspection SpellCheckingInspectionForFile

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

CREATE TABLE Aluno
(
    Id       INTEGER IDENTITY (1, 1),
    Nome     NVARCHAR(MAX) NOT NULL,
    Endereco NVARCHAR(MAX) NOT NULL,
    Garantia MONEY         NOT NULL,
    PRIMARY KEY (Id)
);

CREATE TABLE Emprestimo
(
    LivroId        INTEGER NOT NULL,
    AlunoId        INTEGER NOT NULL,
    DataRequisicao DATE    NOT NULL,
    DataEntrega    DATE,
    PRIMARY KEY (LivroId, AlunoId, DataRequisicao),
    FOREIGN KEY (LivroId) REFERENCES Livro (Id),
    FOREIGN KEY (AlunoId) REFERENCES Aluno (Id)
);