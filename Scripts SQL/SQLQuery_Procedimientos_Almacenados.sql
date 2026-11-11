USE OnlyMotosDB;
GO

--indicamos a SQL Server que vamos a crear un procedimiento almacenado (PROCEDURE)
CREATE PROCEDURE sp_ValidarUsuario
    @usuario VARCHAR(50), --@usuario y @password: Son los parámetros de entrada 
    @password VARCHAR(100) --que la base de datos va a recibir desde el formulario
AS
BEGIN --Delimita el bloque de código que se va a ejecutar dentro del procedimiento.

    SELECT COUNT(*) --Cuenta cuántos registros coinciden con ese usuario, contraseña y estado activo. Si devuelve 1, el usuario existe y las credenciales son correctas; si devuelve 0, no existe o son incorrectas.
    FROM Usuario 
    WHERE usuario = @usuario AND password = @password AND estado = 'Activo';

END;
GO

--lo Tuve que cambiar porque quiero saber el rol del que ingresa
ALTER PROCEDURE sp_ValidarUsuario
    @usuario VARCHAR(50),
    @password VARCHAR(100)
AS
BEGIN
    SELECT U.id_usuario, U.nombre, U.apellido, T.nombre_tipo 
    FROM Usuario U
    INNER JOIN Tipo_Usuario T ON U.id_tipo = T.id_tipo
    WHERE U.usuario = @usuario AND U.password = @password AND U.estado = 'Activo';
END;
GO

CREATE PROCEDURE sp_ListarUsuarios
AS
BEGIN
    SELECT U.id_usuario, U.dni, U.usuario, U.nombre, U.apellido, U.email, U.telefono, U.estado, T.nombre_tipo 
    FROM Usuario U
    INNER JOIN Tipo_Usuario T ON U.id_tipo = T.id_tipo;
END;
GO

ALTER PROCEDURE sp_ListarUsuarios
AS
BEGIN
    SELECT U.id_usuario, U.dni, U.usuario, U.nombre, U.apellido, U.email, U.telefono, U.estado, T.nombre_tipo 
    FROM Usuario U
    INNER JOIN Tipo_Usuario T ON U.id_tipo = T.id_tipo
    WHERE U.estado = 'Activo';
END;
GO

CREATE PROCEDURE sp_InsertarUsuario
    @id_tipo INT,
    @dni VARCHAR(20),
    @usuario VARCHAR(50),
    @password VARCHAR(100),
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @email VARCHAR(100),
    @telefono VARCHAR(30)
AS
BEGIN
    INSERT INTO Usuario (id_tipo, dni, usuario, password, nombre, apellido, email, telefono, estado)
    VALUES (@id_tipo, @dni, @usuario, @password, @nombre, @apellido, @email, @telefono, 'Activo');
END;
GO

CREATE PROCEDURE sp_ListarTiposUsuario
AS
BEGIN
    SELECT id_tipo, nombre_tipo 
    FROM Tipo_Usuario;
END;
GO

EXEC sp_ListarTiposUsuario;
GO

CREATE PROCEDURE sp_DarBajaUsuario
    @id_usuario INT
AS
BEGIN
    UPDATE Usuario 
    SET estado = 'Inactivo' 
    WHERE id_usuario = @id_usuario;
END;
GO

CREATE PROCEDURE sp_BuscarUsuarioPorDni
    @dni VARCHAR(20)
AS
BEGIN
    SELECT U.id_usuario, U.dni, U.usuario, U.nombre, U.apellido, U.email, U.telefono, U.estado, T.nombre_tipo 
    FROM Usuario U
    INNER JOIN Tipo_Usuario T ON U.id_tipo = T.id_tipo
    WHERE U.dni = @dni;
END;
GO

CREATE PROCEDURE sp_ActualizarCampoUsuario
    @id_usuario INT,
    @campo VARCHAR(50),
    @valor VARCHAR(255)
