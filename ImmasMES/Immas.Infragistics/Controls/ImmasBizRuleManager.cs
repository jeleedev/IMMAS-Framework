using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Immas.Infragistics.Controls
{
    [ProvideProperty("ApplyBizRule", typeof(Control))]
    public class ImmasBizRuleManager : Component, IExtenderProvider
    {
        private Dictionary<Control, bool> controlDic;

        public Color NormalColor        { get { return CommonColorSet.BizNormalColor; } } 
        public Color ReadOnlyColor      { get { return CommonColorSet.BizReadOnlyColor; } } 

        public ImmasBizRuleManager()
        {
            this.controlDic     = new Dictionary<Control, bool>();
        }

        public bool CanExtend(object extendee)
        {
            if((extendee is Control) && !(extendee is ImmasBizRuleManager)) return true;
            return false;
        }

        [DisplayName("(ApplyBizRule)")]
        public bool GetApplyBizRule(Control control)
        {
            if (this.controlDic.ContainsKey(control) == false) 
            {
                return false;
            }
            else
            {
                return this.controlDic[control];
            }
        }
        public void SetApplyBizRule(Control control, bool value)
        {
            if(value == false)
            {
                this.controlDic.Remove(control);

                if (control is TextBox)
                {
                    ((TextBox)control).ReadOnlyChanged -= ImmasBizRuleManager_ReadOnlyChanged;
                }
            }
            else
            {
                this.controlDic[control] = value;

                if(control is TextBox)
                {
                    ((TextBox)control).ReadOnlyChanged += ImmasBizRuleManager_ReadOnlyChanged;
                }
            }
        }

        private void ImmasBizRuleManager_ReadOnlyChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender; 
            if (textBox.ReadOnly == true)
            {
                textBox.BackColor = ReadOnlyColor;
            }
            else
            {
                textBox.BackColor = NormalColor;
            }
        }
    }
}
