# docker -t build hello-docker-dotnet .
FROM mcr.microsoft.com/dotnet/core/runtime:3.0

COPY ./bin/Debug/netcoreapp3.0/publish/ console-app/

ENTRYPOINT ["dotnet", "console-app/ConsoleApp.dll"]