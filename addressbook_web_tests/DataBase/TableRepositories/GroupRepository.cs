using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using WebAddressbookTests.DataBase.TableModels;

namespace addressbook_web_tests.DataBase.TableRepositories
{
    public class GroupRepository
    {
        private IDbConnection _conn;

        public GroupRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public List<Group> GetAllGroups()
        {
            String query = @"SELECT domain_id, group_id, group_parent_id, created, modified, deprecated, group_name, group_header, group_footer FROM group_list";

            return _conn.Query<Group>(query).ToList();
        }
    }
}
