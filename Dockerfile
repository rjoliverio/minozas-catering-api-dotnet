# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /source
COPY . .
RUN dotnet restore "./minozas-catering-api-dotnet.csproj" --disable-parallel
RUN dotnet publish "./minozas-catering-api-dotnet.csproj" -c release -o /app --no-restore
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"
RUN dotnet ef database update

# Serve Stage 
FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal
WORKDIR /app
COPY --from=build /app ./

EXPOSE 80

ENTRYPOINT ["dotnet", "minozas-catering-api-dotnet.dll"]