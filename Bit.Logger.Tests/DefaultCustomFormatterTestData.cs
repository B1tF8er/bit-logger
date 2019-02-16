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
                Token.Level,
                Level.Critical,
                $"<{Level.Critical.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.Debug,
                $"<{Level.Debug.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.Error,
                $"<{Level.Error.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.Information,
                $"<{Level.Information.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.None,
                $"<{Level.None.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.Trace,
                $"<{Level.Trace.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.Verbose,
                $"<{Level.Verbose.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                Level.Warning,
                $"<{Level.Warning.ToString().ToUpper()}>"
            };

            yield return new object[]
            {
                Token.Level,
                null,
                string.Empty
            };
        }

        public static IEnumerable<object[]> DateTimeTestData()
        {
            yield return new object[]
            {
                Token.DateTimeIso,
                DateTime.Now,
                DateTimeFormat
            };

            yield return new object[]
            {
                Token.DateTimeIso,
                DateTime.Now.AddHours(1),
                DateTimeFormat
            };

            yield return new object[]
            {
                Token.DateTimeIso,
                DateTime.Now.AddDays(1),
                DateTimeFormat
            };

            yield return new object[]
            {
                Token.DateTimeIso,
                null,
                DateTimeFormat
            };
        }

        public static IEnumerable<object[]> DateTestData()
        {
            yield return new object[]
            {
                Token.DateIso,
                DateTime.Now,
                DateFormat
            };

            yield return new object[]
            {
                Token.DateIso,
                DateTime.Now.AddHours(1),
                DateFormat
            };

            yield return new object[]
            {
                Token.DateIso,
                DateTime.Now.AddDays(1),
                DateFormat
            };

            yield return new object[]
            {
                Token.DateIso,
                null,
                DateFormat
            };
        }

        public static IEnumerable<object[]> TimeTestData()
        {
            yield return new object[]
            {
                Token.TimeIso,
                DateTime.Now,
                TimeFormat
            };

            yield return new object[]
            {
                Token.TimeIso,
                DateTime.Now.AddHours(1),
                TimeFormat
            };

            yield return new object[]
            {
                Token.TimeIso,
                DateTime.Now.AddDays(1),
                TimeFormat
            };

            yield return new object[]
            {
                Token.TimeIso,
                null,
                TimeFormat
            };
        }

        public static IEnumerable<object[]> CallersTestData()
        {
            yield return new object[]
            {
                Token.Caller,
                "One.cs",
                "One"
            };

            yield return new object[]
            {
                Token.Caller,
                "Two.cs",
                "Two"
            };

            yield return new object[]
            {
                Token.Caller,
                "Three.cs",
                "Three"
            };

            yield return new object[]
            {
                Token.Caller,
                string.Empty,
                string.Empty
            };

            yield return new object[]
            {
                Token.Caller,
                null,
                string.Empty
            };
        }

        public static IEnumerable<object[]> ExceptionsTestData()
        {
            yield return new object[]
            {
                Token.Exception,
                TestException("first"),
                $"Exception: {TestException("first")}"
            };

            yield return new object[]
            {
                Token.Exception,
                TestException("second"),
                $"Exception: {TestException("second")}"
            };

            yield return new object[]
            {
                Token.Exception,
                TestException("third"),
                $"Exception: {TestException("third")}"
            };

            yield return new object[]
            {
                Token.Exception,
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
