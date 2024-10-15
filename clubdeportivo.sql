DROP DATABASE IF EXISTS clubdeportivo;
CREATE DATABASE clubdeportivo;
USE clubdeportivo;

CREATE TABLE Cliente (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FechaIngreso DATE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    DNI INT NOT NULL,
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    EsSocio BOOLEAN NOT NULL,
    EsApto BOOLEAN NOT NULL
);

CREATE TABLE Tipo_de_pago (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);


CREATE TABLE Pago (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cliente_Id INT NOT NULL,
    Monto DECIMAL(10, 2) NOT NULL,
    FechaPago DATE NOT NULL,
    ProximoVencimiento DATE NOT NULL,
	Id_tipo_de_pago INT NOT NULL,
    FOREIGN KEY (Cliente_Id) REFERENCES Cliente(Id) ON DELETE CASCADE,
	FOREIGN KEY (Id_tipo_de_pago) REFERENCES Tipo_de_pago(Id) ON DELETE CASCADE
);


CREATE TABLE Actividad (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Descripcion TEXT,
    PrecioNoSocio DECIMAL(10, 2) NOT NULL,
    Horario VARCHAR(50),
    FechaVencimiento DATETIME NOT NULL,
    CuposDisponibles INT NOT NULL,
    Profesor VARCHAR(100)
);


CREATE TABLE Actividad_Cliente (
    IdCliente INT NOT NULL,
    IdActividad INT NOT NULL,
    EsSocio BOOLEAN NOT NULL, -- Agregoo esto para diferenciar si la inscripción es de un socio o de un cliente y asi validar la restriccion de 3 actividades para socios
    PRIMARY KEY (IdCliente, IdActividad),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(Id) ON DELETE CASCADE,
    FOREIGN KEY (IdActividad) REFERENCES Actividad(Id) ON DELETE CASCADE
);


CREATE TABLE Pago_Actividad (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Cliente_id INT NOT NULL,
    Actividad_id INT NOT NULL,
    Monto DECIMAL(10, 2) NOT NULL,
    FechaPago DATE NOT NULL,
    ProximoVencimiento DATE NOT NULL,
    FOREIGN KEY (Cliente_id) REFERENCES Cliente(Id) ON DELETE CASCADE,
    FOREIGN KEY (Actividad_id) REFERENCES Actividad(Id) ON DELETE CASCADE
);

CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    `password` VARCHAR(255) NOT NULL
);

INSERT INTO usuario(username, `password`) VALUES ("admin", "admin123");
