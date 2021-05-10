using System.Configuration;

namespace Immas.Database.Config
{
    public class ImmasDbConfigCollection : ConfigurationElementCollection
    {
        public ImmasDbConfigElement this[int index]
        {
            get
            {
                return (ImmasDbConfigElement)base.BaseGet(index);
            }
            set
            {
                if (base.BaseGet(index) != null) base.BaseRemoveAt(index);
                base.BaseAdd(index, value);
            }
        }

        public void Add(ImmasDbConfigElement value)
        {
            base.BaseAdd(value);
        }
        public void Clear()
        {
            base.BaseClear();
        }
        public void Remove(ImmasDbConfigElement serviceConfig)
        {
            base.BaseRemove(serviceConfig.DbName);
        }
        public void Remove(string name)
        {
            base.BaseRemove(name);
        }
        public void RemoveAt(int index)
        {
            base.BaseRemoveAt(index);
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new ImmasDbConfigElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ImmasDbConfigElement)element).DbName;
        }
    }
}