AS
BEGIN
    -- Usamos SQL dinámico de forma controlada solo para columnas permitidas
    IF @campo = 'nombre'
        UPDATE Usuario SET nombre = @valor WHERE id_usuario = @id_usuario;
    ELSE IF @campo = 'apellido'
        UPDATE Usuario SET apellido = @valor WHERE id_usuario = @id_usuario;
    ELSE IF @campo = 'email'
        UPDATE Usuario SET email = @valor WHERE id_usuario = @id_usuario;
    ELSE IF @campo = 'telefono'
        UPDATE Usuario SET telefono = @valor WHERE id_usuario = @id_usuario;
END;
GO

CREATE PROCEDURE sp_ListarUsuariosInactivos
AS
BEGIN
    SELECT U.id_usuario, U.dni, U.usuario, U.nombre, U.apellido, U.email, U.telefono, U.estado, T.nombre_tipo 
    FROM Usuario U
    INNER JOIN Tipo_Usuario T ON U.id_tipo = T.id_tipo
    WHERE U.estado = 'Inactivo';
END;
GO

CREATE PROCEDURE sp_ReactivarUsuario
    @id_usuario INT
AS
BEGIN
    UPDATE Usuario 
    SET estado = 'Activo' 
    WHERE id_usuario = @id_usuario;
END;
GO

--CLIENTE
CREATE PROCEDURE sp_ListarClientes
AS
BEGIN
    SELECT id_cliente, nombre, apellido, dni, email, telefono, estado 
    FROM Cliente 
    WHERE estado = 'Activo'; 
END;
GO

CREATE PROCEDURE sp_ListarClientesInactivos
AS
BEGIN
    SELECT id_cliente, nombre, apellido, dni, email, telefono, estado 
    FROM Cliente 
    WHERE estado = 'Inactivo';
END;
GO

CREATE PROCEDURE sp_InsertarCliente
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @dni VARCHAR(20),
    @email VARCHAR(100),
    @telefono VARCHAR(30)
AS
BEGIN
    INSERT INTO Cliente (nombre, apellido, dni, email, telefono)
    VALUES (@nombre, @apellido, @dni, @email, @telefono);
END;
GO

CREATE PROCEDURE sp_BuscarClientePorDni
    @dni VARCHAR(20)
AS
BEGIN
    SELECT id_cliente, nombre, apellido, dni, email, telefono, estado 
    FROM Cliente 
    WHERE dni LIKE '%' + @dni + '%'; -- Usamos LIKE para buscar coincidencias parciales o exactas
END;

CREATE PROCEDURE sp_DarDeBajaCliente
    @id_cliente INT
AS
BEGIN
    UPDATE Cliente 
    SET estado = 'Inactivo' 
    WHERE id_cliente = @id_cliente;
END;
GO

CREATE PROCEDURE sp_ActualizarCliente
    @id_cliente INT,
    @nombre VARCHAR(50),
    @apellido VARCHAR(50),
    @dni VARCHAR(20),
    @email VARCHAR(100),
    @telefono VARCHAR(30)
AS
BEGIN
    UPDATE Cliente 
    SET nombre = @nombre,
        apellido = @apellido,
        dni = @dni,
        email = @email,
        telefono = @telefono
    WHERE id_cliente = @id_cliente;
END;
GO


CREATE PROCEDURE sp_ReactivarCliente
    @id_cliente INT
AS
BEGIN
    UPDATE Cliente
    SET estado = 'Activo' 
    WHERE id_cliente = @id_cliente;
END;
GO

--PRODUCTO
CREATE PROCEDURE sp_ListarMotos
AS
BEGIN
    SELECT 
        m.id_moto,
        ma.nombre AS marca,
        c.tamaño AS cc,
        m.modelo,
        m.precio,
        m.stock,
        m.stock_min,
        m.año,
        m.imagen_path
    FROM Moto m
    INNER JOIN Marca ma ON m.id_marca = ma.id_marca
    INNER JOIN CC c ON m.id_cc = c.id_cc
    WHERE m.eliminado = 0;
END;
GO

CREATE PROCEDURE sp_InsertarMoto
    @id_marca INT,
    @id_cc INT,
    @modelo VARCHAR(150),
    @precio DECIMAL(10,2),
    @stock INT,
    @stock_min INT,
    @imagen_path VARCHAR(255),
    @año VARCHAR(10)
