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
            var expected = "{0:level} {1:datetime} [{2:caller}::{3:method}] {4:message} {5:exception}";

            var actual = sut.Object.Format;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_Format()
        {
            var expected = "custom format test set";
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

            var actual = sut.Object.Level;

            Assert.IsType<Level>(expected);
            Assert.IsType<Level>(actual);
        }

        [Fact]
        public void GetDefault_ShowLevel()
        {
            var expected = true;

            var actual = sut.Object.ShowLevel;

            Assert.IsType<bool>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_ShowLevel()
        {
            var expected = false;

            var actual = sut.Object.ShowLevel;

            Assert.IsType<bool>(expected);
            Assert.IsType<bool>(actual);
        }

        [Fact]
        public void GetDefault_DateTypeFormat()
        {
            var expected = DateType.DateTime;

            var actual = sut.Object.DateTypeFormat;

            Assert.IsType<DateType>(actual);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetCustom_DateTypeFormat()
        {
            var expected = Time;

            var actual = sut.Object.DateTypeFormat;

            Assert.IsType<DateType>(expected);
            Assert.IsType<DateType>(actual);
        }

        [Fact]
        public void ToString_DefaultLevelAndFormat()
        {
            var defaultFormat = "{0:level} {1:datetime} [{2:caller}::{3:method}] {4:message} {5:exception}";
            var expected = $"Level:{Information}, Format:{defaultFormat}";

            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ToString_CustomLevelAndFormat()
        {
            var customFormat = "{1:datetime} - {0:level} {4:message} {5:exception} at [{2:caller}::{3:method}]";
            var expected = $"Level:{Critical}, Format:{customFormat}";

            sut.Object.Level = Critical;
            sut.Object.Format = customFormat;

            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }
    }
}