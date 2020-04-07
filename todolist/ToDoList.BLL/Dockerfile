FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["ToDoList.BLL.csproj", "./"]
RUN dotnet restore "./ToDoList.BLL.csproj"
COPY . .

RUN dotnet build "ToDoList.BLL.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ToDoList.BLL.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ToDoList.BLL.dll"]
