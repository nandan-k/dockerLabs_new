FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["demoapi.csproj", "./"]
RUN dotnet restore "./demoapi.csproj"
COPY . .
RUN dotnet build "demoapi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "demoapi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "demoapi.dll"]
