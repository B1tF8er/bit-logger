namespace Bit.Logger.Config
{
    public class Configuration
    {
        public bool ShowDate { get; set; } = true;

        public bool ShowTime { get; set; } = true;

        public bool ShowLevel { get; set; } = true;

        public Level Level { get; set; } = Level.Information;
    }
}