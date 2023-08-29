FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /
COPY ..
RUN dotnet restore
RUN dotnet publish -c release -o /app --no-restore
ENTRYPOINT ["dotnet", "aspnetapp.dll"]