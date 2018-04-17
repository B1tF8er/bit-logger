namespace Bit.Logger.Handlers
{
    using Bit.Logger.Config;
    using System;
    using static Bit.Logger.Helpers.Tracer;

    internal class DatabaseHandlerLogger : IHanlder
    {
        public Configuration Configuration { get; }

        public DatabaseHandlerLogger(DatabaseConfiguration configuration) =>
            Configuration = configuration ?? new DatabaseConfiguration();

        public void Write<TClass>(string message, Level level) where TClass : class =>
            ToDatabase<TClass>(level, message);

        public void Write(string message, Level level) =>
            ToDatabase(level, message);

        public void Write<TClass>(Exception exception, Level level) where TClass : class =>
            ToDatabase<TClass>(level, exception: exception);

        public void Write(Exception exception, Level level) =>
            ToDatabase(level, exception: exception);

        public void Write<TClass>(string message, Exception exception, Level level) where TClass : class =>
            ToDatabase<TClass>(level, message, exception);

        public void Write(string message, Exception exception, Level level) =>
            ToDatabase(level, message, exception);

        private void ToDatabase<TClass>(Level level, string message = default(string), Exception exception = null)
            where TClass : class
        {
            if (Configuration.Level >= level)
            {
                // TODO: save to DB
            }
        }

        private void ToDatabase(Level level, string message = default(string), Exception exception = null)
        {
            if (Configuration.Level >= level)
            {
                // TODO: save to DB
            }
        }
    }
}