using System.Collections.Generic;
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
            var login = client.Login("apisassermango@gmail.com", "c2VhaGF3a3MK", "38cc7e51242cf17324b4ddf0576e3fa9fbcc6fdc").Result;
            //var invites = client.InviteUsers(new List<string>{"jace.rhea@gmail.com", "jrhea_99@yahoo.com"}).Result;

            //var group = client.CreateGroup("Test Group", "again, a test", PrivacyType.Public).Result;
            //var project = client.CreateProject("Test Project", "again, a test", PrivacyType.Public).Result;

            //var statusUpdate = client.StatusUpdate("Test status update").Result;

            //var huddle = client.CreateHuddle("apisassermango@gmail.com", new List<string> {"apisassermango@gmail.com"}).Result;

            //var editgroup = client.EditSelfCreatedGroupProject(265330, "test test group", "test description").Result;

            //var users = client.GetAllUsers().Result;
            //var myGroups = client.GetMyGroups().Result;
            //var timesheets = client.GetProjectTimesheet(265330).Result;
            var userprofile = client.GetUser(220325).Result;

            client.Logout().Wait();
        }
    }
}
