using ApiInterfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDataAccess
{
    public class DatabaseInitializer: IDatabaseInitializer
    {
        private readonly IDbConnectionFactory _connectionFactory;

        public DatabaseInitializer(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task InitializeAsync()
        {
            using var connection = await _connectionFactory.CreateConnectionAsync();
            await connection.ExecuteAsync(@"CREATE TABLE IF NOT EXISTS Customers (
        Id CHAR(36) PRIMARY KEY, 
        Username TEXT NOT NULL,
        FullName TEXT NOT NULL,
        Email TEXT NOT NULL,
        DateOfBirth TEXT NOT NULL)");
        }
    }
}
