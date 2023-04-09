-- noinspection SpellCheckingInspectionForFile

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

CREATE PROCEDURE CreateAluno @Nome NVARCHAR(MAX), @Endereco NVARCHAR(MAX), @Garantia MONEY
AS
INSERT INTO Aluno(Nome, Endereco, Garantia)
VALUES (@Nome, @Endereco, @Garantia);
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

CREATE PROCEDURE CreateEmprestimo @AlunoId INTEGER, @LivroId INTEGER
AS
INSERT INTO Emprestimo(AlunoId, LivroId, DataRequisicao)
VALUES (@AlunoId, @LivroId, GETDATE());
GO

CREATE PROCEDURE GetEmprestimos @AlunoId INTEGER
AS
SELECT *
FROM Emprestimo
WHERE AlunoId = @AlunoId;
GO

CREATE PROCEDURE GetEmprestimosAtrasados @AlunoId INTEGER
AS
SELECT *
FROM Emprestimo
WHERE AlunoId = @AlunoId
  AND DataEntrega IS NULL;
GO

CREATE PROCEDURE DevolverLivro @LivroId INTEGER
AS
BEGIN
    UPDATE Emprestimo
    SET DataEntrega = GETDATE()
    WHERE LivroId = @LivroId
      AND DataEntrega IS NULL;

    UPDATE Livro
    SET Estado = 0
    WHERE Id = @LivroId;
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
                            DataRequisicao DATETIME
                        );
    INSERT INTO @Emprestimo
        EXEC GetEmprestimosAtrasados @Id;

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

    -- Deleta o aluno
    DELETE
    FROM Aluno
    WHERE Id = @Id;
END