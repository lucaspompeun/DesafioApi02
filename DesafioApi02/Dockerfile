#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["DesafioApi02/DesafioApi02.csproj", "DesafioApi02/"]
RUN dotnet restore "DesafioApi02/DesafioApi02.csproj"
COPY . .
WORKDIR "/src/DesafioApi02"
RUN dotnet build "DesafioApi02.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesafioApi02.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesafioApi02.dll"]