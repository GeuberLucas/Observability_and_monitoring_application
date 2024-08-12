# Estágio base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Estágio de build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Api_Metrics_With_Prometheus/Api_Metrics_With_Prometheus/Api_Metrics_With_Prometheus.csproj", "Api_Metrics_With_Prometheus/"]
RUN dotnet restore "Api_Metrics_With_Prometheus/Api_Metrics_With_Prometheus.csproj"
COPY . .
WORKDIR "/src/Api_Metrics_With_Prometheus"
RUN dotnet build -c $BUILD_CONFIGURATION -o /app/build

# Estágio de publicação
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Estágio final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api_Metrics_With_Prometheus.dll"]