AS
BEGIN
    INSERT INTO Moto (id_marca, id_cc, modelo, precio, stock, stock_min, imagen_path, año)
    VALUES (@id_marca, @id_cc, @modelo, @precio, @stock, @stock_min, @imagen_path, @año);
END;
GO

CREATE PROCEDURE sp_ListarMarcasParaCombo
AS
BEGIN
    SELECT id_marca, nombre 
    FROM Marca 
    WHERE eliminado = 0;
END;
GO

CREATE PROCEDURE sp_ListarCcParaCombo
AS
BEGIN
    SELECT id_cc, tamaño 
    FROM CC 
    WHERE eliminado = 0;
END;
GO

CREATE PROCEDURE sp_FiltrarMotosPorModelo
    @modelo VARCHAR(150)
AS
BEGIN
    SELECT 
        m.id_moto,
        ma.nombre AS marca,
        c.tamaño AS cc,
        m.modelo,
        m.precio,
        m.stock,
        m.stock_min,
        m.año,
        m.imagen_path
    FROM Moto m
    INNER JOIN Marca ma ON m.id_marca = ma.id_marca
    INNER JOIN CC c ON m.id_cc = c.id_cc
    WHERE m.eliminado = 0 
      AND m.modelo LIKE '%' + @modelo + '%';
END;
GO

CREATE PROCEDURE sp_EliminarMoto
    @id_moto INT
AS
BEGIN
    UPDATE Moto 
    SET eliminado = 1 
    WHERE id_moto = @id_moto;
END;
GO

CREATE PROCEDURE sp_ActualizarStockMoto
    @id_moto INT,
    @stock INT
AS
BEGIN
    UPDATE Moto 
    SET stock = @stock 
    WHERE id_moto = @id_moto;
END;
GO

--VENTADS
CREATE PROCEDURE sp_ListarTiposFactura
AS
BEGIN
    SELECT id_tipo_factura, tipo 
    FROM Tipo_Factura;
END;
GO


CREATE PROCEDURE sp_ListarClientesParaCombo
AS
BEGIN
    SELECT id_cliente, (nombre + ' ' + apellido) AS nombre_completo
    FROM Cliente
    WHERE estado = 'Activo';
END;
GO

ALTER PROCEDURE sp_ListarClientesParaCombo --tuve que cambiarlo por el hecho de si hay dos personas con el mismo nombre
AS
BEGIN
    SELECT id_cliente, (nombre + ' ' + apellido + ' - ' + dni) AS nombre_completo
    FROM Cliente
    WHERE estado = 'Activo';
END;
GO


CREATE PROCEDURE sp_ListarMotosDisponibles
AS
BEGIN
    SELECT id_moto, modelo, precio, stock
    FROM Moto
    WHERE eliminado = 0 AND stock > 0;
END;
GO


CREATE PROCEDURE sp_ObtenerMotoPorId
    @id_moto INT
AS
BEGIN
    SELECT id_moto, modelo, precio, stock
    FROM Moto
    WHERE id_moto = @id_moto;
END;
GO

CREATE PROCEDURE sp_DescontarStockDetalle
    @id_moto INT,
    @cantidad INT,
    @resultado INT OUTPUT
AS
BEGIN

    IF (SELECT stock FROM Moto WHERE id_moto = @id_moto) >= @cantidad
    BEGIN
        UPDATE Moto 
        SET stock = stock - @cantidad 
        WHERE id_moto = @id_moto;
        
        SET @resultado = 1; 
    END
    ELSE
    BEGIN
        SET @resultado = 0;
    END
END;
GO

CREATE PROCEDURE sp_DevolverStockMoto
    @id_moto INT,
    @cantidad INT
AS
BEGIN
    UPDATE Moto 
    SET stock = stock + @cantidad 
    WHERE id_moto = @id_moto;
END;
GO

CREATE PROCEDURE sp_RegistrarCabeceraVenta
    @id_usuario INT,
    @id_cliente INT,
    @id_tipoFactura INT,
    @fecha DATETIME,
    @total DECIMAL(18,2),
    @id_venta_generado INT OUTPUT
