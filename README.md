# PruebaCRUD

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

## Instalación y ejecución

1. **Clona el repositorio:**

```
git clone https://github.com/tu-usuario/PruebaCRUD.git cd PruebaCRUD
```

2. **Configura la cadena de conexión a tu base de datos SQL Server**  
   Edita el archivo `appsettings.json` y ajusta la cadena de conexión bajo `ConnectionStrings`.

3. **Aplica las migraciones de la base de datos:**

```
dotnet ef database update
```

4. **Ejecuta la aplicación:**

```
dotnet run
```

O desde Visual Studio, presiona F5.

5. **Accede a la aplicación:**  
   Abre tu navegador en `https://localhost:5001` (o el puerto configurado).

## Estructura principal
- `Components/Pages/Home.razor`: Listado principal de estudiantes.
- `Components/Pages/Create.razor`: Alta de nuevos estudiantes.
- `Components/Pages/Edit.razor`: Edición de estudiantes.
- `Components/Pages/Details.razor`: Detalles de un estudiante.
- `Components/Pages/Delete.razor`: Eliminación de estudiantes.
- `Models/Student.cs`: Modelo de datos del estudiante.
