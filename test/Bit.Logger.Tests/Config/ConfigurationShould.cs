namespace Bit.Logger.Tests
{
    using Bit.Logger.Config;
    using Enums;
    using Moq;
    using Xunit;
    using static Enums.DateType;
    using static Enums.Level;
    using static Enums.ShowLevel;

    public class ConfigurationShould
    {
        private readonly Mock<Configuration> sut;

        public ConfigurationShould()
        {
            sut = new Mock<Configuration>(MockBehavior.Strict);
        }

        [Fact]
        public void GetDefault_Level()
        {
            const Level expected = Information;

            var actual = sut.Object.Level;

            Assert.IsType<Level>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_Level()
        {
            const Level expected = None;
            sut.Object.Level = expected;

            var actual = sut.Object.Level;

            Assert.IsType<Level>(expected);
            Assert.IsType<Level>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_ShowLevel()
        {
            const ShowLevel expected = Yes;

            var actual = sut.Object.ShowLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_ShowLevel()
        {
            const ShowLevel expected = No;
            sut.Object.ShowLevel = expected;

            var actual = sut.Object.ShowLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_DateTypeFormat()
        {
            const DateType expected = DateTimeIso;

            var actual = sut.Object.DateTypeFormat;

            Assert.IsType<DateType>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_DateTypeFormat()
        {
            const DateType expected = TimeIso;
            sut.Object.DateTypeFormat = expected;

            var actual = sut.Object.DateTypeFormat;

            Assert.IsType<DateType>(expected);
            Assert.IsType<DateType>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_BufferSize()
        {
            const int expected = 0;

            var actual = sut.Object.BufferSize;

            Assert.IsType<int>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_BufferSize()
        {
            const int expected = 50;
            sut.Object.BufferSize = expected;

            var actual = sut.Object.BufferSize;

            Assert.IsType<int>(expected);
            Assert.IsType<int>(actual);
            Assert.Equal(expected, actual);
        }
    }
}
