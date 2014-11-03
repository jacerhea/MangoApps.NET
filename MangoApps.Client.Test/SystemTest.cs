using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MangoApps.Client.Test
{
    [TestClass]
    public class SystemTest
    {
        [TestMethod]
        public void System_Test_All_Successful()
        {
            var client = new MangoClient("https://apisassermango.mangoapps.com/api");
            var login = client.Login("apisassermango@gmail.com", "seahawks", "38cc7e51242cf17324b4ddf0576e3fa9fbcc6fdc").Result;





            client.Logout().Wait();
        }
    }
}
