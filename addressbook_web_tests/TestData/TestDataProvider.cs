using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebAddressbookTests
{
    public class TestDataProvider
    {
        public static IEnumerable<GroupData> GetRandomGroupDataProvider()
        {
            Random rnd = new Random();

            List<GroupData> groups = new List<GroupData>();

            for (Int32 i = 0; i < 5; i++)
            {
                Int32 randValue = rnd.Next(1000);

                groups.Add(new GroupData
                {
                    Name = $"New group name {randValue}",
                    Header = $"New group header {randValue}",
                    Footer = $"New group footer {randValue}"
                });
            }

            return groups;
        }

        public static IEnumerable<GroupData> GetGroupDataFromFile()
        {
            List<GroupData> groups = new List<GroupData>();

            String[] lines = File.ReadAllLines(@"C:\Users\n.petriienko\Documents\Visual Studio 2015\Projects\addressbook_web_tests\addressbook_web_tests\TestData\groups.csv");

            foreach (String l in lines)
            {
                String[] parts = l.Split(',');
                groups.Add(new GroupData
                {
                    Name = parts[0],
                    Header = parts[1],
                    Footer = parts[2]
                });
            }

            return groups;
        }
    }
}
