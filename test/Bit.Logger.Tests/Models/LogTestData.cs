namespace Bit.Logger.Tests
{
    using Models;
    using Enums;
    using System;
    using System.Collections.Generic;
    using static Constants;

    public static class LogTestData
    {
        public static IEnumerable<object[]> Logs()
        {
            yield return new object[]
            {
                new Log
                {
                    Id = $"{Guid.NewGuid()}",
                    Level = $"{Level.Critical}",
                    Message = "Test",
                    Date = $"{new DateTime(2020, 10, 18).ToString(DateTimeFormat)}",
                    Class = nameof(LogShould),
                    Method = "Test",
                    Exception = $"{new InvalidProgramException("test")}"
                }
            };

            yield return new object[]
            {
                new Log
                {
                    Id = $"{Guid.NewGuid()}",
                    Level = $"{Level.Debug}",
                    Message = "Test",
                    Date = $"{new DateTime(2020, 10, 18).ToString(DateTimeFormat)}",
                    Class = nameof(LogShould),
                    Method = "Test",
                    Exception = null
                }
            };

            yield return new object[]
            {
                new Log
                {
                    Id = $"{Guid.NewGuid()}",
                    Level = $"{Level.Error}",
                    Message = "Test",
                    Date = $"{new DateTime(2020, 10, 18).ToString(DateTimeFormat)}",
                    Class = nameof(LogShould),
                    Method = "Test",
                    Exception = $"{new InvalidOperationException("test")}"
                }
            };

            yield return new object[]
            {
                new Log
                {
                    Id = $"{Guid.NewGuid()}",
                    Level = $"{Level.Information}",
                    Message = "Test",
                    Date = $"{new DateTime(2020, 10, 18).ToString(DateTimeFormat)}",
                    Class = nameof(LogShould),
                    Method = "Test",
                    Exception = null
                }
            };

            yield return new object[]
            {
                new Log
                {
                    Id = $"{Guid.NewGuid()}",
                    Level = $"{Level.Warning}",
                    Message = "Test",
                    Date = $"{new DateTime(2020, 10, 18).ToString(DateTimeFormat)}",
                    Class = nameof(LogShould),
                    Method = "Test",
                    Exception = null
                }
            };
        }
    }
}
