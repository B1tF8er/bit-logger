namespace Bit.Logger.Tests
{
    using FormatProviders;
    using Moq;
    using System;
    using Xunit;

    public class DefaultCustomFormatterShould
    {
        private readonly Mock<DefaultCustomFormatter> sut;
        private readonly IFormatProvider formatProvider;

        public DefaultCustomFormatterShould()
        {
            sut = new Mock<DefaultCustomFormatter>(MockBehavior.Strict);
            formatProvider = default;
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.LevelsTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsLevel(string format, object argument, string expected)
        {
            var actual = sut.Object.Format(format, argument, formatProvider);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.DateTimeTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsDateTime(string format, DateTime? argument, string expectedFormat)
        {
            var expected = argument?.ToString(expectedFormat) ?? string.Empty;

            var actual = sut.Object.Format(format, argument, formatProvider);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.DateTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsDate(string format, DateTime? argument, string expectedFormat)
        {
            var expected = argument?.ToString(expectedFormat) ?? string.Empty;

            var actual = sut.Object.Format(format, argument, formatProvider);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.TimeTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsTime(string format, DateTime? argument, string expectedFormat)
        {
            var expected = argument?.ToString(expectedFormat) ?? string.Empty;

            var actual = sut.Object.Format(format, argument, formatProvider);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.CallersTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsCaller(string format, string argument, string expected)
        {
            var actual = sut.Object.Format(format, argument, formatProvider);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.ExceptionsTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsException(string format, Exception argument, string expected)
        {
            var actual = sut.Object.Format(format, argument, formatProvider);

            Assert.Equal(expected, actual);
        }
    }
}