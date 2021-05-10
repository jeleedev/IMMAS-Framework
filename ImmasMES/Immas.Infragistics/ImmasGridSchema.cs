using Infragistics.Win;
using System;
using System.Collections.Generic;

namespace Immas.Infragistics
{
    [Serializable]
    public class ImmasGridSchema
    {
        public string           ViewID           { get; set; } 
        public string           Key              { get; set; } 
        public string           Caption          { get; set; } 
        public ImmasColumnStyle ColumnStyle      { get; set; } 
        public int              Width            { get; set; } 
        public HAlign           HAlign           { get; set; } 
        public VAlign           VAlign           { get; set; } 
        public bool             PrimaryKey       { get; set; } = false;
        public bool             ReadOnly         { get; set; } = false;
        public bool             Hidden           { get; set; } = false;
    }

    [Serializable]
    public class ImmasGridSchemaCollection : List<ImmasGridSchema>
    {
    }
}
