# Base on the official .NET Core 3.0 image.
FROM mcr.microsoft.com/dotnet/core/runtime:3.0

# Copy built and publsihed console app to image.
COPY ./bin/Debug/netcoreapp3.0/publish/ console-app/

# Entry point is the console app DLL.
ENTRYPOINT ["dotnet", "console-app/ConsoleApp.dll"]