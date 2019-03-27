# Main project

## How to build, pack and publish
```
    dotnet build ./src/Bit.Logger -c Release
    dotnet pack ./src/Bit.Logger -c Release -o ../../artifacts/nupkg
    dotnet publish ./src/Bit.Logger -c Release -o ../../artifacts/build
``` 
