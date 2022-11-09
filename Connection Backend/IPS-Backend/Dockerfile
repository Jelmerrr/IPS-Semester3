FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 44338

ENV ASPNETCORE_URLS=http://+:44338

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["IPS-Backend.csproj", "./"]
RUN dotnet restore "IPS-Backend.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "IPS-Backend.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IPS-Backend.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IPS-Backend.dll"]
