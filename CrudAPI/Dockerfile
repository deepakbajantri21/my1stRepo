FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
COPY . /
WORKDIR /
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
ENTRYPOINT ["dotnet", "run"]
EXPOSE 5100