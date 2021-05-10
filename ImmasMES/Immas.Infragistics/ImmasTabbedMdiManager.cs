using Infragistics.Win;
using Infragistics.Win.UltraWinTabbedMdi;
using Infragistics.Win.UltraWinTabs;
using System.Drawing;

namespace Immas.Infragistics
{
    public class ImmasTabbedMdiManager : UltraTabbedMdiManager
    {
        public Color ActiveTabBackColor
        {
            get
            {
                return this.TabSettings.ActiveTabAppearance.BackColor;
            }
            set
            {
                this.TabSettings.ActiveTabAppearance.BackColor = value;
            }
        }
        public Color ActiveTabForeColor
        {
            get
            {
                return this.TabSettings.ActiveTabAppearance.ForeColor;
            }
            set
            {
                this.TabSettings.ActiveTabAppearance.ForeColor = value;
            }
        }
        public Color ActiveTabBorderColor
        {
            get
            {
                return this.TabSettings.ActiveTabAppearance.BorderColor;
            }
            set
            {
                this.TabSettings.ActiveTabAppearance.BorderColor = value;
            }
        }
        public Color TabBackColor
        {
            get
            {
                return this.TabSettings.TabAppearance.BackColor;
            }
            set
            {
                this.TabSettings.TabAppearance.BackColor = value;
            }
        }
        public Color TabForeColor
        {
            get
            {
                return this.TabSettings.TabAppearance.ForeColor;
            }
            set
            {
                this.TabSettings.TabAppearance.ForeColor = value;
            }
        }
        public Color TabBorderColor
        {
            get
            {
                return this.TabSettings.TabAppearance.BorderColor;
            }
            set
            {
                this.TabSettings.TabAppearance.BorderColor = value;
            }
        }

        public int TabHeight
        {
            get
            {
                return this.TabGroupSettings.TabHeight;
            }
            set
            {
                this.TabGroupSettings.TabHeight = value;
            }
        }
        public int TabWidth
        {
            get
            {
                return this.TabSettings.TabWidth;
            }
            set
            {
                this.TabSettings.TabWidth = value;
            }
        }

        public HAlign TextHAlign
        {
            get
            {
                return base.TabSettings.TabAppearance.TextHAlign;
            }
            set
            {
                base.TabSettings.TabAppearance.TextHAlign = value;
            }
        }
        public VAlign TextVAlign
        {
            get
            {
                return base.TabSettings.TabAppearance.TextVAlign;
            }
            set
            {
                base.TabSettings.TabAppearance.TextVAlign = value;
            }
        }

        public bool DisplayFormIcon
        {
            get
            {
                return this.TabSettings.DisplayFormIcon == DefaultableBoolean.True;
            }
            set
            {
                this.TabSettings.DisplayFormIcon = value == true ? DefaultableBoolean.True : DefaultableBoolean.False;
            }
        }

        public bool DisplayCloseButton
        {
            get
            {
                return this.TabGroupSettings.CloseButtonLocation == TabCloseButtonLocation.Default;
            }
            set
            {
                this.TabGroupSettings.CloseButtonLocation = value == true ? TabCloseButtonLocation.Default : TabCloseButtonLocation.None;
            }
        }

        public string Tag
        {
            get
            {
                return (string)this.TabSettings.Tag;
            }
            set
            {
                this.TabSettings.Tag = value;
            }
        }
    }
}
