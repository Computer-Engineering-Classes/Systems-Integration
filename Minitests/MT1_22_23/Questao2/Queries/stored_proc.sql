-- noinspection SpellCheckingInspectionForFile

-- Criar campeonato
CREATE PROCEDURE CreateCampeonato @Ano INTEGER
AS
BEGIN
    -- Verificar se o ano já existe
    IF EXISTS (SELECT * FROM Campeonato WHERE Ano = @Ano)
        BEGIN
            RETURN -1
        END

    -- Inserir o novo campeonato
    INSERT INTO Campeonato (Ano) VALUES (@Ano)
END
GO

-- Criar jogo
CREATE PROCEDURE CreateJogo @Ano INTEGER, @Casa INTEGER, @Fora INTEGER
AS
BEGIN
    -- Verificar se o ano existe
    IF NOT EXISTS (SELECT * FROM Campeonato WHERE Ano = @Ano)
        BEGIN
            RETURN -1
        END

    -- Verificar se o jogo já existe
    IF EXISTS (SELECT * FROM Jogo WHERE Ano = @Ano AND Casa = @Casa AND Fora = @Fora)
        BEGIN
            RETURN -2
        END

    -- Verificar se o campeonato já começou (JogosDisputados > 0)
    IF EXISTS (SELECT * FROM Campeonato WHERE Ano = @Ano AND JogosDisputados > 0)
        BEGIN
            RETURN -3
        END

    -- Inserir o novo jogo
    INSERT INTO Jogo (Ano, Casa, Fora) VALUES (@Ano, @Casa, @Fora)

    -- Adicionar a JogosPorDisputar do Campeonato
    UPDATE Campeonato SET JogosPorDisputar += 1 WHERE Ano = @Ano
END
GO

-- Inserir resultado
CREATE PROCEDURE InsertResultado @Ano INTEGER, @Casa INTEGER, @Fora INTEGER, @Resultado VARCHAR(MAX)
AS
BEGIN
    -- Verificar se o jogo existe
    IF NOT EXISTS (SELECT * FROM Jogo WHERE Ano = @Ano AND Casa = @Casa AND Fora = @Fora)
        BEGIN
            RETURN -1
        END

    -- Verificar se o jogo já foi disputado
    IF EXISTS (SELECT *
               FROM Jogo
               WHERE Ano = @Ano
                 AND Casa = @Casa
                 AND Fora = @Fora
                 AND ResultadoFinal != 'Por Disputar')
        BEGIN
            RETURN -2
        END

    -- Inserir o resultado em Jogo
    UPDATE Jogo SET ResultadoFinal = @Resultado WHERE Ano = @Ano AND Casa = @Casa AND Fora = @Fora

    -- Atualizar a JogosPorDisputar e JogosDisputados do Campeonato
    UPDATE Campeonato
    SET JogosPorDisputar -= 1,
        JogosDisputados += 1
    WHERE Ano = @Ano
END
GO

-- Buscar jogos por ano
CREATE PROCEDURE GetJogosByAno @Ano INTEGER
AS
BEGIN
    -- Verificar se o ano existe
    IF NOT EXISTS (SELECT * FROM Campeonato WHERE Ano = @Ano)
        BEGIN
            RETURN -1
        END

    -- Buscar os jogos
    SELECT * FROM Jogo WHERE Ano = @Ano
END