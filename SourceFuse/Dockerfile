FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SourceFuse/SourceFuse.csproj", "SourceFuse/"]
RUN dotnet restore "SourceFuse/SourceFuse.csproj"
COPY . .
WORKDIR "/src/SourceFuse"
RUN dotnet build "SourceFuse.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SourceFuse.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SourceFuse.dll"]