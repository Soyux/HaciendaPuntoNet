using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace MemoryVault
{
    public interface IHandler
    {
        public Task<bool> BootupOnMemory();
        public Task<bool> BootupOnCold();
        public Task<string> GetValue(string hash, SqliteConnection conn);
        public Task<string> GetValueMemory(string hash);
        public Task<string> GetValueCold(string hash);
        public Task<bool> ShutdownOnMemory();
        public Task<bool> ShutdownOnCold();
        public System.Data.ConnectionState GetCurrentState();

        public SqliteConnection GetMemoryConn();
        public SqliteConnection GetColdConn();


    }//end of interface

    }//end of namespace
