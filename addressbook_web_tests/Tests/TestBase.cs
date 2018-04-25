using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected AppManager appManager;

        [SetUp]
        public void SetupAppManager()
        {
            appManager = AppManager.GetInstance();
        }
    }
}
