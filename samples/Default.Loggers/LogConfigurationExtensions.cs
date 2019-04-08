using Bit.Logger.Config;
using Bit.Logger.Enums;
using static Bit.Logger.Enums.Level;

namespace Default.Loggers
{
    internal class LogConfigurationExtensions
    {
        internal static Configuration CreateConfiguration(DateType dateType, ShowLevel showLevel, Level level = Information) =>
            new Configuration
            {
                DateTypeFormat = dateType,
                ShowLevel = showLevel,
                Level = level
            };
    }
}