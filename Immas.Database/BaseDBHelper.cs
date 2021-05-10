using System;
using System.Data;

namespace Immas.Database
{
    public abstract class BaseDBHelper : IDBHelper
    {
        public string DbName            { get; set; }
        public string ConnectionString  { get; set; }

        public BaseDBHelper(string dbName, string connectionString)
        {
            this.DbName           = dbName;
            this.ConnectionString = connectionString;
        }

        public BaseParameterConvertor parameterConvertor;

        protected abstract IDbConnection CreateConnection();
        protected abstract IDbCommand CreateCommand();
        protected abstract IDbDataAdapter CreateDataAdapter();

        protected IDbCommand PrepareCommand(string cmdText, CommandType cmdType, ParameterPackageCollection parameters)
        {
            IDbConnection connection = this.CreateConnection();
            IDbCommand command       = this.CreateCommand();

            command.Connection  = connection;
            command.CommandText = cmdText;
            command.CommandType = cmdType;

            if(parameters != null)
            {
                foreach(ParameterPackage parameterPackage in parameters)
                {
                    IDbDataParameter parameter = this.parameterConvertor.Convert(parameterPackage);
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        public DataTable FillTable(string cmdText, CommandType cmdType, ParameterPackageCollection parameters)
        {
            IDbCommand command = this.PrepareCommand(cmdText, cmdType, parameters);

            DataSet ds = new DataSet();
            IDbDataAdapter adapter = this.CreateDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(ds);

            if (ds.Tables.Count == 0) throw new Exception("no table");

            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string cmdText, CommandType cmdType, ParameterPackageCollection parameters)
        {
            IDbCommand command = this.PrepareCommand(cmdText, cmdType, parameters);

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();

            command.ExecuteNonQuery();
        }

        public object ExecuteScalar(string cmdText, CommandType cmdType, ParameterPackageCollection parameters)
        {
            IDbCommand command = this.PrepareCommand(cmdText, cmdType, parameters);

            if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();

            return command.ExecuteScalar();
        }
    }
}
