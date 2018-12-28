namespace Bit.Logger.Tests
{
    using Enums;
    using FormatProviders;
    using Moq;
    using System;
    using Xunit;
    using static Constants;

    public class DefaultCustomFormatterShould
    {
        private readonly Mock<DefaultCustomFormatter> sut;

        public DefaultCustomFormatterShould()
        {
            sut = new Mock<DefaultCustomFormatter>();
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.LevelsTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsLevel(string format, Level level, string expected)
        {
            var actual = sut.Object.Format(format, level, default(IFormatProvider));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.DateTimeTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsDateTime(string format, DateTime date, string expectedFormat)
        {
            var expected = date.ToString(expectedFormat);

            var actual = sut.Object.Format(format, date, default(IFormatProvider));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.DateTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsDate(string format, DateTime date, string expectedFormat)
        {
            var expected = date.ToString(expectedFormat);

            var actual = sut.Object.Format(format, date, default(IFormatProvider));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.TimeTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsTime(string format, DateTime date, string expectedFormat)
        {
            var expected = date.ToString(expectedFormat);

            var actual = sut.Object.Format(format, date, default(IFormatProvider));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.CallersTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsCaller(string format, string caller, string expected)
        {
            var actual = sut.Object.Format(format, caller, default(IFormatProvider));

            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(DefaultCustomFormatterTestData.ExceptionsTestData), MemberType = typeof(DefaultCustomFormatterTestData))]
        public void Format_Argument_AsException(string format, Exception exception, string expected)
        {
            var actual = sut.Object.Format(format, exception, default(IFormatProvider));

            Assert.Equal(expected, actual);
        }
    }
}