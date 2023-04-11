-- noinspection SpellCheckingInspectionForFile
CREATE DATABASE MT1_22_23;
GO

USE MT1_22_23;
GO

CREATE TABLE Campeonato
(
    Ano              INTEGER NOT NULL,
    JogosPorDisputar INTEGER NOT NULL DEFAULT 0,
    JogosDisputados  INTEGER NOT NULL DEFAULT 0,
    CHECK (Ano > 2000),
    PRIMARY KEY (Ano)
);

CREATE TABLE Jogo
(
    Ano            INTEGER      NOT NULL,
    Casa           INTEGER      NOT NULL,
    Fora           INTEGER      NOT NULL,
    ResultadoFinal VARCHAR(MAX) NOT NULL DEFAULT 'Por Disputar',
    CHECK (Ano > 2000),
    CHECK (Casa > 0),
    CHECK (Fora > 0),
    PRIMARY KEY (Ano, Casa, Fora),
    FOREIGN KEY (Ano) REFERENCES Campeonato (Ano)
);