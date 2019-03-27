# Test project

## How to build and create coverage file
```
    dotnet build ./test/Bit.Logger.Tests -c Release
    dotnet test ./test/Bit.Logger.Tests -c Release --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput="../coverage.xml" /p:Exclude=\"[xunit.*]*,[Bit.Logger]Bit.Logger.Migrations.*\"
```
