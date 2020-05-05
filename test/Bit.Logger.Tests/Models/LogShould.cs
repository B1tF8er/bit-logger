namespace Bit.Logger.Tests.Models
{
    using Bit.Logger.Models;
    using Helpers;
    using Xunit;

    public class LogShould
    {
        [Theory]
        [MemberData(nameof(LogTestData.Logs), MemberType = typeof(LogTestData))]
        public void Call_ToString_AndReturnLogData(Log log)
        {
            Assert.Equal(log.BuildLogString(), log.ToString());
        }
    }
}
