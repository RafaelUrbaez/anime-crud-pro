-- SCRIPT DE BASE DE DATOS PARA EVALUACIÓN
CREATE DATABASE AnimeDB;
GO

USE AnimeDB;
GO

-- Creación de la tabla principal
CREATE TABLE Animes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo VARCHAR(100) NOT NULL,
    Episodios INT NOT NULL
);
GO

-- Datos iniciales para que el profesor vea contenido al abrir la web
INSERT INTO Animes (Titulo, Episodios) VALUES ('One Piece', 1100);
INSERT INTO Animes (Titulo, Episodios) VALUES ('Naruto Shippuden', 720);
INSERT INTO Animes (Titulo, Episodios) VALUES ('Attack on Titan', 87);
GO