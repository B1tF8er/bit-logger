namespace Bit.Logger.Config
{
    using Enums;
    using System;

    public interface IConfiguration
    {
        DateType DateTypeFormat { get; set; }

        ShowLevel ShowLevel { get; set; }

        Level Level { get; set; }

        IFormatProvider FormatProvider { get; set; }

        string Format { get; set; }

        int BufferSize { get; set; }

        string DatabaseLogLocation { get; set; }

        string FileLogLocation { get; set; }
    }
}
