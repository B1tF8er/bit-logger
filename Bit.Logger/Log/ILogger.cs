namespace Bit.Logger
{
    using System;
    
    public partial interface ILogger
    {
        void Trace<TClass>(string message) where TClass : class;

        void Trace(string message);
        
        void Trace<TClass>(Exception exception) where TClass : class;

        void Trace(Exception exception);

        void Trace<TClass>(string message, Exception exception) where TClass : class;

        void Trace(string message, Exception exception);

        void Debug<TClass>(string message) where TClass : class;

        void Debug(string message);
        
        void Debug<TClass>(Exception exception) where TClass : class;

        void Debug(Exception exception);

        void Debug<TClass>(string message, Exception exception) where TClass : class;

        void Debug(string message, Exception exception);
        
        void Verbose<TClass>(string message) where TClass : class;

        void Verbose(string message);
        
        void Verbose<TClass>(Exception exception) where TClass : class;

        void Verbose(Exception exception);

        void Verbose<TClass>(string message, Exception exception) where TClass : class;

        void Verbose(string message, Exception exception);
        
        void Information<TClass>(string message) where TClass : class;

        void Information(string message);
        
        void Information<TClass>(Exception exception) where TClass : class;

        void Information(Exception exception);

        void Information<TClass>(string message, Exception exception) where TClass : class;

        void Information(string message, Exception exception);
        
        void Warning<TClass>(string message) where TClass : class;

        void Warning(string message);
        
        void Warning<TClass>(Exception exception) where TClass : class;

        void Warning(Exception exception);

        void Warning<TClass>(string message, Exception exception) where TClass : class;

        void Warning(string message, Exception exception);

        void Error<TClass>(string message) where TClass : class;

        void Error(string message);
        
        void Error<TClass>(Exception exception) where TClass : class;

        void Error(Exception exception);

        void Error<TClass>(string message, Exception exception) where TClass : class;

        void Error(string message, Exception exception);
        
        void Critical<TClass>(string message) where TClass : class;

        void Critical(string message);
        
        void Critical<TClass>(Exception exception) where TClass : class;

        void Critical(Exception exception);

        void Critical<TClass>(string message, Exception exception) where TClass : class;

        void Critical(string message, Exception exception);
    }    
}