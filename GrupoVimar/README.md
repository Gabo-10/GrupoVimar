# Prueba Técnica Grupo Vimar

Esta es una aplicación Web desarrollada en ASP.NET Core MVC que incluye:

- CRUD de vehículos con Telerik UI 
- Consumo de API externa (PokeAPI)
- Sistema de autenticación con ASP.NET Core Identity
- Base de datos en PostgreSQL
- Exportación de esquema '.sql'
- Documentación completa


## Requisitos del Sistema

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [PostgreSQL 15+](https://www.postgresql.org/download/)
- [pgAdmin (opcional)](https://www.pgadmin.org)
- [Telerik](https://www.telerik.com/aspnet-core-ui)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/downloads/)


## Instalación y configuración

1. **Clonar el repositorio:**

        https://github.com/Gabo-10/GrupoVimar.git
        cd GrupoVimar
       


2. **Configurar la cadena de conexión**

        "ConnectionStrings": {
                "PostgreSQL": "Host=localhost;Port=5433;Database=crud_vehiculos;Username=postgres;Password=TuPassword"
         }"


3. **Restaurar los paquetes NuGet:**              
         Abre la terminal en la raíz del proyecto y ejecuta:        dotnet restore


4. **Ejecutar la Base de Datos**

       Puedes usar el archivo `script.sql` para crear la base de datos y las tablas necesarias en PostgreSQL.
       

5. **Corre la aplicacion**

        dontner run


# Autenticacion
    · Sistema de registro e inicio de sesión basado en ASP.NET Core Identity
    · Las rutas de CRUD están protegidas y requieren autenticación

## Acceder
    · Registro: https://localhost:7000/Identity/Account/Register
    · Inicia sesión: https://localhost:7000/Identity/Account/Login


# CRUD con Telerik UI
    · CRUD de vehículos implementado con componentes  de Telerik UI
    · Permite crear, listar, editar y eliminar registros
    · Validaciones y estilo profesional


# Consumo de API externa(PokeAPI)
    · Se realiza una petición a PokeAPI
    · Se muestran los primeros 10 pokemones con sus imágenes
    · Vista implementada con componentes de Telerik


# Base de Datos
    · PostgreSQL como motor de Base de Datos
    · El esquema completo está en el archivo script.sql

# Tecnologías utilizadas
    · ASP.MET Core MVC
    · Entity Framework Core
    · PostgreSQL
    · Telerik UI
    · Bootstrap 
    · Identity
    · PokeAPI

# Licencia
Este proyecto es solo para fines educativos y demostrativos.
Puedes modificarlo y reutilizarlo libremente.

# Autor 
Desarrollado por Gabriel 
https://github.com/Gabo-10