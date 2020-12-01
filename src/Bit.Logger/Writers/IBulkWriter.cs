namespace Bit.Logger.Writers
{
    using System.Collections.Generic;

    public interface IBulkWriter<TLog> where TLog : class
    {
        void Write(IEnumerable<TLog> logs);
    }
}
