namespace GerizimZZ
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btConectar = new System.Windows.Forms.Button();
            this.chbxmotrar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(41, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 21);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario ";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseña.Location = new System.Drawing.Point(41, 93);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(100, 21);
            this.lblContraseña.TabIndex = 1;
            this.lblContraseña.Text = "Contraseña ";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "GerizimBarahona",
            "GerizimGuamilito",
            "GerizimCholoma",
            "GerizimMetropolitana",
            "GerizimFranquicias"});
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(179, 41);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "GerizimSucursal";
            this.txtUsuario.Size = new System.Drawing.Size(219, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtContraseña.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Menu;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseña.Location = new System.Drawing.Point(179, 87);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PlaceholderText = "************";
            this.txtContraseña.Size = new System.Drawing.Size(217, 22);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btSalir.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSalir.Location = new System.Drawing.Point(373, 363);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(137, 54);
            this.btSalir.TabIndex = 5;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click_1);
            // 
            // btConectar
            // 
            this.btConectar.BackColor = System.Drawing.Color.PaleGreen;
            this.btConectar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConectar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btConectar.Location = new System.Drawing.Point(79, 363);
            this.btConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(141, 55);
            this.btConectar.TabIndex = 3;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = false;
            this.btConectar.Click += new System.EventHandler(this.button2_Click);
            // 
            // chbxmotrar
            // 
            this.chbxmotrar.AutoSize = true;
            this.chbxmotrar.BackColor = System.Drawing.Color.Transparent;
            this.chbxmotrar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxmotrar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbxmotrar.ForeColor = System.Drawing.Color.Black;
            this.chbxmotrar.Location = new System.Drawing.Point(411, 87);
            this.chbxmotrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbxmotrar.Name = "chbxmotrar";
            this.chbxmotrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbxmotrar.Size = new System.Drawing.Size(50, 25);
            this.chbxmotrar.TabIndex = 8;
            this.chbxmotrar.Text = "👁️";
            this.chbxmotrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxmotrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chbxmotrar.UseVisualStyleBackColor = false;
            this.chbxmotrar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources._199848567_4174426372616759_1130399733558613204_n_PhotoRoom1;
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel1.Location = new System.Drawing.Point(32, 141);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 18);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Recuperar Contraseña";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.chbxmotrar);
            this.groupBox1.Controls.Add(this.lblContraseña);
            this.groupBox1.Controls.Add(this.txtContraseña);
            this.groupBox1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(58, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 191);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de acceso";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel3.Location = new System.Drawing.Point(250, 141);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(84, 18);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Recordarme";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(179, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 3);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(179, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 3);
            this.label1.TabIndex = 10;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.linkLabel2.Location = new System.Drawing.Point(185, 141);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(59, 18);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tutorial";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(226, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 472);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button btSalir;
        private Button btConectar;
        private CheckBox chbxmotrar;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        public TextBox txtUsuario;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider1;
        private LinkLabel linkLabel2;
        private Button button1;
        private LinkLabel linkLabel3;
        private Label label2;
        private Label label1;
    }
}