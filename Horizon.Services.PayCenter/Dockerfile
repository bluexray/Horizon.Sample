#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

#ports
#grpc
EXPOSE 5021
#http
EXPOSE 5022

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
COPY . /src

WORKDIR /src
RUN ls -la

WORKDIR /src/Horizon.Services.PayCenter
RUN ls -la

FROM build AS publish
RUN dotnet publish "Horizon.Services.PayCenter.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN cp /usr/share/zoneinfo/Asia/Shanghai /etc/localtime && \ 
    echo 'Asia/Shanghai' >/etc/timezone
    
ENTRYPOINT ["dotnet", "Horizon.Services.PayCenter.dll"]