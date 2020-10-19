#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
#ports

#grpc

EXPOSE 5021

#http

EXPOSE 5022


FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Horizon.Services.PaySuff/Horizon.Services.PayBFF.csproj", "Horizon.Services.PaySuff/"]
RUN dotnet restore "Horizon.Services.PaySuff/Horizon.Services.PayBFF.csproj"
COPY . .
WORKDIR "/src/Horizon.Services.PaySuff"
RUN dotnet build "Horizon.Services.PayBFF.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Horizon.Services.PayBFF.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Horizon.Services.PayBFF.dll"]