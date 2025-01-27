FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
COPY . ./src
WORKDIR /src

# Copy everything
# COPY . ./
# Restore as distinct layers
# RUN dotnet restore
# Build and publish a release
RUN dotnet build -o /app
RUN dotnet publish -o /publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
COPY --from=build /publish /app
WORKDIR /app
EXPOSE 80
ENTRYPOINT [ "dotnet", "BookClubDotNet.dll"]

