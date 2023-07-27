using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.DesignPatterns.Structural.Proxy
{
    internal class DatabaseProxy : IDatabase
    {
        private Database _database;
        public DatabaseProxy(Database database)
        {
            _database = database;
        }

        public const int SemaphoreSlimCount = 4;
        private readonly SemaphoreSlim semaphoreSlim = new SemaphoreSlim(SemaphoreSlimCount);

        public async Task RequestAsync(int @int)
        {
            await semaphoreSlim.WaitAsync();

            if (_database == null)
                _database = new Database();


            await _database.RequestAsync(@int);

            semaphoreSlim.Release();

            if (semaphoreSlim.CurrentCount == SemaphoreSlimCount)
            {
                _database.Dispose();
                _database = null;
            }
        }
    }
}
