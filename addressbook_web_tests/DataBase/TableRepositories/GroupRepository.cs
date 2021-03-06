﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using WebAddressbookTests.DataBase.TableModels;

namespace WebAddressbookTests.DataBase.TableRepositories
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
            String query = @"SELECT * FROM group_list";

            return _conn.Query<Group>(query).ToList();
        }
    }
}
