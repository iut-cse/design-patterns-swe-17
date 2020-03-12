using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.Factory.DbConnections
{
    public class PizzaRepository
    {
        private readonly IDbConnection connection;

        public PizzaRepository(IDbConnection connection)
        {
            this.connection = connection;
        }

        public IDbCommand GetBySize(int pizzaSize)
        {
            var cmd = connection.CreateCommand();
            cmd.CommandText = "select * from pizza where sizeCm = @sizeCm";
            var sizeParam = cmd.CreateParameter();
            sizeParam.ParameterName = "sizeCm";
            sizeParam.Value = pizzaSize;
            sizeParam.DbType = DbType.Int32;

            cmd.Parameters.Add(sizeParam);

            return cmd;
        }

        public IDbCommand GetBySizeRigid(int pizzaSize)
        {
            var connection = new SqlConnection();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "select * from pizza where sizeCm = @sizeCm";
            var sizeParam = cmd.CreateParameter();
            sizeParam.ParameterName = "sizeCm";
            sizeParam.Value = pizzaSize;
            sizeParam.DbType = DbType.Int32;

            cmd.Parameters.Add(sizeParam);

            return cmd;
        }
    }
}
