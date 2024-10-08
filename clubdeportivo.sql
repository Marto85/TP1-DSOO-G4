DROP database if exists clubdeportivo;
CREATE database clubdeportivo;
USE clubdeportivo;

DROP TABLE IF EXISTS cliente;
CREATE TABLE cliente (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(255) NOT NULL
);

DROP TABLE IF EXISTS usuario;
CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    `password` VARCHAR(255) NOT NULL
);

INSERT INTO usuario(username, `password`) VALUES ("admin", "admin123");