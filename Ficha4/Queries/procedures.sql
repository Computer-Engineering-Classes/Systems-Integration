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
DELETE
FROM Livro
WHERE Id = @Id;
GO
