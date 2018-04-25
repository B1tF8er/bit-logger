namespace Bit.Logger.Samples
{
    using Bit.Logger.Config;
    using System;
    
    internal class CustomConsoleSource : ILogger, IConfiguration
    {
        public Configuration Configuration { get; }

        public CustomConsoleSource(Configuration configuration = default(Configuration)) =>
            Configuration = configuration ?? new Configuration();

        public void Critical<TClass>(string message) where TClass : class
        {
            if (Configuration.Level <= Level.Critical)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Critical}");
        }

        public void Critical(string message)
        {
            if (Configuration.Level <= Level.Critical)
                Console.WriteLine($"{message} : {Level.Critical}");
        }

        public void Critical<TClass>(Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Critical)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Critical}");
        }

        public void Critical(Exception exception) 
        {
            if (Configuration.Level <= Level.Critical)
                Console.WriteLine($"{exception} : {Level.Critical}");
        }

        public void Critical<TClass>(string message, Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Critical)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Critical}");            
        }

        public void Critical(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Critical)
                Console.WriteLine($"{message} + {exception} : {Level.Critical}");
        }

        public void Debug<TClass>(string message) where TClass : class
        {
            if (Configuration.Level <= Level.Debug)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Debug}");
        }

        public void Debug(string message) 
        {
            if (Configuration.Level <= Level.Debug)
                Console.WriteLine($"{message} : {Level.Debug}");
        }

        public void Debug<TClass>(Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Debug)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Debug}");
        }

        public void Debug(Exception exception) 
        {
            if (Configuration.Level <= Level.Debug)
                Console.WriteLine($"{exception} : {Level.Debug}");
        }

        public void Debug<TClass>(string message, Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Debug)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Debug}");            
        }

        public void Debug(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Debug)
                Console.WriteLine($"{message} + {exception} : {Level.Debug}");
        }

        public void Error<TClass>(string message) where TClass : class 
        {
            if (Configuration.Level <= Level.Error)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Error}");
        }

        public void Error(string message) 
        {
            if (Configuration.Level <= Level.Error)
                Console.WriteLine($"{message} : {Level.Error}");
        }

        public void Error<TClass>(Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Error)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Error}");
        }

        public void Error(Exception exception) 
        {
            if (Configuration.Level <= Level.Error)
                Console.WriteLine($"{exception} : {Level.Error}");
        }

        public void Error<TClass>(string message, Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Error)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Error}");            
        }

        public void Error(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Error)
                Console.WriteLine($"{message} + {exception} : {Level.Error}");
        }

        public void Information<TClass>(string message) where TClass : class 
        {
            if (Configuration.Level <= Level.Information)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Information}");
        }

        public void Information(string message) 
        {
            if (Configuration.Level <= Level.Information)
                Console.WriteLine($"{message} : {Level.Information}");
        }

        public void Information<TClass>(Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Information)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Information}");
        }

        public void Information(Exception exception) 
        {
            if (Configuration.Level <= Level.Information)
                Console.WriteLine($"{exception} : {Level.Information}");
        }

        public void Information<TClass>(string message, Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Information)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Information}");            
        }

        public void Information(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Information)
                Console.WriteLine($"{message} + {exception} : {Level.Information}");
        }

        public void Trace<TClass>(string message) where TClass : class 
        {
            if (Configuration.Level <= Level.Trace)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Trace}");
        }

        public void Trace(string message) 
        {
            if (Configuration.Level <= Level.Trace)
                Console.WriteLine($"{message} : {Level.Trace}");
        }

        public void Trace<TClass>(Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Trace)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Trace}");
        }

        public void Trace(Exception exception) 
        {
            if (Configuration.Level <= Level.Trace)
                Console.WriteLine($"{exception} : {Level.Trace}");
        }

        public void Trace<TClass>(string message, Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Trace)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Trace}");            
        }

        public void Trace(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Trace)
                Console.WriteLine($"{message} + {exception} : {Level.Trace}");
        }

        public void Verbose<TClass>(string message) where TClass : class 
        {
            if (Configuration.Level <= Level.Verbose)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Verbose}");
        }

        public void Verbose(string message) 
        {
            if (Configuration.Level <= Level.Verbose)
                Console.WriteLine($"{message} : {Level.Verbose}");
        }

        public void Verbose<TClass>(Exception exception) where TClass : class
        {
            if (Configuration.Level <= Level.Verbose)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Verbose}");
        }

        public void Verbose(Exception exception) 
        {
            if (Configuration.Level <= Level.Verbose)
                Console.WriteLine($"{exception} : {Level.Verbose}");
        }

        public void Verbose<TClass>(string message, Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Verbose)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Verbose}");            
        }

        public void Verbose(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Verbose)
                Console.WriteLine($"{message} + {exception} : {Level.Verbose}");
        }

        public void Warning<TClass>(string message) where TClass : class 
        {
            if (Configuration.Level <= Level.Warning)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} : {Level.Warning}");
        }

        public void Warning(string message) 
        {
            if (Configuration.Level <= Level.Warning)
                Console.WriteLine($"{message} : {Level.Warning}");
        }

        public void Warning<TClass>(Exception exception) where TClass : class 
        {
            if (Configuration.Level <= Level.Warning)
                Console.WriteLine($"{typeof(TClass).FullName} - {exception} : {Level.Warning}");
        }

        public void Warning(Exception exception)
        {
            if (Configuration.Level <= Level.Warning)
                Console.WriteLine($"{exception} : {Level.Warning}");
        }

        public void Warning<TClass>(string message, Exception exception) where TClass : class
        {
            if (Configuration.Level <= Level.Warning)
                Console.WriteLine($"{typeof(TClass).FullName} - {message} + {exception} : {Level.Warning}");            
        }

        public void Warning(string message, Exception exception) 
        {
            if (Configuration.Level <= Level.Warning)
                Console.WriteLine($"{message} + {exception} : {Level.Warning}");
        }
    }
}