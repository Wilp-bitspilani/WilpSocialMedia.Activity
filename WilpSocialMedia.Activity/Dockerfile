FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app

EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["WilpSocialMedia.Activity/WilpSocialMedia.Activity.csproj", "WilpSocialMedia.Activity/"]
COPY ["WilpSocialMedia.Common/WilpSocialMedia.Common.csproj", "WilpSocialMedia.Common/"]
RUN dotnet restore "WilpSocialMedia.Activity/WilpSocialMedia.Activity.csproj"
COPY . .
WORKDIR "/src/WilpSocialMedia.Activity"
RUN dotnet build "WilpSocialMedia.Activity.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WilpSocialMedia.Activity.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WilpSocialMedia.Activity.dll"]
