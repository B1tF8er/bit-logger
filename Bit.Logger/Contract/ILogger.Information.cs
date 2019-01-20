namespace Bit.Logger.Contract
{
    using System;

    public partial interface ILogger
    {
        void Information<TClass>(string message) where TClass : class;

        void Information(string message);

        void Information<TClass>(Exception exception) where TClass : class;

        void Information(Exception exception);

        void Information<TClass>(string message, Exception exception) where TClass : class;

        void Information(string message, Exception exception);
    }
}
