# Template de Containers

## Crear un proyecto .NET Core

Abrir una terminal y ubicarse en el PATH donde queremos crear la nueva carpeta para el proyecto.
Una vez allí, ejecutamos:

```bash
> dotnet new console -o app -n myapp
```

Nuestra carpeta ahora se verá así:

```projects/
│
└───app
    │   myapp.csproj
    │   Program.cs
    │
    └───obj
            myapp.csproj.nuget.cache
            myapp.csproj.nuget.dgspec.json
            myapp.csproj.nuget.g.props
            myapp.csproj.nuget.g.targets
            project.assets.json
```

El comando `dotnet new` crea una carpeta llamada app y genera un programa 'Hello World'. 

Entrar en la carpeta y ejecutar `dotnet run`.
```bash
> dotnet run
Hello World!
```
## Publicar una app .NET Core
Antes de agregar nuestra app al container Docker, publicarla. Nos queremos asegurar de que el container corra la version publicada de la app cuando inicia.

Desde el directorio de trabajo, entremos en la carpeta *app* y ejecutemos:
```bash
dotnet publish -c Release
```

## Construccion del Container
Ubicarse en la carpeta padre de app, en el caso del ejemplo la carpeta `projects` y creamos un nuevo archivo llamado **Dockerfile**.
Popular el archivo con el siguiente contenido:
```Dockerfile
FROM mcr.microsoft.com/dotnet/core/runtime:3.1

COPY app/bin/Release/netcoreapp3.1/publish/ app/

ENTRYPOINT ["dotnet", "app/myapp.dll"]
```

## Recursos
1.  [Documentacion ofician Microsoft](https://docs.microsoft.com/en-us/dotnet/core/docker/build-container)