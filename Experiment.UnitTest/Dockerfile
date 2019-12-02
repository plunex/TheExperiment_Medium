FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Experiment/*.csproj ./Experiment/
COPY Experiment.Library/*.csproj ./Experiment.Library/
COPY Experiment.Model/*.csproj ./Experiment.Model/

RUN dotnet restore

# copy everything else and build app
COPY Experiment/. ./Experiment/
COPY Experiment.Library/. ./Experiment.Library/
COPY Experiment.Model/. ./Experiment.Model/
WORKDIR /app/Experiment
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
EXPOSE 80
COPY --from=build /app/Experiment/out ./
ENTRYPOINT ["dotnet", "Experiment.dll"]