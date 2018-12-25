namespace Bit.Logger.FileBuffer
{
    using System;
    using System.Collections.Generic;

    public interface IFileBuffer
    {
        IDictionary<string, string> Logs { get; set; }
        object Padlock { get; }
    }
}