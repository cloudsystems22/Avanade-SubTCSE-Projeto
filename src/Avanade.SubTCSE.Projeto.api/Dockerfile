#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Avanade.SubTCSE.Projeto.api/Avanade.SubTCSE.Projeto.api.csproj", "Avanade.SubTCSE.Projeto.api/"]
RUN dotnet restore "Avanade.SubTCSE.Projeto.api/Avanade.SubTCSE.Projeto.api.csproj"
COPY . .
WORKDIR "/src/Avanade.SubTCSE.Projeto.api"
RUN dotnet build "Avanade.SubTCSE.Projeto.api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Avanade.SubTCSE.Projeto.api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Avanade.SubTCSE.Projeto.api.dll"]