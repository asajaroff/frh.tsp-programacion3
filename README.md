# Programacion III - Containers

## Introduccion

En este documento de describe como instalar el ambiente para desarrollo en Linux. Existen instalaciones para diferentes distribuciones:

## Instalacion

### Agregar las llaves PGP a apt.
```bash
wget -O- https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.asc.gpg
sudo mv microsoft.asc.gpg /etc/apt/trusted.gpg.d/
wget https://packages.microsoft.com/config/debian/10/prod.list
sudo mv prod.list /etc/apt/sources.list.d/microsoft-prod.list
sudo chown root:root /etc/apt/trusted.gpg.d/microsoft.asc.gpg
sudo chown root:root /etc/apt/sources.list.d/microsoft-prod.list
```

### Instalar el SDK de .NET Core
```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-3.1
```

## Trabajando con .NET Core y Containers

Prerequisitos:
1.  [Instalar Docker](https://docs.docker.com/install/)
2.  [Instalar .NET Core SDK](https://docs.microsoft.com/en-us/dotnet/corellinstall/sdk?pivots=os-windows)
3.  Un editor de texto
4.  Una terminal a la consola del sistema: 
-   `cmd` o `Powersell` para Windows.
-   `bash`, `zsh`, `sh` en Linux/MacOS.

### 