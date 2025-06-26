# Use the official Microsoft .NET Core SDK image as the build environment
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app
# HappyPlay.Core.API/*.csproj 
# Copy the solution file and individual project files 
COPY *.sln .
COPY LuckyThree.API/*.csproj ./LuckyThree.API/
COPY LuckyThree.Application/*.csproj ./LuckyThree.Application/
COPY LuckyThree.Common/*.csproj ./LuckyThree.Common/
COPY LuckyThree.Domain/*.csproj ./LuckyThree.Domain/
COPY LuckyThree.Infrastructure/*.csproj ./LuckyThree.Infrastructure/

# Restore NuGet packages for the entire solution
RUN dotnet restore


# Copy everything else and build
COPY . ./
RUN dotnet publish LuckyThree.API -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .

Expose 8080

ENTRYPOINT ["dotnet", "LuckyThree.API.dll"]

