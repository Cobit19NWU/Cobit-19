#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV RUNTIME=Production
EXPOSE 80
EXPOSE 443


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Cobit-19/Cobit-19.csproj", "Cobit-19/"]
RUN dotnet restore "Cobit-19/Cobit-19.csproj"
COPY . .
WORKDIR "/src/Cobit-19"
RUN dotnet build "Cobit-19.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Cobit-19.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Cobit-19.dll"]