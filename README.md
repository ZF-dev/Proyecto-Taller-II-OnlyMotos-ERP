# OnlyMotos ERP — Sistema de Gestión, Auditoría y Reportes

![Estado](https://img.shields.io/badge/Estado-Completado-brightgreen)
![Lenguaje](https://img.shields.io/badge/Lenguaje-VB.NET-blue)
![Base%20de%20Datos](https://img.shields.io/badge/BD-SQL%20Server-red)
![Arquitectura](https://img.shields.io/badge/Arquitectura-3--Layers-orange)

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

## Vista Previa de la Interfaz

| Módulo de Ventas | Reportes Estadísticos |
|---|---|
| ![Ventas](https://via.placeholder.com/450x250?text=Modulo+de+Ventas+OnlyMotos) | ![Reportes](https://via.placeholder.com/450x250?text=Graficos+de+Evolucion+y+Balances) |

---

## Características Principales

- **Autenticación y Seguridad:** Protocolos de re-login y verificación de contraseña maestra para backups y restore.
- **Gestión de Stock Alert:** Generación de avisos automáticos al aproximarse al mínimo stock parametrizado.
- **Reportes Dinámicos por Rol:** Gráficos de barras (Inversión vs. Ventas) y líneas con marcadores para la evolución de ventas por tiempo y vendedor.
- **Facturación Integrada:** Emisión de comprobantes con selección rápida de clientes y actualización inmediata de existencias.
- **Auditoría de Sistema:** Registro automatizado de eventos clave en la base de datos para garantizar la integridad histórica.

---

## Estructura del Repositorio

```text
Proyecto-Taller-II-OnlyMotos-ERP/
│
├── 📁 CapaPresentacion/               # Formularios Windows Forms, MDI y Gráficos
├── 📁 CapaNegocio/                    # Lógica comercial, controladores y validaciones
├── 📁 CapaDatos/                      # Conexión ADO.NET y ejecutor de Stored Procedures
│
├── 📄 SQLQuery_Creacion de BD.sql     # Script de creación de base de datos y relaciones
├── 📄 SQLQuery_Procedimientos...sql   # Script de Stored Procedures y triggers de auditoría
└── 📄 README.md                       # Documentación del proyecto
