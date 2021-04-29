namespace Bit.Logger.Config
{
    using Enums;
    using FormatProviders;
    using System;
    using System.Text;
    using static Enums.ShowLevel;
    using static Helpers.StringExtensions;

    public class FormatConfiguration : Configuration, IFormatConfiguration
    {
        public IFormatProvider FormatProvider { get; set; } = new DefaultFormatProvider();

        private string format;

        public string Format
        {
            get => format ?? GetDefaultFormat();
            set => format = value.IsNullOrEmptyOrWhiteSpace()
                ? throw new ArgumentNullException(nameof(format))
                : value;
        }

        private string GetDefaultFormat() =>
            new StringBuilder()
                .Append(ShowLevel.Equals(Yes) ? "{0:" + Token.Level + "} " : string.Empty)
                .Append("{1:").Append(DateTypeFormat.ToString()).Append("} ")
                .Append("[{2:").Append(Token.Caller).Append("}::{3:").Append(Token.Method).Append("}] ")
                .Append("{4:").Append(Token.Message).Append("} ")
                .Append("{5:").Append(Token.Exception).Append('}')
                .ToString();

        public override string ToString() =>
            new StringBuilder(base.ToString())
                .AppendLine($"Format: {Format}")
                .ToString();
    }
}
