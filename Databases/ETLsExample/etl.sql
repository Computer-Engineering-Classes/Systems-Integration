-- Create trigger for the table AlunosDb, that will be called when a new row is inserted
-- into the table. The trigger will call the stored procedure sp_AlunosDb_Insert
-- to also insert the new row into the table StudentsDb.

CREATE TRIGGER tr_AlunosDb_Insert
    ON Alunos
    AFTER INSERT
    AS
BEGIN
    DECLARE @Numero INT
    DECLARE @Nome VARCHAR(100)
    DECLARE @Curso VARCHAR(MAX)

    SELECT @Numero = Numero, @Nome = Nome, @Curso = Curso
    FROM INSERTED
    
    EXEC sp_AlunosDb_Insert @Numero, @Nome, @Curso
END
GO

CREATE PROCEDURE sp_AlunosDb_Insert(@Numero INT, @Nome VARCHAR(100), @Curso VARCHAR(MAX))
AS
BEGIN
    INSERT INTO StudentsDb.Students(StudentId, StudentName, Course)
    VALUES (@Numero, @Nome, @Curso)
END
GO