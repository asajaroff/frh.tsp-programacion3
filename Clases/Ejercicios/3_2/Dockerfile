FROM mcr.microsoft.com/dotnet/core/runtime:3.1

LABEL mainteiner="Alejandro Sajaroff"
LABEL mainteiner.email='asajaroff@alumnos.frh.utn.edu.ar'
LABEL version="1.0"

ARG RELEASE_NAME=Release

COPY app/bin/${RELEASE_NAME}/netcoreapp3.1/publish/ app/

ENTRYPOINT ["dotnet", "app/myapp.dll"]
