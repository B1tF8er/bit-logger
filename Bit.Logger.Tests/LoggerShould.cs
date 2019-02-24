namespace Bit.Logger.Tests
{
    using Config;
    using Contract;
    using Enums;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;
    using static Enums.Level;
    using static Enums.ShowLevel;
    using static LoggerExtensions;

    public class LoggerShould
    {
        private readonly Mock<Logger> sut;

        public LoggerShould()
        {
            sut = new Mock<Logger>(MockBehavior.Default);
        }

        [Fact]
        public void AddConsoleSource_AndReturnConsoleSource()
        {
            sut.Object.AddConsoleSource(It.IsAny<Configuration>());

            var actual = sut.Object.Sources.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IConsoleSource);
        }

        [Fact]
        public void AddDatabaseSource_AndReturnDatabaseSource()
        {
            sut.Object.AddDatabaseSource(It.IsAny<Configuration>());

            var actual = sut.Object.Sources.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IDatabaseSource);
        }

        [Fact]
        public void AddFileSource_AndReturnFileSource()
        {
            sut.Object.AddFileSource(It.IsAny<Configuration>());

            var actual = sut.Object.Sources.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IFileSource);
        }

        [Fact]
        public void AddSource_AndReturnISource()
        {
            var customLogger = new Mock<ISource>().Object;

            sut.Object.AddSource(customLogger);

            var actual = sut.Object.Sources.Single();

            Assert.NotNull(actual);
            Assert.True(actual is ISource);
        }

        [Fact]
        public void AddSources_AndReturnISource()
        {
            var customLogger = new Mock<ISource>().Object;
            var customLoggers = new List<ISource>
            {
                customLogger, customLogger, customLogger
            };

            sut.Object.AddSources(customLoggers);

            var actual = sut.Object.Sources.First();

            Assert.NotNull(actual);
            Assert.True(actual is ISource);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenAddSourceHasNullValue()
        {
            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: source";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.AddSource(null));

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenAddSourcesHasANullValue()
        {
            var customSource = new Mock<ISource>().Object;
            var customSources = new List<ISource>
            {
                customSource, null, customSource
            };

            var expectedMessage = $"Value cannot be null.{Environment.NewLine}Parameter name: sources";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.AddSources(customSources));

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Return_SourcesAdded_WhenToStringIsCalled()
        {
            var expected = $"Console{Environment.NewLine}Database{Environment.NewLine}File{Environment.NewLine}";
            
            sut.Setup(c => c.ToString()).Returns(expected);

            var actual = sut.Object.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LogFiveHundredMessages_WithLevel()
        {
            SetBaseSources(level: Trace, showLevel: Yes, bufferSize: 0);

            foreach (var index in Enumerable.Range(0, 30))
                sut.LogAllLevels();
        }

        [Fact]
        public void LogFiveHundredMessages_WithoutLevel()
        {
            SetBaseSources(level: Trace, showLevel: No, bufferSize: 500);

            foreach (var index in Enumerable.Range(0, 30))
                sut.LogAllLevels();
        }

        private void SetBaseSources(Level level, ShowLevel showLevel, int bufferSize)
        {
            var configuration = new Configuration
            {
                Level = level,
                ShowLevel = showLevel,
                BufferSize = bufferSize
            };

            sut.Object.AddConsoleSource(configuration);
            sut.Object.AddDatabaseSource(configuration);
            sut.Object.AddFileSource(configuration);
        }
    }
}
