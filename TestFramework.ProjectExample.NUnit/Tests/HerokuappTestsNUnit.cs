// NUnit 3 tests
// See documentation : https://github.com/ObjectivityLtd/Ocaramba 
using NUnit.Framework;
using Ocaramba.Template.NUnit.PageObjects;
using Ocaramba.Tests.NUnit;

namespace Ocaramba.Template.NUnit.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class HerokuappTestsNUnit : ProjectTestBase
    {
        [Test]
        public void BasicAuthTest()
        {
            // TODO: Add your test code here
            var basicAuthPage = new InternetPage(this.DriverContext);
            basicAuthPage.OpenHomePage();
        }
    }
}
