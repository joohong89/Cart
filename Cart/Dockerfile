#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS base
WORKDIR /app
ENV RABBITMQ_PORT 5672
ENV RABBITMQ_HOST rabbitmq
EXPOSE 5133
ENV ASPNETCORE_URLS=http://+:5133

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cart.csproj", "."]
RUN dotnet restore "./Cart.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Cart.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cart.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cart.dll"]