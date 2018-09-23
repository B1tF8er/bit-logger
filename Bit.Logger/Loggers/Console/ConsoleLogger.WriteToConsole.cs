namespace Bit.Logger.Loggers.Console
{
    using Bit.Logger.Config;
    using Bit.Logger.Loggers.Arguments;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal partial class ConsoleLogger : ILogger, IConfiguration
    {
        private void WriteToConsole<TClass>(Level level, string message = default(string), Exception exception = default(Exception)) where TClass : class
            => Write(
                new LogArguments
                {
                    Level = level,
                    ClassName = typeof(TClass).FullName,
                    MethodName = GetMethodName(),
                    Message = message,
                    Exception = exception
                }
            );

        private void WriteToConsole(Level level, string message = default(string), Exception exception = default(Exception))
            => Write(
                new LogArguments
                {
                    Level = level,
                    ClassName = GetClass().FullName,
                    MethodName = GetMethodName(),
                    Message = message,
                    Exception = exception
                }
            );

        private void Write(LogArguments logArguments)
        {
            if (Configuration.Level <= logArguments.Level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        logArguments.Level,
                        DateTime.Now,
                        logArguments.ClassName,
                        logArguments.MethodName,    
                        logArguments.Message,    
                        logArguments.Exception
                    )
                );
            }
        }
    }
}