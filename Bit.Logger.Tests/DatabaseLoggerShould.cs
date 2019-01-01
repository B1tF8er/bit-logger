namespace Bit.Logger.Tests
{
    using Factory;
    using Config;
    using Moq;
    using Xunit;
    using static Constants;

    public class DatabaseLoggerShould
    {
        private readonly Mock<ILoggerFactory> sut;

        public DatabaseLoggerShould()
        {
            sut = new Mock<ILoggerFactory>(MockBehavior.Strict);

            sut
                .SetupCallsWithSource<DatabaseLoggerShould>()
                .SetupCallsWithoutSource()
                .Setup(l => l.AddDatabaseSource(It.IsAny<Configuration>()))
                .Returns(sut.Object);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Trace<DatabaseLoggerShould>(TestMessage);
            sut.Object.Trace<DatabaseLoggerShould>(TestException);
            sut.Object.Trace<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Trace<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Trace<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Trace<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsTrace_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Trace(TestMessage);
            sut.Object.Trace(TestException);
            sut.Object.Trace(TestMessage, TestException);

            sut.Verify(l => l.Trace(TestMessage), Times.Once);
            sut.Verify(l => l.Trace(TestException), Times.Once);
            sut.Verify(l => l.Trace(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Debug<DatabaseLoggerShould>(TestMessage);
            sut.Object.Debug<DatabaseLoggerShould>(TestException);
            sut.Object.Debug<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Debug<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Debug<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Debug<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsDebug_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Debug(TestMessage);
            sut.Object.Debug(TestException);
            sut.Object.Debug(TestMessage, TestException);

            sut.Verify(l => l.Debug(TestMessage), Times.Once);
            sut.Verify(l => l.Debug(TestException), Times.Once);
            sut.Verify(l => l.Debug(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Verbose<DatabaseLoggerShould>(TestMessage);
            sut.Object.Verbose<DatabaseLoggerShould>(TestException);
            sut.Object.Verbose<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Verbose<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Verbose<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsVerbose_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Verbose(TestMessage);
            sut.Object.Verbose(TestException);
            sut.Object.Verbose(TestMessage, TestException);

            sut.Verify(l => l.Verbose(TestMessage), Times.Once);
            sut.Verify(l => l.Verbose(TestException), Times.Once);
            sut.Verify(l => l.Verbose(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Information<DatabaseLoggerShould>(TestMessage);
            sut.Object.Information<DatabaseLoggerShould>(TestException);
            sut.Object.Information<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Information<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Information<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Information<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsInformation_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Information(TestMessage);
            sut.Object.Information(TestException);
            sut.Object.Information(TestMessage, TestException);

            sut.Verify(l => l.Information(TestMessage), Times.Once);
            sut.Verify(l => l.Information(TestException), Times.Once);
            sut.Verify(l => l.Information(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Warning<DatabaseLoggerShould>(TestMessage);
            sut.Object.Warning<DatabaseLoggerShould>(TestException);
            sut.Object.Warning<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Warning<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Warning<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Warning<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsWarning_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Warning(TestMessage);
            sut.Object.Warning(TestException);
            sut.Object.Warning(TestMessage, TestException);

            sut.Verify(l => l.Warning(TestMessage), Times.Once);
            sut.Verify(l => l.Warning(TestException), Times.Once);
            sut.Verify(l => l.Warning(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Error<DatabaseLoggerShould>(TestMessage);
            sut.Object.Error<DatabaseLoggerShould>(TestException);
            sut.Object.Error<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Error<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Error<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Error<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsError_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Error(TestMessage);
            sut.Object.Error(TestException);
            sut.Object.Error(TestMessage, TestException);

            sut.Verify(l => l.Error(TestMessage), Times.Once);
            sut.Verify(l => l.Error(TestException), Times.Once);
            sut.Verify(l => l.Error(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithSourceClass()
        {
            sut.Object.Critical<DatabaseLoggerShould>(TestMessage);
            sut.Object.Critical<DatabaseLoggerShould>(TestException);
            sut.Object.Critical<DatabaseLoggerShould>(TestMessage, TestException);

            sut.Verify(l => l.Critical<DatabaseLoggerShould>(TestMessage), Times.Once);
            sut.Verify(l => l.Critical<DatabaseLoggerShould>(TestException), Times.Once);
            sut.Verify(l => l.Critical<DatabaseLoggerShould>(TestMessage, TestException), Times.Once);
        }

        [Fact]
        public void LogMessage_AsCritical_OncePerMethodOverload_WithoutSourceClass()
        {
            sut.Object.Critical(TestMessage);
            sut.Object.Critical(TestException);
            sut.Object.Critical(TestMessage, TestException);

            sut.Verify(l => l.Critical(TestMessage), Times.Once);
            sut.Verify(l => l.Critical(TestException), Times.Once);
            sut.Verify(l => l.Critical(TestMessage, TestException), Times.Once);
        }
    }
}
