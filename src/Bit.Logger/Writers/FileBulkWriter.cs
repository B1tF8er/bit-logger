namespace Bit.Logger.Writers
{
    using Helpers;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using static Helpers.EnumerableExtensions;

    internal class FileBulkWriter : IBulkWriter<string>
    {
        private readonly IFileLogPathResolver fileLogPathResolver;

        public FileBulkWriter(IFileLogPathResolver fileLogPathResolver) =>
            this.fileLogPathResolver = fileLogPathResolver;

        public async void Write(IEnumerable<string> logs)
        {
            using var logWriter = new StreamWriter(fileLogPathResolver.CurrentLogPath(), true, Encoding.UTF8);
            await logWriter.WriteAsync(logs.ToAppendedString()).ConfigureAwait(false);
        }
    }
}
