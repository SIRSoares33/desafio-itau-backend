FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src
COPY ["DesafioItau.csproj", "./"]
RUN dotnet restore "DesafioItau.csproj"
COPY . .
RUN dotnet build "DesafioItau.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesafioItau.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesafioItau.dll"]