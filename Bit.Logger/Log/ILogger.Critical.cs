namespace Bit.Logger
{
    using System;

    public partial interface ILogger
    {
        void Critical<TClass>(string message) where TClass : class;

        void Critical(string message);
        
        void Critical<TClass>(Exception exception) where TClass : class;

        void Critical(Exception exception);

        void Critical<TClass>(string message, Exception exception) where TClass : class;

        void Critical(string message, Exception exception);
    }
}