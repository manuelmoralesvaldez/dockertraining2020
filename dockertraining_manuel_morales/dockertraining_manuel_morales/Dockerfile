#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim 
# FROM mcr.microsoft.com/dotnet/core/runtime:3.1
#FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 

ENV STORENAME=""

COPY ./bin/Release/netcoreapp3.1/publish/ . app/
WORKDIR /app
EXPOSE 80
ENTRYPOINT ["dotnet", "app/dockertraining_manuel_morales.dll"]