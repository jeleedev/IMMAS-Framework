using System.Drawing;

namespace Immas.Infragistics
{
    public static class CommonColorSet
    {
        public static Color NormalGray              { get { return Color.FromArgb(235, 235, 235); } }
        public static Color BrightGray              { get { return Color.FromArgb(245, 245, 245); } }

        public static Color HighlightBlue           { get { return Color.FromArgb(28, 151, 234); } }

        public static Color LemonGreen              { get { return Color.FromArgb(207, 235, 82); } }
        public static Color DarkBlue                { get { return Color.FromArgb(55, 119, 164); } }
        public static Color SkyBlue                 { get { return Color.FromArgb(204, 219, 226); } }

        public static Color BizNormalColor          { get { return Color.White; } }
        public static Color BizReadOnlyColor        { get { return NormalGray; } }

        public static Color ActiveTabColor          { get { return Color.FromArgb(207, 223, 233); } }
        
        public static Color HeaderBackColor         { get { return Color.FromArgb(245, 245, 245); } }
        public static Color ActiveCellHeaderColor   { get { return Color.FromArgb(194, 220, 236); } } 
        public static Color ActiveCellBackColor     { get { return Color.FromArgb(194, 220, 236); } } 
        public static Color RowAlternateColor       { get { return Color.FromArgb(252, 252, 252); } }
    }
}
