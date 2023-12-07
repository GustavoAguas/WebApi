# WebApi con ASP.NET Core

Este proyecto consiste en una API RESTful segura desarrollada utilizando ASP.NET Core. La aplicación implementa prácticas avanzadas de autenticación y utiliza tokens JWT para la autorización.

## Configuración del Proyecto

- **ASP.NET Core**: El proyecto está creado con ASP.NET Core 8.0 utilizando el patrón de diseño Web API.

- **Middleware de Autenticación**: Se ha configurado el middleware de autenticación para utilizar tokens JWT. La configuración se encuentra en el archivo `appsettings.json`.

## Implementación de la API RESTful

### Controladores

#### ClienteController

- **Listar Clientes**: `GET /cliente/listar`
- **Listar Cliente por ID**: `GET /cliente/listarid`
- **Guardar Cliente**: `POST /cliente/guardar`
- **Eliminar Cliente**: `POST /cliente/eliminar` (Requiere autenticación de administrador)

#### UsuarioController

- **Iniciar Sesión**: `POST /usuario/login`

## Instrucciones

- Descarga este repositorio en tu máquina local.
- Dentro de la carpeta descargada abre el archivo `API.csproj`.
- Una vez dentro puedes iniciar la aplicación, se abribrá tu navegador, tendras que ingresar una dirección como esta: `localhost:7162/swagger`.
- `Nota:` La dirección proporcionada anteriormente es de referencia, el puerto puede cambiar en cada entorno pero el resto es igual.

## Seguridad y Middleware

- Se ha implementado un middleware personalizado para registrar las solicitudes a la API antes y después del procesamiento.

- Se ha configurado una política de autorización (`AdminPolicy`) que requiere el rol de administrador para ciertas operaciones.

## Documentación

La API se documenta utilizando Swagger/OpenAPI. Puedes acceder a la documentación en [localhost:tu_puerto/swagger/v1/swagger.json](http://localhost:tu_puerto/swagger/v1/swagger.json).

## Configuración Adicional

### appsettings.json

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "Jwt": {
    "Key": "this is my custom Secret key for authentication",
    "Iusser": "https://localhost:7162/",
    "Audience": "https://localhost:7162/",
    "Subject": "baseWebApiSubject"
  }
}
