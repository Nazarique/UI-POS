using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool mouseDown;
        int mouseX, mouseY = 0;

        private void btnCloseUI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X; mouseY = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
