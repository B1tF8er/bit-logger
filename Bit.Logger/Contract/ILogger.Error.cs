namespace Bit.Logger.Contract
{
    using System;

    public partial interface ILogger
    {
        void Error<TClass>(string message) where TClass : class;

        void Error(string message);

        void Error<TClass>(Exception exception) where TClass : class;

        void Error(Exception exception);

        void Error<TClass>(string message, Exception exception) where TClass : class;

        void Error(string message, Exception exception);
    }
}
