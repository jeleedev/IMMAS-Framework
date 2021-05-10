using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Immas.Infragistics.Controls
{
    public class ImmasRoundedPanel : Panel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            ( int nLeftRect
            , int nTopRect
            , int nRightRect
            , int nBottomRect
            , int nWidthEllipse
            , int nHeightEllipse
            );

        protected override void OnSizeChanged(EventArgs e)
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 15, 15));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // background color
            this.BackColor = Color.WhiteSmoke;

            // padding
            this.Padding = new Padding(10);

            // border color 
            //int borderWidth = 2;
            //Color borderColor = Color.LightSteelBlue;
            //ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
            //                         borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
            //                        ButtonBorderStyle.Solid, borderColor, borderWidth,
            //                         ButtonBorderStyle.Solid,
            //                        borderColor, borderWidth, ButtonBorderStyle.Solid);
        }
    }
}
