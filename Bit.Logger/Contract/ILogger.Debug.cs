namespace Bit.Logger.Contract
{
    using System;
    
    public partial interface ILogger
    {
        void Debug<TClass>(string message) where TClass : class;

        void Debug(string message);
        
        void Debug<TClass>(Exception exception) where TClass : class;

        void Debug(Exception exception);

        void Debug<TClass>(string message, Exception exception) where TClass : class;

        void Debug(string message, Exception exception);
    }    
}