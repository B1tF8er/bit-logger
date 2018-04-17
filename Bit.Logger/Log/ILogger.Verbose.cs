namespace Bit.Logger
{
    using System;
    
    public partial interface ILogger
    {
        void Verbose<TClass>(string message) where TClass : class;

        void Verbose(string message);
        
        void Verbose<TClass>(Exception exception) where TClass : class;

        void Verbose(Exception exception);

        void Verbose<TClass>(string message, Exception exception) where TClass : class;

        void Verbose(string message, Exception exception);
    }    
}