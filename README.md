# OnlyMotos ERP — Sistema de Gestión, Auditoría y Reportes

![Estado](https://img.shields.io/badge/Estado-Completado-brightgreen)
![Lenguaje](https://img.shields.io/badge/Lenguaje-VB.NET-blue)
![Base%20de%20Datos](https://img.shields.io/badge/BD-SQL%20Server-red)
![Arquitectura](https://img.shields.io/badge/Arquitectura-3--Layers-orange)

Proyecto de **Taller de Programación II** UNNE, desarrollado en VB.NET con Windows Forms y SQL Server.
---

## Descripción del Sistema

**OnlyMotos ERP** es una solución de escritorio orientada a la gestión comercial, control de inventario y monitoreo analítico para concesionarias de motocicletas. Diseñado para optimizar los procesos de facturación y administración, cuenta con un esquema de **seguridad basada en roles (RBAC)**, un módulo interactivo de reportes y auditoría automatizada de restauraciones.

### Arquitectura y Funcionamiento Técnico
* **Diseño en 3 Capas:** Desacoplamiento total entre la **Capa de Presentación** (Windows Forms), **Capa de Negocio** (reglas comerciales, validaciones de margen del 15% y utilidades) y **Capa de Datos** (ADO.NET con llamadas a Procedimientos Almacenados en SQL Server).
* **Interfaz Multiventana (MDI):** Entorno gráfico ágil con paleta de colores en azul marino y blanco, optimizado para trabajar con múltiples formularios de forma simultánea.
* **Control de Acceso por Rol:**
  * **Administrador:** Gestión de usuarios (CRUD), auditorías y operaciones críticas de sistema (**Backup y Restore**).
  * **Supervisor:** Administración del catálogo de productos, control de precios e inventario.
  * **Vendedor:** Alta de clientes, consulta de productos y ejecución de ventas.
* **Stock Dual y Facturación:** Control en tiempo real entre la cantidad de unidades cargadas y el umbral de **stock mínimo**, integrado a una pantalla de ventas con búsqueda predictiva y cálculo automático de totales.
* **Dashboards Estadísticos & Auditoría:** Visualización gráfica (`DataVisualization.Charting`) de tendencias temporales y balances de inversión vs. ventas. El proceso de restauración (*Restore*) requiere una **Triple Verificación de Seguridad** y registra automáticamente las trazas en la tabla `Auditoria_Restauraciones`.

---
## Contenido

- [Qué hace](#qué-hace)
- [Roles y permisos](#roles-y-permisos)
- [Tecnologías](#tecnologías)
- [Arquitectura](#arquitectura)
- [Estructura del repositorio](#estructura-del-repositorio)
- [Instalación](#instalación)
- [Uso](#uso)
- [Base de datos](#base-de-datos)
- [Autores](#autores)

## Qué hace

**Productos.** Alta, modificación y baja de motos con marca, cilindrada, modelo, año, precio e imagen. Cada moto tiene un stock actual y un stock mínimo. Cuando un supervisor inicia sesión, el sistema le muestra un aviso con las motos que están por debajo de su mínimo.

**Clientes.** Registro, edición, búsqueda por DNI y baja lógica con posibilidad de reactivar. El DNI y el correo no se pueden repetir.

**Ventas.** Se elige el cliente, el tipo de factura y las motos con su cantidad. Al guardar, la cabecera y el detalle se registran en una sola transacción, se descuenta el stock y se genera la factura en PDF. Si no hay stock suficiente, la operación se rechaza. Desde el historial se puede filtrar por fechas o por DNI del cliente y anular una venta, siempre que hayan pasado menos de una hora desde que se emitió.

**Usuarios.** Alta, edición de campos, baja y reactivación de usuarios, cada uno con un tipo (rol).

**Reportes.** Gráficos y tablas por rango de fechas, según el rol del usuario (ver más abajo). Los gráficos usan `System.Windows.Forms.DataVisualization`.

**Backup y restauración.** Genera archivos `.bak` de la base de datos y permite restaurarlos. Cada restauración queda registrada y se puede consultar en un reporte.

**Validaciones.** DNI de 7 u 8 dígitos, formato de correo electrónico y contraseñas de al menos 8 caracteres.

## Roles y permisos

El menú principal se arma al iniciar sesión según el rol del usuario.

| Función | Administrador | Supervisor | Vendedor |
|---|:---:|:---:|:---:|
| Gestión de usuarios | Sí | No | No |
| Backup y restauración | Sí | No | No |
| Alta y edición de productos | No | Sí | No |
| Consulta de productos | No | Sí | Sí |
| Gestión de clientes | No | No | Sí |
| Registrar y consultar ventas | No | No | Sí |
| Aviso de stock crítico al ingresar | No | Sí | No |

Reportes disponibles por rol:

| Rol | Reportes |
|---|---|
| Administrador | Restauraciones de la base de datos a lo largo del tiempo |
| Supervisor | Evolución de ventas, ventas por usuario (gráfico de torta) y balance entre inversión y ventas |
| Vendedor | Evolución de sus propias ventas |

El balance financiero no usa el costo real de las motos. Estima la inversión asumiendo un margen del 15 % sobre el precio de venta, es decir, `costo = precio / 1,15` multiplicado por el stock.

## Tecnologías

| Componente | Detalle |
|---|---|
| Lenguaje | VB.NET |
| Plataforma | .NET 10 (`net10.0-windows`), Windows Forms |
| Base de datos | SQL Server Express |
| Acceso a datos | ADO.NET con `Microsoft.Data.SqlClient` 7.1.0 y procedimientos almacenados |
| Facturas en PDF | PDFsharp 6.2.4 |
| Gráficos | WinForms.DataVisualization 1.10.2 |

## Arquitectura

La aplicación está dividida en tres capas. Cada capa solo habla con la que tiene al lado.

```
Formularios (presentación)  ->  Negocio (reglas y validaciones)  ->  Datos (ADO.NET)  ->  SQL Server
```

- **Formularios:** pantallas de Windows Forms dentro de un contenedor MDI. No acceden a la base de datos directamente.
- **Negocio:** valida datos, traduce errores de la base a mensajes comprensibles, procesa imágenes de productos y aplica la lógica de backup y restauración.
- **Datos:** una clase por entidad. Todas las consultas se hacen llamando a procedimientos almacenados con parámetros, y la conexión está centralizada en `ConexionBD`.

## Estructura del repositorio

```text
Proyecto-Taller-II-OnlyMotos-ERP/
├── OnlyMotos ERP.slnx
├── README.md
├── Scripts SQL/
│   ├── SQLQuery_Creacion de BD.sql               Base, tablas y datos iniciales
│   └── SQLQuery_Procedimientos_Almacenados.sql   Procedimientos almacenados
└── OnlyMotos ERS/
    ├── OnlyMotos ERP.vbproj
    ├── Datos/
    │   ├── ConexionBD.vb                 Cadenas de conexión
    │   └── Comunicadores BD/             BackUp, Cliente, Producto, Reporte,
    │                                     Restore, Usuario y Venta
    ├── Negocio/
    │   ├── Comunicadores CD/             Lógica por entidad (BackUp, Cliente,
    │   │                                 IngresoUsuario, Producto, Reports,
    │   │                                 Restore, Usuario, Venta)
    │   └── Validadores/                  DNI, email y contraseña
    ├── Formularios/
    │   ├── Formulario Login/
    │   ├── Formulario Menu Principal/    Ventana MDI y permisos por rol
    │   ├── Formularios Clientes/
    │   ├── Formularios Productos/
    │   ├── Formularios Ventas/           Venta, historial y factura PDF
    │   ├── Formularios Usuarios/
    │   ├── Formularios Sistema/          Backup y restauración
    │   └── Formulario Reportes/          Pantalla y generador de gráficos
    ├── My Project/
    └── Resources/                        Íconos y logos
```

## Instalación

### Requisitos

- Windows
- [SDK de .NET 10](https://dotnet.microsoft.com/download) o Visual Studio con soporte para .NET 10
- SQL Server Express (o cualquier edición de SQL Server) y SQL Server Management Studio

### Pasos

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/ZF-dev/Proyecto-Taller-II-OnlyMotos-ERP.git
   ```

2. Abrir SQL Server Management Studio y ejecutar, en este orden, los dos scripts de la carpeta `Scripts SQL/`:

   1. `SQLQuery_Creacion de BD.sql`: crea la base `OnlyMotosDB`, las tablas y los datos iniciales (tipos de usuario, usuarios de prueba, tipos de factura, marcas y cilindradas).
   2. `SQLQuery_Procedimientos_Almacenados.sql`: crea los procedimientos almacenados que usa la aplicación.

   Los scripts se ejecutan una sola vez sobre una instalación limpia. Volver a correrlos falla porque los objetos ya existen.

3. Revisar las cadenas de conexión en `OnlyMotos ERS/Datos/ConexionBD.vb`. Por defecto apuntan a la instancia `localhost\SQLEXPRESS01` con autenticación de Windows:

   ```vb
   Server=localhost\SQLEXPRESS01; Database=OnlyMotosDB; Integrated Security=True; TrustServerCertificate=True;
   ```

   Si tu instancia tiene otro nombre, cambiá el valor `localhost\SQLEXPRESS01` en las dos cadenas (`OnlyMotosDB` y `master`).

4. Abrir `OnlyMotos ERP.slnx` en Visual Studio, restaurar los paquetes NuGet y ejecutar el proyecto. También se puede desde la terminal:

   ```bash
   dotnet run --project "OnlyMotos ERS/OnlyMotos ERP.vbproj"
   ```

## Uso

1. Al abrir la aplicación aparece la pantalla de login. Con los datos iniciales podés ingresar con los usuarios de prueba (ver [Base de datos](#base-de-datos)).
2. El menú muestra solo las opciones que corresponden al rol del usuario.
3. Para vender: **Ventas > Registrar venta**, elegir cliente, tipo de factura y motos, y guardar. La factura se guarda como PDF en `Documentos\OnlyMotos_Facturas`.
4. Para hacer un backup (solo Administrador): **Sistema > Backup**. Pide usuario y contraseña de administrador. El sistema conserva como máximo los 3 respaldos más recientes con el formato `OnlyMotos_Backup_AAAAMMDD_HHMMSS.bak`.
5. Para restaurar (solo Administrador): **Sistema > Restore**. Exige tres verificaciones: credenciales de administrador, una confirmación explícita y una contraseña de seguridad. La restauración reemplaza todos los datos actuales y queda registrada.

El servicio de SQL Server necesita permisos de escritura sobre la carpeta de backups para poder generar y leer los archivos `.bak`.

## Base de datos

El motor es SQL Server y la base se llama `OnlyMotosDB`. Toda la comunicación de la aplicación con la base pasa por procedimientos almacenados.

### Tablas

| Tabla | Contenido |
|---|---|
| `Tipo_Usuario` | Roles: Administrador, Supervisor y Vendedor |
| `Usuario` | Datos de acceso y personales, con tipo y estado (Activo o inactivo) |
| `Cliente` | Clientes con DNI y correo únicos, y estado |
| `Marca` | Marcas de motos |
| `CC` | Cilindradas disponibles |
| `Moto` | Catálogo: marca, cilindrada, modelo, año, precio, stock, stock mínimo, imagen y fecha de alta |
| `Tipo_Factura` | Tipos de factura (A, B, C y D) |
| `Cabecera_Venta` | Una fila por venta: usuario, cliente, tipo de factura, fecha y total |
| `Detalle_Venta` | Motos vendidas en cada venta, con cantidad y subtotal |
| `Auditoria_Restauraciones` | Usuario y fecha de cada restauración de la base |

Las motos, marcas, cilindradas y ventas usan baja lógica mediante la columna `eliminado`. Anular una venta marca la cabecera como eliminada.

### Procedimientos almacenados

| Área | Procedimientos |
|---|---|
| Usuarios | `sp_ValidarUsuario`, `sp_ListarUsuarios`, `sp_ListarUsuariosInactivos`, `sp_InsertarUsuario`, `sp_ListarTiposUsuario`, `sp_DarBajaUsuario`, `sp_ReactivarUsuario`, `sp_BuscarUsuarioPorDni`, `sp_ActualizarCampoUsuario` |
| Clientes | `sp_ListarClientes`, `sp_ListarClientesInactivos`, `sp_InsertarCliente`, `sp_BuscarClientePorDni`, `sp_ActualizarCliente`, `sp_DarDeBajaCliente`, `sp_ReactivarCliente`, `sp_ListarClientesParaCombo` |
| Productos | `sp_ListarMotos`, `sp_InsertarMoto`, `sp_ActualizarMoto`, `sp_ActualizarStockMoto`, `sp_EliminarMoto`, `sp_FiltrarMotosPorModelo`, `sp_ListarMarcasParaCombo`, `sp_ListarCcParaCombo`, `sp_MotosStockCritico` |
| Ventas | `sp_ListarTiposFactura`, `sp_ListarMotosDisponibles`, `sp_ObtenerMotoPorId`, `sp_DescontarStockDetalle`, `sp_DevolverStockMoto`, `sp_RegistrarCabeceraVenta`, `sp_RegistrarDetalleVenta`, `sp_ObtenerUltimoIdVenta`, `sp_ListarVentas`, `sp_ListarDetalleVentaPorId`, `sp_AnularVenta` |
| Reportes | `sp_Reporte_VentasPorUsuario`, `sp_Reporte_VentasPorRango`, `sp_Reporte_ComprasPorRango`, `sp_Reporte_VentasPorTiempo`, `sp_Reporte_VentasPorUsuarioYTiempo`, `sp_Reporte_RestauracionesPorTiempo` |
| Sistema | `sp_RealizarBackup`, `sp_RestaurarBackup`, `sp_RegistrarRestore` |

`sp_RealizarBackup` y `sp_RestaurarBackup` se crean en la base `master`, porque la restauración no puede ejecutarse desde la base que se está restaurando. Para restaurar, el procedimiento pone la base en modo usuario único, hace el `RESTORE` y la vuelve a modo multiusuario.

### Usuarios de prueba

El script de creación inserta tres usuarios para probar cada rol. Las contraseñas están en el propio script.

| Usuario | Rol |
|---|---|
| `admin` | Administrador |
| `supervisor` | Supervisor |
| `vendedor` | Vendedor |

Son datos de demostración. Antes de usar el sistema fuera del ámbito académico hay que borrarlos o cambiarlos.

## Autores

Proyecto académico de la materia Taller de Programación II, Universidad Nacional del Nordeste (UNNE).

| Nombre | GitHub |
|---|---|
| Federico Zini | [@ZF-dev](https://github.com/ZF-dev) |