AS
BEGIN
    INSERT INTO Cabecera_Venta (id_usuario, id_cliente, id_tipo_factura, fecha, total, eliminado)
    VALUES (@id_usuario, @id_cliente, @id_tipoFactura, @fecha, @total, 0);

    SET @id_venta_generado = SCOPE_IDENTITY();
END;
GO

CREATE PROCEDURE sp_RegistrarDetalleVenta
    @id_venta INT,
    @id_moto INT,
    @cantidad INT,
    @sub_total DECIMAL(18,2)
AS
BEGIN
    INSERT INTO Detalle_Venta (id_venta, id_moto, cantidad, sub_total, eliminado)
    VALUES (@id_venta, @id_moto, @cantidad, @sub_total, 0);
END;
GO

CREATE PROCEDURE sp_ObtenerUltimoIdVenta
AS
BEGIN
    SELECT ISNULL(MAX(id_venta), 0) AS ultimo_id 
    FROM Cabecera_Venta;
END
GO

CREATE PROCEDURE sp_ListarVentas
    @FechaDesde DATE = NULL,
    @FechaHasta DATE = NULL,
    @DniCliente VARCHAR(20) = NULL
AS
BEGIN
    SELECT 
        cv.id_venta,
        u.nombre + ' ' + u.apellido AS [Usuario],
        cv.fecha,
        (c.nombre + ' ' + c.apellido + ' - ' + c.dni) AS [Cliente],
        tf.tipo AS [Tipo de Comprobante],
        cv.total
    FROM Cabecera_Venta cv
    INNER JOIN Usuario u ON cv.id_usuario = u.id_usuario
    INNER JOIN Cliente c ON cv.id_cliente = c.id_cliente
    INNER JOIN Tipo_Factura tf ON cv.id_tipo_factura = tf.id_tipo_factura
    WHERE (@FechaDesde IS NULL OR cv.fecha >= @FechaDesde)
      AND (@FechaHasta IS NULL OR cv.fecha <= DATEADD(day, 1, @FechaHasta))
      AND (@DniCliente IS NULL OR c.dni LIKE '%' + @DniCliente + '%')
      AND cv.eliminado = 0
    ORDER BY cv.id_venta DESC;
END
GO

CREATE PROCEDURE sp_ListarDetalleVentaPorId
    @IdVenta INT
AS
BEGIN
    SELECT 
        m.modelo ,
        dv.sub_total/dv.cantidad AS [Precio Unitario],
        dv.cantidad,
        dv.sub_total AS [Subtotal]
    FROM Detalle_Venta dv
    INNER JOIN Moto m ON dv.id_moto = m.id_moto 
    WHERE dv.id_venta = @IdVenta;
END
GO

CREATE PROCEDURE sp_AnularVenta
    @IdVenta INT
AS
BEGIN
    UPDATE Cabecera_Venta
    SET eliminado = 1
    WHERE id_venta = @IdVenta;
END
GO

USE master;
GO

CREATE PROCEDURE sp_RealizarBackup
    @RutaArchivo VARCHAR(500)
AS
BEGIN
    BACKUP DATABASE [OnlyMotosDB] 
    TO DISK = @RutaArchivo 
    WITH FORMAT, INIT, 
    NAME = 'Respaldo OnlyMotos';
END
GO

USE OnlyMotosDB;
GO

USE master;
GO

CREATE PROCEDURE sp_RestaurarBackup
    @RutaArchivo VARCHAR(500)
AS
BEGIN
    -- Forzar la desconexión de otros usuarios para evitar conflictos, luego hacemos el restore y por ultimo volvemos a permitir multiples conecciones
    ALTER DATABASE [OnlyMotosDB] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    
    RESTORE DATABASE [OnlyMotosDB] 
    FROM DISK = @RutaArchivo 
    WITH REPLACE;

    ALTER DATABASE [OnlyMotosDB] SET MULTI_USER;
END
GO

USE OnlyMotosDB;
GO

CREATE PROCEDURE sp_RegistrarRestore
    @IdUsuario INT
