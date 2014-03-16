using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Shouldly;
using Xunit;

namespace Invariably.Tests.GuardTests.ForTests
{
    public class ForSimpleExpressions
    {
        [Fact]
        public void WhenSimpleExpressionPasses_NoExceptionIsThrown()
        {
            Should.NotThrow(() => Guard.For(() => true));
        }
    }
}
