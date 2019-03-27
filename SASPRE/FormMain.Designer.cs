namespace SASPRE
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.btnDetectar2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDetectar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechaCosecha = new System.Windows.Forms.Label();
            this.lblFechaPlantada = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCultivo = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.cbCultivo = new System.Windows.Forms.ComboBox();
            this.panelLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.btnMainMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecipitación = new System.Windows.Forms.Label();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.maxi2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.maxi = new Bunifu.Framework.UI.BunifuImageButton();
            this.mini = new Bunifu.Framework.UI.BunifuImageButton();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelMain.SuspendLayout();
            this.panelCenter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelCenter);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Controls.Add(this.panelRight);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1280, 720);
            this.panelMain.TabIndex = 0;
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.btnDetectar2);
            this.panelCenter.Controls.Add(this.btnDetectar);
            this.panelCenter.Controls.Add(this.btnAgregar);
            this.panelCenter.Controls.Add(this.lblEstado);
            this.panelCenter.Controls.Add(this.lblFechaCosecha);
            this.panelCenter.Controls.Add(this.lblFechaPlantada);
            this.panelCenter.Controls.Add(this.lblNombre);
            this.panelCenter.Controls.Add(this.lblCultivo);
            this.panelCenter.Controls.Add(this.lblInicio);
            this.panelCenter.Controls.Add(this.cbCultivo);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(319, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(695, 720);
            this.panelCenter.TabIndex = 3;
            this.panelCenter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelCenter_MouseMove);
            // 
            // btnDetectar2
            // 
            this.btnDetectar2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnDetectar2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDetectar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetectar2.BorderRadius = 0;
            this.btnDetectar2.ButtonText = "Detectar";
            this.btnDetectar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetectar2.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetectar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar2.ForeColor = System.Drawing.Color.Black;
            this.btnDetectar2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetectar2.Iconimage = global::SASPRE.Properties.Resources.icons8_Bug_24px;
            this.btnDetectar2.Iconimage_right = null;
            this.btnDetectar2.Iconimage_right_Selected = null;
            this.btnDetectar2.Iconimage_Selected = null;
            this.btnDetectar2.IconMarginLeft = 15;
            this.btnDetectar2.IconMarginRight = 0;
            this.btnDetectar2.IconRightVisible = false;
            this.btnDetectar2.IconRightZoom = 0D;
            this.btnDetectar2.IconVisible = false;
            this.btnDetectar2.IconZoom = 55D;
            this.btnDetectar2.IsTab = false;
            this.btnDetectar2.Location = new System.Drawing.Point(402, 119);
            this.btnDetectar2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDetectar2.Name = "btnDetectar2";
            this.btnDetectar2.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDetectar2.OnHovercolor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetectar2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetectar2.selected = false;
            this.btnDetectar2.Size = new System.Drawing.Size(75, 28);
            this.btnDetectar2.TabIndex = 9;
            this.btnDetectar2.Text = "Detectar";
            this.btnDetectar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectar2.Textcolor = System.Drawing.Color.Black;
            this.btnDetectar2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar2.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // btnDetectar
            // 
            this.btnDetectar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnDetectar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDetectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetectar.BorderRadius = 0;
            this.btnDetectar.ButtonText = "Detectar";
            this.btnDetectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetectar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar.ForeColor = System.Drawing.Color.Black;
            this.btnDetectar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetectar.Iconimage = global::SASPRE.Properties.Resources.icons8_Bug_24px;
            this.btnDetectar.Iconimage_right = null;
            this.btnDetectar.Iconimage_right_Selected = null;
            this.btnDetectar.Iconimage_Selected = null;
            this.btnDetectar.IconMarginLeft = 15;
            this.btnDetectar.IconMarginRight = 0;
            this.btnDetectar.IconRightVisible = false;
            this.btnDetectar.IconRightZoom = 0D;
            this.btnDetectar.IconVisible = false;
            this.btnDetectar.IconZoom = 55D;
            this.btnDetectar.IsTab = false;
            this.btnDetectar.Location = new System.Drawing.Point(315, 119);
            this.btnDetectar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDetectar.Name = "btnDetectar";
            this.btnDetectar.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDetectar.OnHovercolor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetectar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDetectar.selected = false;
            this.btnDetectar.Size = new System.Drawing.Size(75, 28);
            this.btnDetectar.TabIndex = 8;
            this.btnDetectar.Text = "Detectar";
            this.btnDetectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetectar.Textcolor = System.Drawing.Color.Black;
            this.btnDetectar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetectar.Click += new System.EventHandler(this.bunifuFlatButton6_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.BorderRadius = 0;
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregar.Iconimage = global::SASPRE.Properties.Resources.icons8_Bug_24px;
            this.btnAgregar.Iconimage_right = null;
            this.btnAgregar.Iconimage_right_Selected = null;
            this.btnAgregar.Iconimage_Selected = null;
            this.btnAgregar.IconMarginLeft = 15;
            this.btnAgregar.IconMarginRight = 0;
            this.btnAgregar.IconRightVisible = false;
            this.btnAgregar.IconRightZoom = 0D;
            this.btnAgregar.IconVisible = false;
            this.btnAgregar.IconZoom = 55D;
            this.btnAgregar.IsTab = false;
            this.btnAgregar.Location = new System.Drawing.Point(236, 119);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Normalcolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.OnHovercolor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregar.selected = false;
            this.btnAgregar.Size = new System.Drawing.Size(67, 28);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Textcolor = System.Drawing.Color.Black;
            this.btnAgregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblEstado.Location = new System.Drawing.Point(561, 249);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(68, 24);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechaCosecha
            // 
            this.lblFechaCosecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaCosecha.AutoSize = true;
            this.lblFechaCosecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaCosecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCosecha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFechaCosecha.Location = new System.Drawing.Point(326, 249);
            this.lblFechaCosecha.Name = "lblFechaCosecha";
            this.lblFechaCosecha.Size = new System.Drawing.Size(187, 24);
            this.lblFechaCosecha.TabIndex = 6;
            this.lblFechaCosecha.Text = "Fecha de la cosecha";
            // 
            // lblFechaPlantada
            // 
            this.lblFechaPlantada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaPlantada.AutoSize = true;
            this.lblFechaPlantada.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaPlantada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPlantada.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblFechaPlantada.Location = new System.Drawing.Point(138, 249);
            this.lblFechaPlantada.Name = "lblFechaPlantada";
            this.lblFechaPlantada.Size = new System.Drawing.Size(140, 24);
            this.lblFechaPlantada.TabIndex = 5;
            this.lblFechaPlantada.Text = "Fecha plantada";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNombre.Location = new System.Drawing.Point(10, 249);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblCultivo
            // 
            this.lblCultivo.AutoSize = true;
            this.lblCultivo.BackColor = System.Drawing.Color.Transparent;
            this.lblCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCultivo.Location = new System.Drawing.Point(9, 76);
            this.lblCultivo.Name = "lblCultivo";
            this.lblCultivo.Size = new System.Drawing.Size(66, 24);
            this.lblCultivo.TabIndex = 3;
            this.lblCultivo.Text = "Cultivo";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(9, 22);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(62, 25);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Inicio";
            this.lblInicio.Click += new System.EventHandler(this.lblInicio_Click);
            // 
            // cbCultivo
            // 
            this.cbCultivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCultivo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbCultivo.FormattingEnabled = true;
            this.cbCultivo.Location = new System.Drawing.Point(13, 119);
            this.cbCultivo.Name = "cbCultivo";
            this.cbCultivo.Size = new System.Drawing.Size(199, 28);
            this.cbCultivo.TabIndex = 0;
            this.cbCultivo.Text = "Seleccione el cultivo";
            this.cbCultivo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.bunifuFlatButton4);
            this.panelLeft.Controls.Add(this.bunifuFlatButton3);
            this.panelLeft.Controls.Add(this.bunifuFlatButton2);
            this.panelLeft.Controls.Add(this.bunifuFlatButton1);
            this.panelLeft.Controls.Add(this.lblFuncionalidades);
            this.panelLeft.Controls.Add(this.btnMainMenu);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(146)))));
            this.panelLeft.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(200)))), ((int)(((byte)(48)))));
            this.panelLeft.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.panelLeft.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(146)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Quality = 10;
            this.panelLeft.Size = new System.Drawing.Size(319, 720);
            this.panelLeft.TabIndex = 2;
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Inicio";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = global::SASPRE.Properties.Resources.icons8_Home_24px;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 15;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 55D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(0, 47);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(319, 32);
            this.bunifuFlatButton4.TabIndex = 5;
            this.bunifuFlatButton4.Text = "Inicio";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Tipos de Plagas";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = global::SASPRE.Properties.Resources.icons8_Bug_24px;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 15;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 55D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 180);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(319, 32);
            this.bunifuFlatButton3.TabIndex = 4;
            this.bunifuFlatButton3.Text = "Tipos de Plagas";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Historial de plantas";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = global::SASPRE.Properties.Resources.icons8_Rain_Cloud_24px_1;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 15;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 55D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 149);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(319, 32);
            this.bunifuFlatButton2.TabIndex = 3;
            this.bunifuFlatButton2.Text = "Historial de plantas";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Condición del Tiempo";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::SASPRE.Properties.Resources.icons8_Alarm_Clock_24px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 15;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 55D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 115);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(319, 32);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Condición del Tiempo";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.BackColor = System.Drawing.Color.Transparent;
            this.lblFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionalidades.Location = new System.Drawing.Point(12, 85);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(150, 24);
            this.lblFuncionalidades.TabIndex = 1;
            this.lblFuncionalidades.Text = "Funcionalidades";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainMenu.BorderRadius = 0;
            this.btnMainMenu.ButtonText = "Menu Principal";
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMainMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Iconimage = global::SASPRE.Properties.Resources.icons8_Left_24px;
            this.btnMainMenu.Iconimage_right = null;
            this.btnMainMenu.Iconimage_right_Selected = null;
            this.btnMainMenu.Iconimage_Selected = null;
            this.btnMainMenu.IconMarginLeft = 15;
            this.btnMainMenu.IconMarginRight = 0;
            this.btnMainMenu.IconRightVisible = true;
            this.btnMainMenu.IconRightZoom = 0D;
            this.btnMainMenu.IconVisible = true;
            this.btnMainMenu.IconZoom = 55D;
            this.btnMainMenu.IsTab = false;
            this.btnMainMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMainMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(199)))), ((int)(((byte)(127)))));
            this.btnMainMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainMenu.selected = false;
            this.btnMainMenu.Size = new System.Drawing.Size(319, 32);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Menu Principal";
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Textcolor = System.Drawing.Color.Black;
            this.btnMainMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.pictureBox3);
            this.panelRight.Controls.Add(this.pictureBox2);
            this.panelRight.Controls.Add(this.pictureBox1);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.lblPrecipitación);
            this.panelRight.Controls.Add(this.lblHumedad);
            this.panelRight.Controls.Add(this.lblTemperatura);
            this.panelRight.Controls.Add(this.maxi2);
            this.panelRight.Controls.Add(this.maxi);
            this.panelRight.Controls.Add(this.mini);
            this.panelRight.Controls.Add(this.close);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1014, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(266, 720);
            this.panelRight.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SASPRE.Properties.Resources.icons8_Moderate_Rain_24px;
            this.pictureBox3.Location = new System.Drawing.Point(27, 414);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SASPRE.Properties.Resources.icons8_Wet_24px;
            this.pictureBox2.Location = new System.Drawing.Point(27, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SASPRE.Properties.Resources.icons8_Temperature_24px;
            this.pictureBox1.Location = new System.Drawing.Point(27, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estado de humedad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "37 ° Centigrados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "5mm";
            // 
            // lblPrecipitación
            // 
            this.lblPrecipitación.AutoSize = true;
            this.lblPrecipitación.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecipitación.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecipitación.Location = new System.Drawing.Point(23, 378);
            this.lblPrecipitación.Name = "lblPrecipitación";
            this.lblPrecipitación.Size = new System.Drawing.Size(118, 24);
            this.lblPrecipitación.TabIndex = 8;
            this.lblPrecipitación.Text = "Precipitación";
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.Transparent;
            this.lblHumedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumedad.Location = new System.Drawing.Point(23, 229);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(94, 24);
            this.lblHumedad.TabIndex = 7;
            this.lblHumedad.Text = "Humedad";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(23, 95);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(118, 24);
            this.lblTemperatura.TabIndex = 6;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // maxi2
            // 
            this.maxi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxi2.BackColor = System.Drawing.Color.Transparent;
            this.maxi2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxi2.Image = global::SASPRE.Properties.Resources.mini;
            this.maxi2.ImageActive = null;
            this.maxi2.Location = new System.Drawing.Point(205, 3);
            this.maxi2.Name = "maxi2";
            this.maxi2.Size = new System.Drawing.Size(26, 26);
            this.maxi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxi2.TabIndex = 5;
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
            this.maxi.Location = new System.Drawing.Point(205, 3);
            this.maxi.Name = "maxi";
            this.maxi.Size = new System.Drawing.Size(26, 26);
            this.maxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maxi.TabIndex = 4;
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
            this.mini.Location = new System.Drawing.Point(173, 3);
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(26, 26);
            this.mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mini.TabIndex = 3;
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
            this.close.Location = new System.Drawing.Point(237, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(26, 26);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRight;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuImageButton mini;
        private Bunifu.Framework.UI.BunifuImageButton maxi;
        private Bunifu.Framework.UI.BunifuImageButton maxi2;
        private Bunifu.Framework.UI.BunifuGradientPanel panelLeft;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblFuncionalidades;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainMenu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.ComboBox cbCultivo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechaCosecha;
        private System.Windows.Forms.Label lblFechaPlantada;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCultivo;
        private System.Windows.Forms.Label lblInicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetectar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregar;
        private Bunifu.Framework.UI.BunifuFlatButton btnDetectar2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecipitación;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

