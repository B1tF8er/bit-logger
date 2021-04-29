namespace Bit.Logger.Config
{
    using System;

    public interface IFormatConfiguration : IConfiguration
    {
        string Format { get; set; }

        IFormatProvider FormatProvider { get; set; }
    }
}
