namespace Bit.Logger.FormatProviders
{
    using System;
    using System.Linq;

    public class DefaultCustomFormatter : ICustomFormatter
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            try
            {
                if (arg == null)
                    return string.Empty;

                if (format == "level")
                    return $"<{arg.ToString().ToUpper()}>";
                    
                if (format == "datetime")
                    return Convert.ToDateTime(arg).ToString("yyyy-MM-dd HH:mm:ss");

                if (format == "date")
                    return Convert.ToDateTime(arg).ToString("yyyy-MM-dd");

                if (format == "time")
                    return Convert.ToDateTime(arg).ToString("HH:mm:ss");

                if (format == "short")
                    return $"{arg.ToString().Split(".").LastOrDefault()}";

                if (format == "exception")
                    return $"EXCEPTION: {((Exception)arg).ToString()}";

                return arg.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}