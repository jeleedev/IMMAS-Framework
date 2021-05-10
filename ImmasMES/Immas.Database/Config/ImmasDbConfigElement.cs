using System.Configuration;

namespace Immas.Database.Config
{
    public class ImmasDbConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("dbName", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string DbName
        {
            get { return base["dbName"] as string; }
        }

        [ConfigurationProperty("dbType", DefaultValue = "", IsRequired = false)]
        public string DbType
        {
            get { return base["dbType"] as string; }
        }

        [ConfigurationProperty("connectionString", DefaultValue = "", IsRequired = false)]
        public string ConnectionString
        {
            get { return base["connectionString"] as string; }
        }
    }
}
