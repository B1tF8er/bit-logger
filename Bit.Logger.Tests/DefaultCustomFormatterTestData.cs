namespace Bit.Logger.Tests
{
    using Enums;
    using System;
    using System.Collections.Generic;
    using static Constants;

    public static class DefaultCustomFormatterTestData
    {
        public static IEnumerable<object[]> LevelsTestData()
        {
            yield return new object[]
            {
                LevelToken,
                Level.Critical
            };

            yield return new object[]
            {
                LevelToken,
                Level.Debug
            };

            yield return new object[]
            {
                LevelToken,
                Level.Error
            };

            yield return new object[]
            {
                LevelToken,
                Level.Information
            };

            yield return new object[]
            {
                LevelToken,
                Level.None
            };

            yield return new object[]
            {
                LevelToken,
                Level.Trace
            };

            yield return new object[]
            {
                LevelToken,
                Level.Verbose
            };

            yield return new object[]
            {
                LevelToken,
                Level.Warning
            };
        }

        public static IEnumerable<object[]> DateTimeTestData()
        {
            yield return new object[]
            {
                DateTimeToken,
                DateTimeFormat,
                DateTime.Now
            };

            yield return new object[]
            {
                DateTimeToken,
                DateTimeFormat,
                DateTime.Now.AddHours(1)
            };

            yield return new object[]
            {
                DateTimeToken,
                DateTimeFormat,
                DateTime.Now.AddDays(1)
            };
        }

        public static IEnumerable<object[]> DateTestData()
        {
            yield return new object[]
            {
                DateToken,
                DateFormat,
                DateTime.Now
            };

            yield return new object[]
            {
                DateToken,
                DateFormat,
                DateTime.Now.AddHours(1)
            };

            yield return new object[]
            {
                DateToken,
                DateFormat,
                DateTime.Now.AddDays(1)
            };
        }

        public static IEnumerable<object[]> TimeTestData()
        {
            yield return new object[]
            {
                TimeToken,
                TimeFormat,
                DateTime.Now
            };

            yield return new object[]
            {
                TimeToken,
                TimeFormat,
                DateTime.Now.AddHours(1)
            };

            yield return new object[]
            {
                TimeToken,
                TimeFormat,
                DateTime.Now.AddDays(1)
            };
        }
    }
}