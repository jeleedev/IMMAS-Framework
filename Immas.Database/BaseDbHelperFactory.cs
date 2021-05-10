namespace Immas.Database
{
    public abstract class BaseDbHelperFactory
    {
        public abstract IDBHelper Create(string dbName, string connectionString);
    }
}
