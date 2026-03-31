# Sistema de Gestión de Inventario de Anime

Este proyecto consiste en una aplicación web desarrollada con el patrón de arquitectura MVC (Modelo-Vista-Controlador) utilizando ASP.NET Core. El objetivo principal fue implementar un CRUD funcional conectado a una base de datos SQL Server, aplicando prácticas de Git Flow y gestión de ramas mediante Pull Requests.

## Estructura del Proyecto

Para mantener el código organizado y escalable, el proyecto se ha estructurado de la siguiente manera:

* **Controllers:** Contiene la lógica de navegación y comunicación entre el usuario y los datos.
* **Models:** Define la estructura de la entidad "Anime".
* **Views:** Plantillas HTML (Razor) para la interfaz de usuario (Listado, Registro y Edición).
* **Data:** Repositorio que gestiona todas las consultas SQL (Select, Insert, Update, Delete) mediante ADO.NET.

## Configuración y Ejecución

Para desplegar este proyecto en su entorno local, por favor siga estos pasos:

### 1. Preparación de la Base de Datos
Dentro de la raíz del proyecto encontrará un archivo llamado `database.sql`. Debe ejecutar este script en su instancia de SQL Server para crear la base de datos `AnimeDB` y la tabla correspondiente con datos de prueba.

### 2. Cadena de Conexión
Es necesario actualizar la cadena de conexión en el archivo `Data/AnimeRepository.cs` para que coincida con el nombre de su servidor local y sus credenciales de acceso.

### 3. Lanzamiento
Una vez configurada la base de datos, abra una terminal en la carpeta raíz y ejecute:
`dotnet run`

La aplicación estará disponible en la dirección: `http://localhost:5000/Anime`

## Flujo de Trabajo
El desarrollo se realizó siguiendo un flujo de trabajo basado en Git Flow, completando un ciclo de 15 Pull Requests que documentan el progreso desde la creación de la base de datos hasta la integración final de la interfaz de usuario.

---
**Desarrollado por Rafael** Estudiante de Desarrollo de Software - ITLA