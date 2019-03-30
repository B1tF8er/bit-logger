# Sample projects

## Default.Loggers sample project
### How to build and run using `dotnet cli`
```
    # Debug
    dotnet build ./Default.Loggers -c Debug
    dotnet run -p ./Default.Loggers -c Debug
    
    # Release
    dotnet build ./Default.Loggers -c Release
    dotnet run -p ./Default.Loggers -c Release
``` 

### How to build and run using `docker cli`
```
    # build image and tag it
    docker build -t default-loggers ./Default.Loggers
    # run image using tag ^^
    docker run --rm default-loggers
```
