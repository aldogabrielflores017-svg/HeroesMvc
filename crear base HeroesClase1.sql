IF DB_ID('HeroesClase1') IS NULL
    CREATE DATABASE HeroesClase1;
GO

USE HeroesClase1;
GO

IF OBJECT_ID('dbo.Heroes') IS NULL
BEGIN
    CREATE TABLE dbo.Heroes
    (
        Id     INT IDENTITY(1,1) PRIMARY KEY,
        Nombre NVARCHAR(100) NOT NULL
    );

    INSERT INTO dbo.Heroes (Nombre)
    VALUES (N'Superman'), (N'Batman'), (N'Flash');
END
GO

SELECT Id, Nombre FROM dbo.Heroes;
