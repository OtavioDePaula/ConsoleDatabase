DROP DATABASE IF EXISTS db_exemplo;
CREATE DATABASE IF NOT EXISTS db_exemplo;
USE db_exemplo;

CREATE TABLE IF NOT EXISTS tb_usuario(
	usuarioId INT PRIMARY KEY AUTO_INCREMENT,
	usuarioNome VARCHAR(50) NOT NULL,
	usuarioCargo VARCHAR(50) NOT NULL,
	usuarioDataNasc DATE
);

INSERT INTO tb_usuario VALUES 
(
	default,
	'Bob',
	'Monstorrista',
	'1960-04-13'
),(
	default,
	'Maria',
	'171',
	'1980-09-29'
);

SELECT * FROM tb_usuario;