using BookRentalSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panel_Main.Controls.Clear();
            panel_Main.Controls.Add(c);
        }

        private void panelHome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void pictureBox_home_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }
    }
}
