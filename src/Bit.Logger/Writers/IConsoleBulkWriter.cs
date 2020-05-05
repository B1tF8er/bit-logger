namespace Bit.Logger.Writers
{
    using System.Collections.Generic;

    public interface IConsoleBulkWriter
    {
        void ToConsole(IEnumerable<string> logs);
    }
}
