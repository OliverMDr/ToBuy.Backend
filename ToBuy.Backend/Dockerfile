# Use the official .NET SDK image to build and publish the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory inside the container
WORKDIR /app

# Copy the project files to the working directory
COPY *.csproj ./

# Restore the dependencies specified in the project file
RUN dotnet restore

# Copy the entire project to the working directory
COPY . ./

# Build and publish the application in Release configuration to the 'out' directory
RUN dotnet publish -c Release -o out

# Use the official .NET runtime image to run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set the working directory inside the container
WORKDIR /app

# Copy the published output from the build stage to the runtime stage
COPY --from=build-env /app/out .

# Expose port 80 to allow external access to the application
EXPOSE 80

# Set the entry point to run the application
ENTRYPOINT ["dotnet", "ToBuy.Backend.dll"]