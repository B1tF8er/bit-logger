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

    public class LoggerShould
    {
        private readonly Mock<Logger> sut;

        public LoggerShould()
        {
            sut = new Mock<Logger>(MockBehavior.Strict);
        }

        [Fact]
        public void AddConsoleSource_AndReturnConsoleSource()
        {
            sut.Object.AddConsoleSource(It.IsAny<ConsoleConfiguration>());

            var actual = sut.Object.Sources.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IConsoleSource);
        }

        [Fact]
        public void AddDatabaseSource_AndReturnDatabaseSource()
        {
            sut.Object.AddDatabaseSource(It.IsAny<DatabaseConfiguration>());

            var actual = sut.Object.Sources.Single();

            Assert.NotNull(actual);
            Assert.True(actual is IDatabaseSource);
        }

        [Fact]
        public void AddFileSource_AndReturnFileSource()
        {
            sut.Object.AddFileSource(It.IsAny<FileConfiguration>());

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

            var actual = sut.Object.Sources.FirstOrDefault();

            Assert.NotNull(actual);
            Assert.True(actual is ISource);
        }

        [Fact]
        public void Throw_ArgumentNullException_WhenAddSourceHasNullValue()
        {
            const string expectedMessage = "Value cannot be null. (Parameter 'source')";

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

            const string expectedMessage = "Value cannot be null. (Parameter 'sources')";

            var actualException = Assert.Throws<ArgumentNullException>(() => sut.Object.AddSources(customSources));

            Assert.Equal(expectedMessage, actualException.Message);
        }

        [Fact]
        public void Return_SourcesAdded_WhenToStringIsCalled()
        {
            static string getSource(string name, bool newLine = true) =>
                $"Bit.Logger.Sources.{name}.{name}Source{(newLine ? Environment.NewLine : string.Empty)}";

            var sut = new Logger();
            var expected = $"{getSource("Console")}{getSource("Database")}{getSource("File", false)}";

            sut.AddConsoleSource().AddDatabaseSource().AddFileSource();

            var actual = sut.ToString();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LogMessages_WithLevel()
        {
            SetBaseSources(level: Trace, showLevel: Yes, bufferSize: 0);
            sut.LogAllLevels();
        }

        [Fact]
        public void LogMessages_WithoutLevel()
        {
            SetBaseSources(level: Trace, showLevel: No, bufferSize: 2);
            sut.LogAllLevels();
        }

        private void SetBaseSources(Level level, ShowLevel showLevel, int bufferSize)
        {
            sut.Object.AddConsoleSource(new ConsoleConfiguration
            {
                Level = level,
                ShowLevel = showLevel,
                BufferSize = bufferSize
            });

            sut.Object.AddDatabaseSource(new DatabaseConfiguration
            {
                Level = level,
                ShowLevel = showLevel,
                BufferSize = bufferSize
            });

            sut.Object.AddFileSource(new FileConfiguration
            {
                Level = level,
                ShowLevel = showLevel,
                BufferSize = bufferSize
            });
        }
    }
}
