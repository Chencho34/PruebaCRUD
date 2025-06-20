# Control de Estudiantes CRUD 

Aplicación web desarrollada con **Blazor** (.NET 8) para la gestión de estudiantes. Permite realizar operaciones CRUD (Crear, Leer, Actualizar, Eliminar) sobre un registro de estudiantes, utilizando Entity Framework Core y una base de datos SQL Server.

## Características

- Listado de estudiantes con paginación y acciones rápidas (editar, ver detalles, eliminar).
- Formulario para registrar nuevos estudiantes con validaciones.
- Edición y eliminación de registros existentes.
- Visualización de detalles completos de cada estudiante.
- Campos gestionados: Nombres, Apellidos, Fecha de Nacimiento, Dirección, Sexo, CURP, Teléfono, Email, Carrera, Modalidad, Descripción, Mascotas, Horario de Comida, entre otros.
- Interfaz moderna usando componentes de Syncfusion Blazor.

## Tecnologías utilizadas

- [Blazor Server](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
- .NET 8
- Entity Framework Core
- SQL Server
- Syncfusion Blazor Components

## Requisitos previos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- SQL Server (local o remoto)
- Visual Studio 2022 (recomendado)

## Instalación y ejecución

1. **Clona el repositorio:**

```
git clone https://github.com/tu-usuario/PruebaCRUD.git
```

Posteriormente:

```
cd PruebaCRUD
```

2. **Configura la cadena de conexión a tu base de datos SQL Server**  
   Edita el archivo `appsettings.json`.

```
"ConnectionStrings": {
  "MyAppDbContext": "Server=TU_SERVIDOR;Database=PruebaCRUD;Trusted_Connection=True;TrustServerCertificate=true"
}
```
•	Cambia TU_SERVIDOR por el nombre de tu instancia de SQL Server.

3.	Aplica las migraciones
Abre la Consola del Administrador de Paquetes (Package Manager Console) en Visual Studio y ejecuta:

```
Update-Database
```

Esto creará la base de datos y las tablas automáticamente.


4. **Ejecuta la aplicación:**
Presiona F5 o ejecuta:

```
dotnet run
```

Ejecuta el programa y Abre tu navegador en `https://localhost:7071/students` (o el puerto configurado).

## Estructura del proyecto
- `Pages/Home.razor`: Listado principal de estudiantes.
- `Pages/Create.razor`: Alta de nuevos estudiantes.
- `Pages/Edit.razor`: Edición de estudiantes.
- `Pages/Details.razor`: Detalles de un estudiante.
- `Pages/Delete.razor`: Eliminación de estudiantes.
- `Models/Student.cs`: Modelo de datos del estudiante.
- `Data/MyAppDbContext.cs`: Contexto de Entity Framework.
