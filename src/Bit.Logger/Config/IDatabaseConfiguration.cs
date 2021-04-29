namespace Bit.Logger.Config
{
    public interface IDatabaseConfiguration : IConfiguration
    {
        string DatabaseLogLocation { get; set; }
    }
}
