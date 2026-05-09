# Use the official .NET 10 SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy csproj and restore as distinct layers
COPY ["KaziKagwilawo.csproj", "./"]
RUN dotnet restore "./KaziKagwilawo.csproj"

# Copy everything else and build the application
COPY . .
RUN dotnet publish "KaziKagwilawo.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render exposes the port dynamically using the PORT environment variable
ENV ASPNETCORE_URLS=http://+:${PORT:-8080}
EXPOSE 8080

ENTRYPOINT ["dotnet", "KaziKagwilawo.dll"]
