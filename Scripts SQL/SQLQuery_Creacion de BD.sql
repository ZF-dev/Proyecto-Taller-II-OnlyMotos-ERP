CREATE DATABASE OnlyMotosDB;
GO

USE OnlyMotosDB;
GO

CREATE TABLE Tipo_Usuario (
    id_tipo INT IDENTITY,
    nombre_tipo VARCHAR(50) NOT NULL,

    CONSTRAINT PK_Tipo_Usuario PRIMARY KEY (id_tipo)
);
GO

CREATE TABLE Usuario (
    id_usuario INT IDENTITY,
    id_tipo INT NOT NULL,
    dni VARCHAR(20) NOT NULL UNIQUE,
    usuario VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(100) NOT NULL UNIQUE,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(30) NULL,
    estado VARCHAR(20) DEFAULT 'Activo' NOT NULL,

    CONSTRAINT PK_Usuario PRIMARY KEY (id_usuario),
    CONSTRAINT FK_Usuarios_Tipos FOREIGN KEY (id_tipo) REFERENCES Tipo_Usuario(id_tipo)
);
GO

INSERT INTO Tipo_Usuario (nombre_tipo) VALUES ('Administrador');
INSERT INTO Tipo_Usuario (nombre_tipo) VALUES ('Supervisor');
INSERT INTO Tipo_Usuario (nombre_tipo) VALUES ('Vendedor');
GO

INSERT INTO Usuario (nombre, apellido, dni, usuario, password, id_tipo, email, telefono, estado)
VALUES ('Federico', 'Zini','35123456', 'admin', 'admin1234', 1, 'admin@onlymotos.com', '3794001122', 'Activo');

INSERT INTO Usuario (nombre, apellido, dni, usuario, password, id_tipo, email, telefono, estado)
VALUES ('Pepe', 'Botellas','11111111', 'supervisor', 'supervisor1234', 2, 'supervisor@onlymotos.com', '3794001122', 'Activo');

INSERT INTO Usuario (nombre, apellido, dni, usuario, password, id_tipo, email, telefono, estado)
VALUES ('Mago', 'Brujo','22222222', 'vendedor', 'vendedor1234', 3, 'vendedor@onlymotos.com', '3794001122', 'Activo');
GO

SELECT nombre_tipo
FROM Tipo_Usuario;
GO

SELECT nombre, apellido, dni, usuario, password, id_tipo, email, telefono, estado
FROM Usuario;
GO

CREATE TABLE Tipo_Factura(

    id_tipo_factura INT IDENTITY,
    tipo CHAR UNIQUE NOT NULL,
    estado VARCHAR(20) NOT NULL DEFAULT 'Activo',

    CONSTRAINT PK_Tipo_Factura PRIMARY KEY (id_tipo_factura)
);
GO

INSERT INTO Tipo_Factura (tipo) VALUES 
('A'),
('B'),
('C'),
('D');
GO

CREATE TABLE Cliente(

    id_cliente INT IDENTITY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    dni VARCHAR(20) NOT NULL UNIQUE,
    email VARCHAR(100) NOT NULL UNIQUE,
    telefono VARCHAR(30) NOT NULL,
    estado VARCHAR(20) DEFAULT 'Activo' NOT NULL,

    CONSTRAINT PK_Cliente PRIMARY KEY (id_cliente),
);
GO

CREATE TABLE Marca(
    id_marca INT IDENTITY,
    nombre VARCHAR(50) NOT NULL,
    eliminado BIT DEFAULT 0 NOT NULL,
    
    CONSTRAINT PK_Marca PRIMARY KEY (id_marca),
);
GO

INSERT INTO Marca (nombre) VALUES 
('Yamaha'),
('Honda'),
('Bajaj'),
('Motomel'),
('Hero');
GO

CREATE TABLE CC(
    id_cc INT IDENTITY,
    tamaño VARCHAR(50) NOT NULL,
    eliminado BIT DEFAULT 0 NOT NULL,
    
    CONSTRAINT PK_CC PRIMARY KEY (id_cc),
);
GO

INSERT INTO CC (tamaño) VALUES 
('110 cc'),
('125 cc'),
('150 cc'),
('200 cc'),
('250 cc'),
('300 cc'),
('400 cc'),
('500 cc'),
('600 cc'),
('750 cc'),
('1000 cc');
GO

CREATE TABLE Moto(
    id_moto INT IDENTITY,
    id_marca INT NOT NULL,
    id_cc INT NOT NULL,
    modelo VARCHAR(150) NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    stock INT NOT NULL,
    stock_min INT NOT NULL,
    imagen_path VARCHAR(255) NULL,
    año VARCHAR(10) NOT NULL,
    fecha DATETIME DEFAULT GETDATE() NOT NULL,
    eliminado BIT DEFAULT 0 NOT NULL,
    
    CONSTRAINT PK_Moto PRIMARY KEY (id_moto),
    CONSTRAINT FK_Moto_Marca FOREIGN KEY (id_marca) REFERENCES Marca(id_marca),
    CONSTRAINT FK_Moto_CC FOREIGN KEY (id_cc) REFERENCES CC(id_cc)
);
GO

CREATE TABLE Cabecera_Venta(
    id_venta INT IDENTITY,
    id_usuario INT NOT NULL,
    id_cliente INT NOT NULL,
    id_tipo_factura INT NOT NULL,
    fecha DATETIME NOT NULL,
    total DECIMAL(18,2) NOT NULL,
    eliminado BIT DEFAULT 0 NOT NULL,
    
    CONSTRAINT PK_Cabecera_Venta PRIMARY KEY (id_venta),
    CONSTRAINT FK_Cabecera_Venta_Usuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
    CONSTRAINT FK_Cabecera_Venta_Cliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente),
    CONSTRAINT FK_Cabecera_Venta_Tipo_Factura FOREIGN KEY (id_tipo_factura) REFERENCES Tipo_Factura(id_tipo_factura)
);
GO

CREATE TABLE Detalle_Venta(
    id_detalle INT IDENTITY,
    id_venta INT NOT NULL,
    id_moto INT NOT NULL,
    cantidad INT NOT NULL,
    sub_total DECIMAL(18,2) NOT NULL,
    eliminado BIT DEFAULT 0 NOT NULL,
    
    CONSTRAINT PK_Detalle_Venta PRIMARY KEY (id_detalle),
    CONSTRAINT FK_Detalle_Venta_Cabecera FOREIGN KEY (id_venta) REFERENCES Cabecera_Venta(id_venta),
    CONSTRAINT FK_Detalle_Venta_Moto FOREIGN KEY (id_moto) REFERENCES Moto(id_moto)
);
GO

CREATE TABLE Auditoria_Restauraciones(
    id_auditoria INT IDENTITY,
    id_usuario INT NOT NULL,
    fecha DATETIME DEFAULT GETDATE() NOT NULL,

    CONSTRAINT PK_Auditoria_Restauraciones PRIMARY KEY (id_auditoria),
    CONSTRAINT FK_Auditoria_Restauraciones FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);
GO
