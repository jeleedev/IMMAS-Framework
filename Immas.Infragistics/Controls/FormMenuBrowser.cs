using Immas.DataAccess;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Immas.Infragistics.Controls
{
    public delegate void ItemClickEventHandler(object sender, FormMenuInfo e);

    public class FormMenuBrowser : MenuStrip
    {
        public event ItemClickEventHandler Menu_Event;
        private FormMenuInfoCollection menuCollection { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (this.DesignMode == false)
            {
                this.LoadFormMenuInfo();
            }
        }

        private void LoadFormMenuInfo()
        {
            menuCollection = new FormMenuInfoCollection();
            DataTable menuData = CommonDao.GetInstance().MenuSelect();

            foreach (DataRow rowMenu in menuData.Rows)
            {
                FormMenuInfo info = new FormMenuInfo(rowMenu["MENU_ID"].ToString()
                                                   , rowMenu["MENU_DESC"].ToString()
                                                   , rowMenu["PARENT_ID"].ToString()
                                                   , rowMenu["VIEW_ID"].ToString()
                                                   , rowMenu["ASSEMBLY_NAME"].ToString()
                                                   , ""
                                                   , rowMenu["ORDER_SEQ"].ToString()
                                                   , rowMenu["USE_YN"].ToString());
                menuCollection.Add(info);
            }
        }

        public void InitMenu()
        {
            foreach (FormMenuInfo menu in menuCollection)
            {
                if (menu.ParentId == "-")
                {
                    var menuItem = new ToolStripMenuItem(menu.MenuDesc);
                    CreateMenu(menu, menuItem);

                    menuItem.BackColor  = Color.WhiteSmoke;
                    menuItem.Margin     = new Padding(0, 0, 1, 0);

                    this.Items.Add(menuItem);
                }
            }
        }
        private void CreateMenu(FormMenuInfo menuInfo, ToolStripMenuItem menuItem)
        {
            foreach (FormMenuInfo subMenu in menuCollection)
            {
                if (subMenu.ParentId == menuInfo.MenuId)
                {
                    if(subMenu.ViewId == "-")
                    {
                        menuItem.DropDownItems.Add(new ToolStripSeparator());
                    }
                    else
                    {
                        var subMenuItem     = new ToolStripMenuItem(subMenu.MenuDesc);
                        subMenu.ParentId    = $"{subMenu.ParentId}-{menuInfo.MenuDesc}";
                        subMenuItem.Tag     = subMenu;
                        subMenuItem.Click   += Item_Click;
                        menuItem.DropDownItems.Add(subMenuItem);

                        CreateMenu(subMenu, subMenuItem);
                    }
                }
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            FormMenuInfo info = (FormMenuInfo)((ToolStripMenuItem)sender).Tag;
            this.Menu_Event?.Invoke(sender, info);
        }
    }
}
