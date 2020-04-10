FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["todolistui.csproj", "./"]
RUN dotnet restore "./todolistui.csproj"
COPY . .

RUN dotnet build "todolistui.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "todolistui.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "todolistui.dll"]
