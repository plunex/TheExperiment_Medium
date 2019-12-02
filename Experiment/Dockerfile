FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Experiment/*.csproj ./Experiment/
COPY Experiment.Procedure/*.csproj ./Experiment.Procedure/
COPY Experiment.Sample/*.csproj ./Experiment.Sample/
COPY Experiment.UnitTest/*.csproj ./Experiment.UnitTest/

RUN dotnet restore

# copy everything else and build app
COPY Experiment/. ./Experiment/
COPY Experiment.Procedure/. ./Experiment.Procedure/
COPY Experiment.Sample/. ./Experiment.Sample/

WORKDIR /app/Experiment
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app

COPY --from=build /app/Experiment/out ./
ENTRYPOINT ["dotnet", "Experiment.dll"]