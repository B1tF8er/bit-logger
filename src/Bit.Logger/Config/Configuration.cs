namespace Bit.Logger.Config
{
    using Enums;
    using System.Text;
    using static Enums.Level;

    public abstract class Configuration : IConfiguration
    {
        public DateType DateTypeFormat { get; set; }

        public ShowLevel ShowLevel { get; set; }

        public Level Level { get; set; } = Information;

        public int BufferSize { get; set; } = 0;

        public override string ToString() =>
            new StringBuilder()
                .AppendLine($"DateTypeFormat: {DateTypeFormat}")
                .AppendLine($"ShowLevel: {ShowLevel}")
                .AppendLine($"Level: {Level}")
                .AppendLine($"BufferSize: {BufferSize}")
                .ToString();
    }
}