AS
BEGIN
    INSERT INTO Auditoria_Restauraciones(id_usuario) VALUES 
    (@IdUsuario);
END
GO

CREATE PROCEDURE sp_Reporte_VentasPorUsuario
    @FechaInicio DATE,
    @FechaFin DATE
AS
BEGIN
    SELECT 

        u.nombre + ' ' + u.apellido + ' - ' + u.dni AS Usuario,
        COUNT(c.id_venta) AS CantidadVentas,
        SUM(c.total) AS TotalVendido

        FROM Cabecera_Venta c
        INNER JOIN Usuario u ON c.id_usuario = u.id_usuario
        WHERE c.eliminado = 0 AND c.fecha BETWEEN @FechaInicio AND @FechaFin
        GROUP BY u.nombre, u.apellido, u.dni;

    END
GO

CREATE PROCEDURE sp_MotosStockCritico
AS
BEGIN
    SELECT 
        modelo, 
        stock, 
        stock_min
    FROM Moto
    WHERE stock <= stock_min AND eliminado = 0;
END
GO

CREATE PROCEDURE sp_ActualizarMoto
    @id_moto INT,
    @id_marca INT,
    @modelo VARCHAR(100),
    @id_cc INT,
    @precio DECIMAL(18,2),
    @anio INT,
    @imagen VARCHAR(MAX)
AS
BEGIN
    UPDATE Moto
    SET id_marca = @id_marca,
        modelo = @modelo,
        id_cc = @id_cc,
        precio = @precio,
        año = @anio,
        imagen_path = @imagen
    WHERE id_moto = @id_moto AND eliminado = 0;
END
GO


CREATE PROCEDURE sp_Reporte_VentasPorRango
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SELECT 
        c.id_venta AS 'Numero de Venta',
        c.fecha,
        c.total
    FROM Cabecera_Venta c
    WHERE c.eliminado = 0 
      AND c.fecha BETWEEN @FechaInicio AND @FechaFin;
END
GO

CREATE PROCEDURE sp_Reporte_ComprasPorRango
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SELECT 
        m.id_moto,
        m.modelo,
        m.precio,
        m.stock,
        m.fecha
    FROM Moto m
    WHERE m.fecha BETWEEN @FechaInicio AND @FechaFin;
END
GO

CREATE PROCEDURE sp_Reporte_VentasPorTiempo
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SELECT 
        CAST(c.fecha AS DATE) AS FechaVenta,
        COUNT(c.id_venta) AS CantidadVentas,
        SUM(c.total) AS TotalDinero
    FROM Cabecera_Venta c
    WHERE c.eliminado = 0 AND c.fecha BETWEEN @FechaInicio AND @FechaFin
    GROUP BY CAST(c.fecha AS DATE)
    ORDER BY CAST(c.fecha AS DATE) ASC;
END
GO

CREATE PROCEDURE sp_Reporte_VentasPorUsuarioYTiempo
    @FechaInicio DATETIME,
    @FechaFin DATETIME,
    @IdUsuario INT
AS
BEGIN
    SELECT 
        CAST(c.fecha AS DATE) AS FechaVenta,
        COUNT(c.id_venta) AS CantidadVentas,
        SUM(c.total) AS TotalDinero
    FROM Cabecera_Venta c
    WHERE c.eliminado = 0 AND c.id_usuario = @IdUsuariO AND c.fecha BETWEEN @FechaInicio AND @FechaFin
    GROUP BY CAST(c.fecha AS DATE)
    ORDER BY CAST(c.fecha AS DATE) ASC;
END
GO

CREATE PROCEDURE sp_Reporte_RestauracionesPorTiempo
    @FechaInicio DATETIME,
    @FechaFin DATETIME
AS
BEGIN
    SELECT 
        CAST(a.fecha AS DATE) AS FechaRestauracion,
        COUNT(a.id_auditoria) AS CantidadRestauraciones
    FROM Auditoria_Restauraciones a
    WHERE a.fecha BETWEEN @FechaInicio AND @FechaFin
    GROUP BY CAST(a.fecha AS DATE)
    ORDER BY CAST(a.fecha AS DATE) ASC;
END
GO