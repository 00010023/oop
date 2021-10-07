FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["liwy/liwy.csproj", "liwy/"]
RUN dotnet restore "liwy/liwy.csproj"
COPY . .
WORKDIR "/src/liwy"
RUN dotnet build "liwy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "liwy.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "liwy.dll"]
