namespace Bit.Logger
{
    using System;
    
    public partial interface ILogger
    {
        void Warning<TClass>(string message) where TClass : class;

        void Warning(string message);
        
        void Warning<TClass>(Exception exception) where TClass : class;

        void Warning(Exception exception);

        void Warning<TClass>(string message, Exception exception) where TClass : class;

        void Warning(string message, Exception exception);
    }    
}