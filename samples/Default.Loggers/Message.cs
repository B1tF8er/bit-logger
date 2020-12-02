namespace Default.Loggers
{
    using Bit.Logger.Enums;

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
            new Message(Level.Trace, Constants.When.Trace).Serialize();

        internal static string Debug() =>
            new Message(Level.Debug, Constants.When.Debug).Serialize();

        internal static string Verbose() =>
            new Message(Level.Verbose, Constants.When.Verbose).Serialize();

        internal static string Information() =>
            new Message(Level.Information, Constants.When.Information).Serialize();

        internal static string Warning() =>
            new Message(Level.Warning, Constants.When.Warning).Serialize();

        internal static string Error() =>
            new Message(Level.Error, Constants.When.Error).Serialize();

        internal static string Critical() =>
            new Message(Level.Critical, Constants.When.Critical).Serialize();

        public override bool Equals(object obj) =>
            obj is Message message
            && Level == message.Level
            && When == message.When;

        public override int GetHashCode() =>
            Level.GetHashCode() ^ When.GetHashCode();

        public static bool operator ==(Message left, Message right) =>
            left.Equals(right);

        public static bool operator !=(Message left, Message right) =>
            !(left == right);
    }
}
