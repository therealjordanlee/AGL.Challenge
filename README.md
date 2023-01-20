# AGL Challenge

[![AGLChallenge Build & Test](https://github.com/therealjordanlee/AGL.Challenge/actions/workflows/build.yaml/badge.svg)](https://github.com/therealjordanlee/AGL.Challenge/actions/workflows/build.yaml)

My solution to the AGL coding challenge.
The solution follows a simple structure:
- A service library project, which contains the models, services and clients for interacting with the AGL cat API;
- A Blazor Server project, which renders the web UI.

# How to use

Running tests:
```
dotnet test
```

Running the application:
```
dotnet restore
dotnet build
dotnet run --project .\src\AGLChallenge.Blazor\AGLChallenge.Blazor.csproj
```

This will run locally on port 5147.
Open a browser and go to http://localhost:5174

Alternatively, just open the solution in Visual Studio and press F5!