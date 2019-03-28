using System;
using System.Drawing;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var nickName = txtNickName.Text;
            var password = txtPassword.Text;

            if (nickName.Equals(String.Empty))
            {
                eprovider.SetError(txtNickName, "No deje el campo vacío");
            }
            else if (password.Equals(String.Empty))
            {
                eprovider.SetError(txtPassword, "No deje el campo vacío");
            }
            else
            {
                var user = Business_Layer.User.Login(nickName, password);

                if(user.Rows.Count == 0)
                {
                    lblError.Visible = true;
                    lblError.Text = "No se encontraron ususarios";
                }
                else
                {
                    // ID, name, lastName, pass, role, nickname
                    this.Hide();
                    var mainFrom = new FormOpciones(this)
                    {
                        UserName = user.Rows[0][1].ToString(),
                        UserLastName = user.Rows[0][2].ToString(),
                        UserRole = user.Rows[0][4].ToString(),
                        userNickName = user.Rows[0][5].ToString()
                    };
                    mainFrom.Show();
                }
            }

            //this.Visible = false;
            //FormOpciones f = new FormOpciones();
            //f.Visible = true;

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
