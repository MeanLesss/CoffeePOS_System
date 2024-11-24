using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePOS_System
{
    public class GlobalCustomizeFuction
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

/*        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Color borderColor = Color.Red; // Change this to your desired border color
            int borderWidth = 10; // Change this to your desired border width
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                    borderColor, borderWidth, ButtonBorderStyle.Solid, // left
                                    borderColor, borderWidth, ButtonBorderStyle.Solid, // top
                                    borderColor, borderWidth, ButtonBorderStyle.Solid, // right
                                    borderColor, borderWidth, ButtonBorderStyle.Solid); // bottom
        }*/
    }
}
