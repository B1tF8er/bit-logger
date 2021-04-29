namespace Bit.Logger.Config
{
    using Enums;
    using System;

    public interface IConfiguration
    {
        DateType DateTypeFormat { get; set; }

        ShowLevel ShowLevel { get; set; }

        Level Level { get; set; }

        int BufferSize { get; set; }
    }
}
