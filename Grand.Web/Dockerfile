FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY GrandNode.sln ./
COPY Grand.Web/Grand.Web.csproj Grand.Web/
COPY Grand.Framework/Grand.Framework.csproj Grand.Framework/
COPY Grand.Core/Grand.Core.csproj Grand.Core/
COPY Grand.Services/Grand.Services.csproj Grand.Services/
COPY Grand.Data/Grand.Data.csproj Grand.Data/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Grand.Web
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Grand.Web.dll"]
