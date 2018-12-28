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
                Level.Critical,
                $"<{Level.Critical.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.Debug,
                $"<{Level.Debug.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.Error,
                $"<{Level.Error.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.Information,
                $"<{Level.Information.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.None,
                $"<{Level.None.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.Trace,
                $"<{Level.Trace.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.Verbose,
                $"<{Level.Verbose.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                Level.Warning,
                $"<{Level.Warning.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                LevelToken,
                null,
                string.Empty
            };
        }

        public static IEnumerable<object[]> DateTimeTestData()
        {
            yield return new object[]
            {
                DateTimeToken,
                DateTime.Now,
                DateTimeFormat
            };

            yield return new object[]
            {
                DateTimeToken,
                DateTime.Now.AddHours(1),
                DateTimeFormat
            };

            yield return new object[]
            {
                DateTimeToken,
                DateTime.Now.AddDays(1),
                DateTimeFormat
            };

            yield return new object[]
            {
                DateTimeToken,
                null,
                DateTimeFormat
            };
        }

        public static IEnumerable<object[]> DateTestData()
        {
            yield return new object[]
            {
                DateToken,
                DateTime.Now,
                DateFormat
            };

            yield return new object[]
            {
                DateToken,
                DateTime.Now.AddHours(1),
                DateFormat
            };

            yield return new object[]
            {
                DateToken,
                DateTime.Now.AddDays(1),
                DateFormat
            };

            yield return new object[]
            {
                DateToken,
                null,
                DateFormat
            };
        }

        public static IEnumerable<object[]> TimeTestData()
        {
            yield return new object[]
            {
                TimeToken,
                DateTime.Now,
                TimeFormat
            };

            yield return new object[]
            {
                TimeToken,
                DateTime.Now.AddHours(1),
                TimeFormat
            };

            yield return new object[]
            {
                TimeToken,
                DateTime.Now.AddDays(1),
                TimeFormat
            };

            yield return new object[]
            {
                TimeToken,
                null,
                TimeFormat
            };
        }

        public static IEnumerable<object[]> CallersTestData()
        {
            yield return new object[]
            {
                CallerToken,
                "Caller.One",
                "One"
            };

            yield return new object[]
            {
                CallerToken,
                "Caller.Two",
                "Two"
            };

            yield return new object[]
            {
                CallerToken,
                "Caller.Three",
                "Three"
            };

            yield return new object[]
            {
                CallerToken,
                "Caller.",
                string.Empty
            };

            yield return new object[]
            {
                CallerToken,
                null,
                string.Empty
            };
        }

        public static IEnumerable<object[]> ExceptionsTestData()
        {
            yield return new object[]
            {
                ExceptionToken,
                TestException("first"),
                $"Exception: {TestException("first")}"
            };

            yield return new object[]
            {
                ExceptionToken,
                TestException("second"),
                $"Exception: {TestException("second")}"
            };

            yield return new object[]
            {
                ExceptionToken,
                TestException("third"),
                $"Exception: {TestException("third")}"
            };

            yield return new object[]
            {
                ExceptionToken,
                null,
                string.Empty
            };
        }

        private static Exception TestException(string message)
        {
            return new Exception(message);
        }
    }
}