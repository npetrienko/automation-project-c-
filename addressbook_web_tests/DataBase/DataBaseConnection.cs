using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class DataBaseConnection
    {
        public MySqlConnection _connection { get; }
        private bool _disposed;

        public DataBaseConnection()
        {
            _connection = new MySqlConnection(@"Server = localhost:81; Database = addressbook; Uid = root; Pwd =;");
        }

        public void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch
            {

            }
        }

        public void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch
            {

            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(Boolean isDisposed)
        {
            if (!this._disposed)
            {
                _connection.Close();

                if (isDisposed)
                {
                    _connection.Dispose();
                }

                _disposed = true;
            }
        }

        ~DataBaseConnection()
        {
            Dispose(false);
        } 
    }
}
