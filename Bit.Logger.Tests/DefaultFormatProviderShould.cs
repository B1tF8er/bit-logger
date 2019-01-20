namespace Bit.Logger.Tests
{
    using Enums;
    using FormatProviders;
    using Moq;
    using System;
    using Xunit;

    public class DefaultFormatProviderShould
    {
        private readonly Mock<DefaultFormatProvider> sut;

        public DefaultFormatProviderShould()
        {
            sut = new Mock<DefaultFormatProvider>(MockBehavior.Strict);
        }

        [Fact]
        public void GetFormat_ObjectAsDefaultCustomFormatter_WhenTypeIsCustomFormatter()
        {
            var actual = sut.Object.GetFormat(typeof(ICustomFormatter));

            Assert.NotNull(actual);
            Assert.IsType<DefaultCustomFormatter>(actual);
        }

        [Fact]
        public void GetFormat_ObjectAsNull_WhenTypeIsNotCustomFormatter()
        {
            var actual = sut.Object.GetFormat(typeof(IFormatProvider));

            Assert.Null(actual);
        }
    }
}
