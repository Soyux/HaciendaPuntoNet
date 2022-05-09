using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite; 
namespace MemoryVault
{
    public class Handler : IHandler
    {

        private SqliteConnection memoryconn;
        private SqliteConnection diskconn;

        public SqliteConnection GetMemoryConn() {
            return memoryconn;            
        }
        public SqliteConnection GetColdConn()
        {
            return diskconn;
        }

        public async Task<bool> BootupOnCold()
        {

            //var conn = GetColdConnection;

            //var connstring = String.Format(@"Data Source=C:\sqlite\GVault.db;Version=3", AppDomain.CurrentDomain.BaseDirectory);
            //var conn = new SqliteConnection(connstring);
            var diskconnstring = new SqliteConnectionStringBuilder();
            diskconnstring.DataSource = @"C:\sqlite\GVault.db";
            diskconn = new SqliteConnection();
            diskconn.ConnectionString = diskconnstring.ConnectionString;
            //var conn1 = new SqliteConnection();
            //conn1.ConnectionString = diskconn.ConnectionString;
            //conn1.Open();
            //conn.DataSource = ":memory:";
            //memoryconn = new SqliteConnection(diskconn.ConnectionString);
            //conn1.BackupDatabase(memoryconn);
            await diskconn.OpenAsync();
            return true;
        }//end of Bootup

        public async Task<bool> BootupOnMemory() {

            //var conn = GetColdConnection;

            //var connstring = String.Format(@"Data Source=C:\sqlite\GVault.db;Version=3", AppDomain.CurrentDomain.BaseDirectory);
            //var conn = new SqliteConnection(connstring);
            var diskconn = new SqliteConnectionStringBuilder();
            diskconn.DataSource = @"C:\sqlite\GVault.db";
            //var conn1 = new SqliteConnection();
            //conn1.ConnectionString = diskconn.ConnectionString;
            //conn1.Open();
            //conn.DataSource = ":memory:";
            memoryconn = new SqliteConnection(diskconn.ConnectionString);
            //conn1.BackupDatabase(memoryconn);
            await memoryconn.OpenAsync();
            return true;
        }//end of Bootup

        public System.Data.ConnectionState GetCurrentState()
        {
            return memoryconn.State;
        }

        public async Task<string> GetValue(string hash, SqliteConnection conn) {
            var query = @"select value from Vault where hash=""" + hash + "\"";
            //  var resultado = "";

            if (conn.State != System.Data.ConnectionState.Open) {
                await conn.OpenAsync();
            }

            List<object[]> resultado = new List<object[]>();
            using (SqliteCommand cmd = new SqliteCommand(query, conn))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        object[] row = new object[rdr.FieldCount];
                        rdr.GetValues(row);
                        resultado.Add(row);
                    }//while
                }//using
            }//using
            return resultado[0].GetValue(0).ToString();
        }

        public async Task<string> GetValueMemory(string hash) {
            return await GetValue(hash, memoryconn);
        }//end of GetValueMemory

        public async Task<string> GetValueCold(string hash) {
            return await GetValue(hash, diskconn);
        }//end of GetValueMemory

        public async Task<bool> ShutdownOnMemory()
        {
            await memoryconn.CloseAsync();
            return GetMemoryConn().State==System.Data.ConnectionState.Closed;
           
        }
        public async Task<bool> ShutdownOnCold() {
            await diskconn.CloseAsync();
            return GetColdConn().State == System.Data.ConnectionState.Closed;

        }

    }//end of class

}//end of namespace
