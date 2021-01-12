FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /
COPY ["../../../API/", "./"]
RUN dotnet restore "/API/test/EFCore.MySql.IntegrationTests.csproj"
COPY . .
WORKDIR "/API/test/EFCore.MySql.IntegrationTests/."
RUN dotnet build "/API/test/EFCore.MySql.IntegrationTests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "/API/test/EFCore.MySql.IntegrationTests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "/API/test/EFCore.MySql.IntegrationTests/Pomelo.EntityFrameworkCore.MySql.IntegrationTests.dll"]
