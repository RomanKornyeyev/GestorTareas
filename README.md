GESTOR DE TAREAS (MVC)

TECNOLOGÍAS:
- .NET 10
- Entity Framework Core
- SQL Server
- MVC

DEPENDENCIAS:
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet tool install --global dotnet-ef

MIGRACIONES:
dotnet ef migrations add [[NombreMigracion]]
dotnet ef database update

(revertir a una migración anterior):
dotnet ef migrations list (muestra la lista de migraciones aplicadas)
dotnet ef database update 20251228xxxx_Anterior (vuelve a la migración especificada)
dotnet ef migrations remove (borra las migraciones no aplicadas)

CACHÉ:
dotnet clean
dotnet build

SQL SEGUNDO PLANO (DETENER, LEVANTAR):
SqlLocalDB info (info servers locales)
SqlLocalDB info [[[NOMBRE_SERVER]]] (info detallada)
SqlLocalDB stop MSSQLLocalDB -k (detener)
SqlLocalDB start MSSQLLocalDB (levantar, aunque se hace auto)

