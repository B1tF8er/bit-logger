[![Build Status](https://travis-ci.com/B1tF8er/bit-logger.svg?branch=master)](https://travis-ci.com/B1tF8er/bit-logger)
[![Coverage Status](https://coveralls.io/repos/github/B1tF8er/bit-logger/badge.svg)](https://coveralls.io/github/B1tF8er/bit-logger)

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
