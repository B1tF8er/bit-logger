using Bit.Logger.Enums;
using static Default.Loggers.JsonConvertExtensions;

namespace Default.Loggers
{
    public struct Message
    {
        public Level Level { get; }
        public string When { get; }

        private Message(Level level, string when)
        {
            Level = level;
            When = when;
        }

        internal static string Trace() =>
            new Message(Level.Trace, Constants.When.Trace).ToString();

        internal static string Debug() =>
            new Message(Level.Debug, Constants.When.Debug).ToString();

        internal static string Verbose() =>
            new Message(Level.Verbose, Constants.When.Verbose).ToString();

        internal static string Information() =>
            new Message(Level.Information, Constants.When.Information).ToString();

        internal static string Warning() =>
            new Message(Level.Warning, Constants.When.Warning).ToString();

        internal static string Error() =>
            new Message(Level.Error, Constants.When.Error).ToString();

        internal static string Critical() =>
            new Message(Level.Critical, Constants.When.Critical).ToString();

        public override string ToString() => this.Serialize();
    }
}
