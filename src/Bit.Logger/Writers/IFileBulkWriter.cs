namespace Bit.Logger.Writers
{
    using System.Collections.Generic;

    public interface IFileBulkWriter
    {
        void ToFileAsync(IEnumerable<string> logs);
    }
}
