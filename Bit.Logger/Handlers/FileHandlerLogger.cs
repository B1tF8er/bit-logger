namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal class FileHandlerLogger : IHanlder 
    {
        public Configuration Configuration { get; }

        public FileHandlerLogger(FileConfiguration configuration) =>
            Configuration = configuration ?? new FileConfiguration();

        public void Write<TClass>(string message, Level level) where TClass : class =>
            ToFile<TClass>(level, message);

        public void Write(string message, Level level) =>
            ToFile(level, message);

        public void Write<TClass>(Exception exception, Level level) where TClass : class =>
            ToFile<TClass>(level, exception: exception);

        public void Write(Exception exception, Level level) =>
            ToFile(level, exception: exception);

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class =>
            ToFile<TClass>(level, message, exception);

        public void Write(string message, Exception exception, Level level) =>
            ToFile(level, message, exception);

        private void ToFile<TClass>(Level level, string message = default(string), Exception exception = null)
            where TClass : class
        {
            if (Configuration.Level >= level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        typeof(TClass).FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
            }
        }

        private void ToFile(Level level, string message = default(string), Exception exception = null)
        {
            if (Configuration.Level >= level)
            {
                Console.WriteLine(
                    string.Format(Configuration.FormatProvider, Configuration.Format,
                        level,
                        DateTime.Now,
                        GetClass().FullName,
                        GetMethodName(),
                        message,
                        exception
                    )
                );
            }
        }
    }
}