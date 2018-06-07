using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using WebAddressbookTests.DataBase.TableModels;

namespace WebAddressbookTests.DataBase.TableRepositories
{
    public class AddressbookRepository
    {
        private IDbConnection _conn;

        public AddressbookRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public List<Addressbook> GetAllGroups()
        {
            String query = @"SELECT * FROM addressbook";

            return _conn.Query<Addressbook>(query).ToList();
        }
    }
}
