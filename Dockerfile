FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /pilot-api

EXPOSE 5024

COPY ./src/Pilot.API/*.csproj ./
# COPY ./src/Pilot.Application/*.csproj ./
# COPY ./src/Pilot.Domain/*.csproj ./
# COPY ./src/Pilot.Infrastructure/*.csproj ./

RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /pilot-api/out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /pilot-api
COPY --from=build /pilot-api/out .
ENTRYPOINT ["dotnet", "pilot-api.dll"]