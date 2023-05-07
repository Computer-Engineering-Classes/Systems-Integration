USE Livros;

CREATE PROCEDURE GetLivros @Id INTEGER
AS
    IF (@Id = 0)
        SELECT * FROM Livro;
    ELSE
        SELECT * FROM Livro WHERE Id = @Id;
GO

CREATE PROCEDURE CreateLivro @Titulo NVARCHAR(MAX), @Autor NVARCHAR(MAX), @Editor NVARCHAR(MAX)
AS
INSERT INTO Livro(Titulo, Autor, Editor, DataCompra, Estado)
VALUES (@Titulo, @Autor, @Editor, GETDATE(), 0);
GO

CREATE PROCEDURE UpdateLivro @Id INTEGER, @Estado BIT
AS
UPDATE Livro
SET Estado = @Estado
WHERE Id = @Id;
GO

CREATE PROCEDURE DeleteLivro @Id INTEGER
AS
BEGIN
    DELETE FROM Emprestimo WHERE LivroId = @Id;
    DELETE FROM Livro WHERE Id = @Id;
END
GO

CREATE PROCEDURE CreateAluno @Nome NVARCHAR(MAX), @Endereco NVARCHAR(MAX)
AS
INSERT INTO Aluno(Nome, Endereco, Garantia)
VALUES (@Nome, @Endereco, 0);
GO

CREATE PROCEDURE GetAlunos @Id INTEGER
AS
    IF (@Id = 0)
        SELECT * FROM Aluno;
    ELSE
        SELECT * FROM Aluno WHERE Id = @Id;
GO

CREATE PROCEDURE UpdateAluno @Id INTEGER, @Nome NVARCHAR(MAX), @Endereco NVARCHAR(MAX)
AS
UPDATE Aluno
SET Nome     = @Nome,
    Endereco = @Endereco
WHERE Id = @Id;
GO

CREATE PROCEDURE UpdateGarantia @Id INTEGER, @Garantia MONEY
AS
UPDATE Aluno
SET Garantia = @Garantia
WHERE Id = @Id;
GO

CREATE PROCEDURE UpdateGarantiaAluno @Id INTEGER, @Garantia MONEY
AS
UPDATE Aluno
SET Garantia += @Garantia
WHERE Id = @Id;
GO

CREATE PROCEDURE RequisitarLivro @AlunoId INTEGER, @LivroId INTEGER
AS
BEGIN
    -- Verifica se o livro está disponível
    DECLARE @Estado BIT;
    SELECT @Estado = Estado
    FROM Livro
    WHERE Id = @LivroId;
    IF (@Estado = 1)
        RETURN -1;
    -- Atualiza o estado do livro
    EXEC UpdateLivro @LivroId, 1;
    -- Atualiza a garantia do aluno (5€ por livro)
    EXEC UpdateGarantiaAluno @AlunoId, 5;
    -- Regista o empréstimo
    EXEC CreateEmprestimo @AlunoId, @LivroId;
    RETURN 0;
END
GO

CREATE PROCEDURE CreateEmprestimo @AlunoId INTEGER, @LivroId INTEGER
AS
INSERT INTO Emprestimo(AlunoId, LivroId, DataRequisicao)
VALUES (@AlunoId, @LivroId, GETDATE());
GO

CREATE PROCEDURE GetEmprestimos @AlunoId INTEGER, @LivroId INTEGER, @Atrasados BIT
AS
SELECT *
FROM Emprestimo
WHERE (@AlunoId = 0 OR AlunoId = @AlunoId)
  AND (@LivroId = 0 OR LivroId = @LivroId)
  AND (@Atrasados = 0 OR DataEntrega IS NULL);
GO

CREATE PROCEDURE DevolverLivro @LivroId INTEGER
AS
BEGIN
    DECLARE @AlunoId INTEGER;
    -- Obtém o id do aluno
    SELECT @AlunoId = AlunoId
    FROM Emprestimo
    WHERE LivroId = @LivroId
      AND DataEntrega IS NULL;
    IF (@AlunoId IS NULL)
        RETURN -1;
    -- Devolve a garantia do aluno (5€ por livro)
    EXEC UpdateGarantiaAluno @AlunoId, -5;
    -- Atualiza a data de entrega do empréstimo
    UPDATE Emprestimo
    SET DataEntrega = GETDATE()
    WHERE LivroId = @LivroId
      AND DataEntrega IS NULL;
    -- Atualiza o estado do livro
    EXEC UpdateLivro @LivroId, 0;
    RETURN 0;
END
GO

CREATE PROCEDURE DeleteAluno @Id INTEGER
AS
BEGIN
    -- Itera sobre GetEmprestimosAtrasados para devolver os livros
    DECLARE @Emprestimo TABLE
                        (
                            AlunoId        INTEGER,
                            LivroId        INTEGER,
                            DataRequisicao DATETIME2
                        );
    INSERT INTO @Emprestimo
        EXEC GetEmprestimos @Id, 0, 1;

    DECLARE @AlunoId INTEGER;
    DECLARE @LivroId INTEGER;
    DECLARE @DataRequisicao DATETIME;

    DECLARE EmprestimoCursor CURSOR FOR
        SELECT AlunoId, LivroId, DataRequisicao
        FROM @Emprestimo;

    OPEN EmprestimoCursor;
    FETCH NEXT FROM EmprestimoCursor INTO @LivroId, @DataRequisicao;

    WHILE @@FETCH_STATUS = 0
        BEGIN
            EXEC DevolverLivro @LivroId;
            FETCH NEXT FROM EmprestimoCursor INTO @AlunoId, @LivroId, @DataRequisicao;
        END;

    CLOSE EmprestimoCursor;
    DEALLOCATE EmprestimoCursor;

    -- Apaga o aluno
    DELETE
    FROM Aluno
    WHERE Id = @Id;
END