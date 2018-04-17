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
    }    
}