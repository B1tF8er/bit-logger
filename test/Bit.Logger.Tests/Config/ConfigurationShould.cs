namespace Bit.Logger.Tests
{
    using Config;
    using Enums;
    using FormatProviders;
    using Moq;
    using System;
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
        public void GetDefault_Format()
        {
            var expected = "{0:Level} {1:DateTimeIso} [{2:Caller}::{3:Method}] {4:Message} {5:Exception}";

            var actual = sut.Object.Format;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_Format()
        {
            var expected = "{4:Message} {5:Exception} from [{2:Caller}::{3:Method}]";
            sut.Object.Format = expected;

            var actual = sut.Object.Format;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenFormatIsNull()
        {
            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: format";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.Format = null);

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenFormatIsEmptyString()
        {
            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: format";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.Format = string.Empty);

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenFormatIsWhiteSpace()
        {
            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: format";

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
        public void GetDefault_Level()
        {
            var expected = Level.Information;

            var actual = sut.Object.Level;

            Assert.IsType<Level>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_Level()
        {
            var expected = Level.None;
            sut.Object.Level = expected;

            var actual = sut.Object.Level;

            Assert.IsType<Level>(expected);
            Assert.IsType<Level>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_ShowLevel()
        {
            var expected = Yes;

            var actual = sut.Object.ShowLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_ShowLevel()
        {
            var expected = No;
            sut.Object.ShowLevel = expected;

            var actual = sut.Object.ShowLevel;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_DateTypeFormat()
        {
            var expected = DateTimeIso;

            var actual = sut.Object.DateTypeFormat;

            Assert.IsType<DateType>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_DateTypeFormat()
        {
            var expected = TimeIso;
            sut.Object.DateTypeFormat = expected;

            var actual = sut.Object.DateTypeFormat;

            Assert.IsType<DateType>(expected);
            Assert.IsType<DateType>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_DefaultLevelAndFormat()
        {
            var sut = new Configuration();
            var defaultFormat = "{0:Level} {1:DateTimeIso} [{2:Caller}::{3:Method}] {4:Message} {5:Exception}";
            var expected = $"Level:{Information}, Format:{defaultFormat}";

            var actual = sut.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_CustomLevelAndFormat()
        {
            var customFormat = "{1:DateTimeIso} - {0:Level} {4:Message} {5:Exception} at [{2:Caller}::{3:Method}]";
            var expected = $"Level:{Critical}, Format:{customFormat}";

            sut.Object.Level = Critical;
            sut.Object.Format = customFormat;

            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetDefault_BufferSize()
        {
            var expected = 0;

            var actual = sut.Object.BufferSize;

            Assert.IsType<int>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_BufferSize()
        {
            var expected = 50;
            sut.Object.BufferSize = expected;

            var actual = sut.Object.BufferSize;

            Assert.IsType<int>(expected);
            Assert.IsType<int>(actual);
            Assert.Equal(expected, actual);
        }
    }
}
