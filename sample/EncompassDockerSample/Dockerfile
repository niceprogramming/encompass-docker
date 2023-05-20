FROM mcr.microsoft.com/dotnet/framework/sdk:4.8 AS build
WORKDIR /app

COPY *.sln .
COPY EncompassDockerSample/*.csproj ./EncompassDockerSample/
RUN dotnet restore

COPY EncompassDockerSample/. ./EncompassDockerSample/
WORKDIR /app/EncompassDockerSample
RUN dotnet publish -c Release -o out --no-restore


FROM encompasssdk:latest

WORKDIR /app
COPY --from=build /app/EncompassDockerSample/out ./
ENTRYPOINT [ "EncompassDockerSample.exe" ]
