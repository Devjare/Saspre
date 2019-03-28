namespace SASPRE
{
    partial class FormConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.panelTop = new System.Windows.Forms.Panel();
            this.maxi2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.maxi = new Bunifu.Framework.UI.BunifuImageButton();
            this.mini = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblSaspre = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtNickName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.eprovider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelFondo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprovider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(5)))));
            this.panelTop.Controls.Add(this.maxi2);
            this.panelTop.Controls.Add(this.maxi);
            this.panelTop.Controls.Add(this.mini);
            this.panelTop.Controls.Add(this.close);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 26);
            this.panelTop.TabIndex = 0;
            // 
            // maxi2
            // 
            this.maxi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxi2.BackColor = System.Drawing.Color.Transparent;
            this.maxi2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxi2.Image = global::SASPRE.Properties.Resources.mini;
            this.maxi2.ImageActive = null;
            this.maxi2.Location = new System.Drawing.Point(1219, 3);
            this.maxi2.Name = "maxi2";
            this.maxi2.Size = new System.Drawing.Size(26, 20);
            this.maxi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxi2.TabIndex = 16;
            this.maxi2.TabStop = false;
            this.maxi2.Visible = false;
            this.maxi2.Zoom = 10;
            this.maxi2.Click += new System.EventHandler(this.maxi2_Click);
            // 
            // maxi
            // 
            this.maxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxi.BackColor = System.Drawing.Color.Transparent;
            this.maxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxi.Image = global::SASPRE.Properties.Resources.maxi;
            this.maxi.ImageActive = null;
            this.maxi.Location = new System.Drawing.Point(1219, 3);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(26, 20);
            this.maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxi.TabIndex = 15;
            this.maxi.TabStop = false;
            this.maxi.Zoom = 10;
            this.maxi.Click += new System.EventHandler(this.maxi_Click);
            // 
            // mini
            // 
            this.mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mini.BackColor = System.Drawing.Color.Transparent;
            this.mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mini.Image = global::SASPRE.Properties.Resources.barra;
            this.mini.ImageActive = null;
            this.mini.Location = new System.Drawing.Point(1193, 3);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(20, 20);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini.TabIndex = 14;
            this.mini.TabStop = false;
            this.mini.Zoom = 10;
            this.mini.Click += new System.EventHandler(this.mini_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = global::SASPRE.Properties.Resources.close2;
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(1251, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 23);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 13;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::SASPRE.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(581, 147);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(149, 164);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // lblSaspre
            // 
            this.lblSaspre.AutoSize = true;
            this.lblSaspre.BackColor = System.Drawing.Color.Transparent;
            this.lblSaspre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaspre.ForeColor = System.Drawing.Color.White;
            this.lblSaspre.Location = new System.Drawing.Point(590, 314);
            this.lblSaspre.Name = "lblSaspre";
            this.lblSaspre.Size = new System.Drawing.Size(127, 25);
            this.lblSaspre.TabIndex = 2;
            this.lblSaspre.Text = "S A S P R E";
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(5)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(5)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "Iniciar";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = false;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(595, 508);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(5)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(141, 35);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Iniciar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.Controls.Add(this.panel1);
            this.panelFondo.Controls.Add(this.flowLayoutPanel1);
            this.panelFondo.Controls.Add(this.flowLayoutPanel2);
            this.panelFondo.Controls.Add(this.btnLogin);
            this.panelFondo.Controls.Add(this.pbLogo);
            this.panelFondo.Controls.Add(this.lblSaspre);
            this.panelFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(1280, 720);
            this.panelFondo.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(5)))));
            this.flowLayoutPanel1.Controls.Add(this.txtNickName);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(514, 367);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(285, 34);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // txtNickName
            // 
            this.txtNickName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNickName.Location = new System.Drawing.Point(3, 3);
            this.txtNickName.Name = "txtNickName";
            this.txtNickName.Size = new System.Drawing.Size(231, 28);
            this.txtNickName.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(199)))), ((int)(((byte)(5)))));
            this.flowLayoutPanel2.Controls.Add(this.txtPassword);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(514, 436);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(285, 34);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 28);
            this.txtPassword.TabIndex = 4;
            // 
            // eprovider
            // 
            this.eprovider.ContainerControl = this;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(282, 26);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "label for errors";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Location = new System.Drawing.Point(517, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 26);
            this.panel1.TabIndex = 16;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SASPRE.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelFondo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormConfiguration_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eprovider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblSaspre;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private Bunifu.Framework.UI.BunifuImageButton maxi2;
        private Bunifu.Framework.UI.BunifuImageButton maxi;
        private Bunifu.Framework.UI.BunifuImageButton mini;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.TextBox txtNickName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider eprovider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
    }
}