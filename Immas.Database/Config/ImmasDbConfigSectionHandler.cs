using System.Configuration;

namespace Immas.Database.Config
{
    public class ImmasDbConfigSectionHandler : ConfigurationSection
    {
        public const string SectionName = "dbConfigSectionHandler";

        [ConfigurationProperty("dbLoggerName")]
        public string DbLoggerName
        {
            get
            {
                return base["dbLoggerName"] as string;
            }
        }

        [ConfigurationProperty("elements", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ImmasDbConfigCollection), AddItemName = "add")]
        public ImmasDbConfigCollection Elements
        {
            get
            {
                return (ImmasDbConfigCollection)base["elements"];
            }
        }

        public ImmasDbConfigElement GetElement(string dbName)
        {
            foreach (ImmasDbConfigElement element in this.Elements)
            {
                if (element.DbName == dbName) return element;
            }

            return null;
        }

        private static ImmasDbConfigSectionHandler instance;
        public static ImmasDbConfigSectionHandler GetInstance()
        {
            if (instance == null) instance = (ImmasDbConfigSectionHandler)ConfigurationManager.GetSection(SectionName);
            return instance;
        }
    }
}
