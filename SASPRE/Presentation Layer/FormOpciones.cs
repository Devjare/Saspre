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
    public partial class FormOpciones : Form
    {

        // Personal Info Variables
        private String _userName;
        private String _userLastName;
        private String _userNickName;
        private String _userRole;

        public String UserRole
        {
            get { return _userRole; }
            set {
                _userRole = value;
                lblRole.Text += _userRole;
            }
        }
        public String userNickName
        {
            get { return _userNickName; }
            set {
                _userNickName = value;
                lblNickName.Text += _userNickName;
            }
        }
        public String UserLastName
        {
            get { return _userLastName; }
            set {
                _userLastName = value;
                lblName.Text += _userLastName;
            }
        }
        public String UserName
        {
            get { return _userName; }
            set {
                _userName = value;
                lblName.Text += _userName;
            }
        }

        private FormConfiguration login;

        public FormOpciones()
        {
            InitializeComponent();
        }

        public FormOpciones(FormConfiguration login)
        {
            InitializeComponent();
            this.login = login;
        }

        #region windowDesign
        private void FormOpciones_Load(object sender, EventArgs e)
        {
            panelLeft.BackColor = Color.FromArgb(180,42,98,18); //Transparencia del panel
            panelRight.BackColor = Color.FromArgb(0, 0, 0, 0);
            panelFondo.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
            //this.Dispose();
        }

        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }

   

        #endregion
    }
}
