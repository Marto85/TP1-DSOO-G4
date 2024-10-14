DROP DATABASE IF EXISTS clubdeportivo;
CREATE DATABASE clubdeportivo;


CREATE TABLE Cliente (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    FechaIngreso DATE NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    DNI INT NOT NULL,
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    PagoVencido BOOLEAN DEFAULT FALSE,
    Activo BOOLEAN NOT NULL,
    EsApto BOOLEAN NOT NULL
);

CREATE TABLE socio (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    DNI INT NOT NULL UNIQUE,
    Direccion VARCHAR(100),
    Telefono VARCHAR(20),
    Email VARCHAR(100),
    FechaIngreso DATETIME DEFAULT CURRENT_TIMESTAMP,
    Activo BOOLEAN DEFAULT TRUE,
    EsApto BOOLEAN NOT NULL
);

CREATE TABLE Pago (
    Id CHAR(36) PRIMARY KEY,  -- Utilizamos un GUID para el identificador único de cada pago
    Socio_Id INT NOT NULL,
    Monto DECIMAL(10, 2) NOT NULL,
    FechaPago DATE NOT NULL,
    ProximoVencimiento DATE NOT NULL,
    FrecuenciaPago ENUM('Mensual', 'Trimestral', 'Semestral', 'Anual') NOT NULL,
    FOREIGN KEY (Socio_Id) REFERENCES Socio(Id) ON DELETE CASCADE
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
