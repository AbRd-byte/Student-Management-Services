# ==========================
# Build Stage
# ==========================
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

# Copy the entire solution
COPY . .

# Restore NuGet packages
RUN dotnet restore "Student-Management.sln"

# Publish the Web API project
RUN dotnet publish "Student-Management/StudentManagement.csproj" \
    -c Release \
    -o /app/publish \
    --no-restore

# ==========================
# Runtime Stage
# ==========================
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

# Render uses port 10000 by default
ENV ASPNETCORE_URLS=http://+:10000

EXPOSE 10000

ENTRYPOINT ["dotnet", "StudentManagement.dll"]
