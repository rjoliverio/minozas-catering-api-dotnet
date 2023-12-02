# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./minozas-catering-api-dotnet.csproj" --disable-parallel
RUN dotnet publish "./minozas-catering-api-dotnet.csproj" -c release -o /app --no-restore

# Serve Stage 
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "minozas-catering-api-dotnet.dll"]