# 1. Build Stage
# Uses the official .NET SDK image to compile your code
FROM ://microsoft.com AS build
WORKDIR /src

# Copy the project file and restore any dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy all remaining source files and compile the application
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# 2. Runtime Stage
# Uses a smaller, lightweight image that only contains the .NET runtime (no SDK)
FROM ://microsoft.com AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Render dynamically assigns a port; ASP.NET Core needs to bind to all interfaces
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080

# This command starts your API when the container boots up
ENTRYPOINT ["dotnet", "StudentManagement.dll"]
