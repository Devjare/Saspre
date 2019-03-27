using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SASPRE
{
    public partial class FormConfiguration : Form
    {
        public FormConfiguration()
        {
            InitializeComponent();
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        

        //Capturar posicion y tamaño antes de maximinar para restaurar
        int lx, ly;
        int sw, sh;

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxi_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            maxi.Visible = false;
            maxi2.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormOpciones f = new FormOpciones();
            f.Visible = true;
 
        }

        private void FormConfiguration_Load(object sender, EventArgs e)
        {
            panelFondo.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void maxi2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            maxi.Visible = true;
            maxi2.Visible = false;
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
