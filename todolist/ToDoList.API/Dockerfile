FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ToDoList.API.csproj", "./"]
RUN dotnet restore "./ToDoList.API.csproj"
COPY . .

RUN dotnet build "ToDoList.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ToDoList.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ToDoList.API.dll"]
