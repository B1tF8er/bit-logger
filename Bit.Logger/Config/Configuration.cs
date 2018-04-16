namespace Bit.Logger.Config
{
    public class Configuration
    {
        public bool ShowDate { get; set; } = false;

        public bool ShowTime { get; set; } = false;

        public bool ShowLevel { get; set; } = true;

        public Level Level { get; set; } = Level.Information;
    }
}