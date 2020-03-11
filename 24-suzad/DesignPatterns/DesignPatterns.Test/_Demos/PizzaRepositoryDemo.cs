using DesignPatterns.Factory.DbConnections;
using Npgsql;
using System.Data.SqlClient;
using Xunit;

namespace DesignPatterns.Test._Demos
{
    public class PizzaRepositoryDemo
    {
        [Fact]
        public void DemoSqlConnection()
        {
            var repo = new PizzaRepository(new SqlConnection());
            var command = repo.GetBySize(12);
            Assert.IsType<SqlCommand>(command);
            Assert.IsType<SqlParameter>(command.Parameters[0]);
        }

        [Fact]
        public void DemoPostgresConnection()
        {
            var repo = new PizzaRepository(new NpgsqlConnection());
            var command = repo.GetBySize(12);
            Assert.IsType<NpgsqlCommand>(command);
            Assert.IsType<NpgsqlParameter>(command.Parameters[0]);
        }
    }
}
