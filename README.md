[![Build Status](https://travis-ci.com/B1tF8er/bit-logger.svg?branch=master)](https://travis-ci.com/B1tF8er/bit-logger)
[![Build status](https://ci.appveyor.com/api/projects/status/qgv3t8hq7c5i659h?svg=true)](https://ci.appveyor.com/project/B1tF8er/bit-logger)
<a href='https://coveralls.io/github/B1tF8er/bit-logger?branch=master'><img src='https://coveralls.io/repos/github/B1tF8er/bit-logger/badge.svg?branch=master' alt='Coverage Status' /></a>

# Logger for .NET Core
Logger for .NET Core Apps that enables logging to different outputs

## Console
If the code that implements the logger is a console application, it can send messages to its console

## Database
With the use of EntityFrameworkCore a SQLite database is created to save the records

## File
A file is created every hour to keep small files in the path where the assembly is run

## Custom
You can create custom loggers to send the messages to a different output of your preference

### Configurable
All the provided loggers and the ones you may create can be configured to only show specific data according to the needs of your business
