FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /App

COPY . .
RUN dotnet restore
RUN dotnet publish -c Debug -o out
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /App
COPY --from=build-env /App/out .
EXPOSE 10210
ENTRYPOINT ["dotnet", "patientOrders.dll"]
