using Shouldly;
using Xunit;

namespace Invariably.Tests.GuardTests.AgainstTests
{
    public class AgainstSimpleExpressions
    {
        [Fact]
        public void WhenSimpleExpressionPasses_NoExceptionIsThrown()
        {
            Should.NotThrow(() => Guard.Against(() => false));
        }
    }
}
