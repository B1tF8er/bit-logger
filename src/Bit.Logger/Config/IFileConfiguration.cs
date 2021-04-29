namespace Bit.Logger.Config
{
    public interface IFileConfiguration : IConfiguration
    {
        string FileLogLocation { get; set; }
    }
}
