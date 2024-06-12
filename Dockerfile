FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /source

RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

COPY *.csproj .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Release -o /app
RUN dotnet ef database update


FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app .
COPY --from=build /source/dotnet-rpg.db .
EXPOSE 8080

ENTRYPOINT ["dotnet", "dotnet-rpg.dll"]


