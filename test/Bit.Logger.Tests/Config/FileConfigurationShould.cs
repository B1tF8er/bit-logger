namespace Bit.Logger.Tests
{
    using Bit.Logger.Config;
    using FormatProviders;
    using Moq;
    using System;
    using Xunit;
    using static Enums.Level;

    public class FileConfigurationShould
    {
        private readonly Mock<FileConfiguration> sut;

        public FileConfigurationShould()
        {
            sut = new Mock<FileConfiguration>(MockBehavior.Strict);
        }

        [Fact]
        public void GetDefault_Format()
        {
            const string expected = "{0:Level} {1:DateTimeIso} [{2:Caller}::{3:Method}] {4:Message} {5:Exception}";

            var actual = sut.Object.Format;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_Format()
        {
            const string expected = "{4:Message} {5:Exception} from [{2:Caller}::{3:Method}]";
            sut.Object.Format = expected;

            var actual = sut.Object.Format;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenFormatIsNull()
        {
            const string expectedMessage = "Value cannot be null. (Parameter 'format')";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.Format = null);

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenFormatIsEmptyString()
        {
            const string expectedMessage = "Value cannot be null. (Parameter 'format')";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.Format = string.Empty);

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenFormatIsWhiteSpace()
        {
            const string expectedMessage = "Value cannot be null. (Parameter 'format')";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.Format = new string(' ', 2));

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void GetDefault_FormatProvider()
        {
            var expected = new DefaultFormatProvider();

            var actual = sut.Object.FormatProvider;

            Assert.IsType<DefaultFormatProvider>(expected);
            Assert.IsType<DefaultFormatProvider>(actual);
        }

        [Fact]
        public void SetCustom_FormatProvider()
        {
            IFormatProvider expected = default;
            sut.Object.FormatProvider = expected;

            var actual = sut.Object.FormatProvider;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_FileLogLocation()
        {
            var actual = sut.Object.FileLogLocation;

            Assert.IsType<string>(actual);
            Assert.False(string.IsNullOrWhiteSpace(actual));
        }

        [Fact]
        public void SetCustom_FileLogLocation()
        {
            const string expected = @"C:\Logs\File";
            sut.Object.FileLogLocation = expected;

            var actual = sut.Object.FileLogLocation;

            Assert.IsType<string>(expected);
            Assert.IsType<string>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_CustomLevelAndFileLogLocation()
        {
            const string fileLogLocation = @"C:\Logs\File";
            var expected = $"Level:{Critical}, DatabaseLogLocation:{fileLogLocation}";

            sut.Object.Level = Critical;
            sut.Object.FileLogLocation = fileLogLocation;

            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }
    }
}
