using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected AppManager _appManager;

        [SetUp]
        public void SetupAppManager()
        {
            _appManager = AppManager.GetInstance();
        }
    }
}
