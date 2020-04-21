namespace Bit.Logger.Writers
{
    using Models;
    using System.Collections.Generic;

    public interface IDatabaseBulkWriter
    {
        void ToDatabaseAsync(IEnumerable<Log> logs);
    }
}
