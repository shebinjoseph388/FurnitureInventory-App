using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sampleprjct
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool IsMouseUp = true;

        private int mX;
        private int mY;

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseUp = false;
            // note these co-ordinates will be in MenuStrip co-ordinate space
            mX = e.X;
            mY = e.Y;
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseUp = true;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseUp) return;

            // note "this" will refer to the Form here
            // note e.X, and e.Y co-ordinates will be in MenuStrip co-ordinate space
            // we're just calculating an offset that we can use to move the Form
            this.Left += e.X - mX;
            this.Top += e.Y - mY;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmadminhome_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel4.Text = System.DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
