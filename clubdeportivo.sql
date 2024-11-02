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
    Imagen_Perfil VARCHAR(255),
    AbonoMensualSocios DECIMAL(10, 2)
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
    formaPago VARCHAR(50),
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
    formaPago VARCHAR(50) NOT NULL,
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
('Yoga', 'Clase de yoga para todos los niveles', 5000, 'Lunes 18:00', 10, 'Ana López'),
('Pilates', 'Pilates intermedio', 6000, 'Martes 17:00', 8, 'Carlos Pérez'),
('Zumba', 'Clase de zumba energizante', 4000, 'Miércoles 19:00', 12, 'María Gómez'),
('Crossfit', 'Entrenamiento de alta intensidad', 7000, 'Jueves 18:00', 5, 'Juan Martínez'),
('Natacion', 'Clase de natación', 8000, 'Viernes 17:00', 6, 'Lucía Fernández'),
('Futbol', 'Escuela de futbol', 9000, 'Sábado 16:00', 20, 'Pedro González');

INSERT INTO Tipo_de_pago (Nombre) VALUES
('Semanal'),
('Quincenal'),
('Mensual'),
('Trimestral'),
('Semestral'),
('Anual');


# Agrego unas querys para insertar clientes y pagos, de modo de verificar que funciona

INSERT INTO Cliente (FechaIngreso, Nombre, Apellido, DNI, Direccion, Telefono, Email, EsSocio, EsApto, Imagen_Perfil, AbonoMensualSocios)
VALUES 
('2024-08-01', 'Juan', 'Perez', 10000001, 'Direccion 1', '111-1111', 'juan@example.com', TRUE, TRUE, 'imagen1.jpg', 150.00),  -- Socio
('2024-09-01', 'Ana', 'Gomez', 10000002, 'Direccion 2', '222-2222', 'ana@example.com', TRUE, TRUE, 'imagen2.jpg', 150.00),  -- Socio
('2024-08-01', 'Pedro', 'Sanchez', 10000003, 'Direccion 3', '333-3333', 'pedro@example.com', FALSE, TRUE, 'imagen3.jpg', NULL), -- No socio
('2024-09-01', 'Laura', 'Garcia', 10000004, 'Direccion 4', '444-4444', 'laura@example.com', FALSE, TRUE, 'imagen4.jpg', NULL);  -- No socio


-- Pagos para socios en la tabla Pago
INSERT INTO Pago (id, Cliente_Id, Monto, FechaPago, ProximoVencimiento, Id_tipo_de_pago, formaPago)
VALUES
(1, 1, 150.00, '2024-08-01', '2024-09-01', 3, 'Tarjeta de Credito'), -- Vencido
(2, 2, 150.00, '2024-09-01', '2024-12-01', 3, 'Efectivo'); -- Vigente

-- Pagos para no socios en la tabla Pago_Actividad
INSERT INTO Pago_Actividad (Cliente_id, Actividad_id, Monto, FechaPago, ProximoVencimiento, formaPago)
VALUES
(3, 1, 5000.00, '2024-08-01', '2024-09-01', 'Efectivo'), -- Vencido, para la actividad "Yoga"
(4, 2, 6000.00, '2024-09-01', '2024-12-01', 'Tarjeta de Credito'); -- Vigente, para la actividad "Pilates"



*/