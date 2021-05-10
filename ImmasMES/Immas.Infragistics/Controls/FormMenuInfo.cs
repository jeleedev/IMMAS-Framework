using System.Collections.Generic;

namespace Immas.Infragistics.Controls
{
    public class FormMenuInfo
    {
        public string   MenuId          { get; set; }
        public string   MenuDesc        { get; set; }
        public string   ParentId        { get; set; }
        public string   ViewId          { get; set; }
        public string   AssemblyName    { get; set; }
        public string   TypeName        { get; set; }
        public string   OrderSeq        { get; set; }
        public string   UseYN           { get; set; }

        public List<FormMenuInfo> Children { get; private set; }

        public FormMenuInfo(string menuId, string menuDesc, string parentId, string viewId, string assemblyName, string typeName, string orderSeq, string useYN)
        {
            this.MenuId       = menuId;
            this.MenuDesc     = menuDesc;
            this.ParentId     = parentId;
            this.AssemblyName = assemblyName;
            this.TypeName     = typeName;
            this.ViewId       = viewId;
            this.OrderSeq     = orderSeq;
            this.UseYN        = useYN;
        }
    }
}
