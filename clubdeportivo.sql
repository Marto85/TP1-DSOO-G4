/*

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
    EsApto BOOLEAN NOT NULL,
    Imagen_Perfil VARCHAR(255)
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

INSERT INTO Actividad (Nombre, Descripcion, PrecioNoSocio, Horario, CuposDisponibles, Profesor)
VALUES
('Yoga', 'Clase de yoga para todos los niveles', 500, 'Lunes 18:00', 10, 'Ana López'),
('Pilates', 'Pilates intermedio', 600, 'Martes 17:00', 8, 'Carlos Pérez'),
('Zumba', 'Clase de zumba energizante', 400, 'Miércoles 19:00', 12, 'María Gómez'),
('Crossfit', 'Entrenamiento de alta intensidad', 700, 'Jueves 18:00', 5, 'Juan Martínez'),
('Natacion', 'Clase de natación', 800, 'Viernes 17:00', 6, 'Lucía Fernández'),
('Futbol', 'Partido de fútbol amistoso', 300, 'Sábado 16:00', 20, 'Pedro González');

*/