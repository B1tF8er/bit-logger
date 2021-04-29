namespace Bit.Logger.Tests
{
    using Bit.Logger.Config;
    using Moq;
    using Xunit;
    using static Enums.Level;

    public class DatabaseConfigurationShould
    {
        private readonly Mock<DatabaseConfiguration> sut;

        public DatabaseConfigurationShould()
        {
            sut = new Mock<DatabaseConfiguration>(MockBehavior.Strict);
        }

        [Fact]
        public void GetDefault_DatabaseLogLocation()
        {
            var actual = sut.Object.DatabaseLogLocation;

            Assert.IsType<string>(actual);
            Assert.False(string.IsNullOrWhiteSpace(actual));
        }

        [Fact]
        public void SetCustom_DatabaseLogLocation()
        {
            const string expected = @"C:\Logs\Database";
            sut.Object.DatabaseLogLocation = expected;

            var actual = sut.Object.DatabaseLogLocation;

            Assert.IsType<string>(expected);
            Assert.IsType<string>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_CustomLevelAndDatabaseLogLocation()
        {
            const string databaseLogLocation = @"C:\Logs\Database";
            var expected = $"Level:{Critical}, DatabaseLogLocation:{databaseLogLocation}";

            sut.Object.Level = Critical;
            sut.Object.DatabaseLogLocation = databaseLogLocation;

            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }
    }
}
