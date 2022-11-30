namespace GerizimZZ.Formularios
{
    partial class frInicioBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frInicioBodega));
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Calendario = new FontAwesome.Sharp.IconButton();
            this.btnmaterias = new FontAwesome.Sharp.IconButton();
            this.btnenviar = new FontAwesome.Sharp.IconButton();
            this.btnrepartir = new FontAwesome.Sharp.IconButton();
            this.btnsolicitar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_titlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_titlebar.Controls.Add(this.btnCerrar);
            this.panel_titlebar.Controls.Add(this.btnMinimizar);
            this.panel_titlebar.Location = new System.Drawing.Point(715, 12);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(132, 44);
            this.panel_titlebar.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 15;
            this.btnCerrar.Location = new System.Drawing.Point(95, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 45D;
            this.btnCerrar.Size = new System.Drawing.Size(34, 25);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMinimizar.IconSize = 15;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(58, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 25);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.Calendario);
            this.panel1.Controls.Add(this.btnmaterias);
            this.panel1.Controls.Add(this.btnenviar);
            this.panel1.Controls.Add(this.btnrepartir);
            this.panel1.Controls.Add(this.btnsolicitar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 490);
            this.panel1.TabIndex = 4;
            // 
            // Calendario
            // 
            this.Calendario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Calendario.BackColor = System.Drawing.Color.LightGray;
            this.Calendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calendario.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calendario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calendario.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.Calendario.IconColor = System.Drawing.Color.Black;
            this.Calendario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Calendario.IconSize = 35;
            this.Calendario.Location = new System.Drawing.Point(0, 399);
            this.Calendario.Name = "Calendario";
            this.Calendario.Padding = new System.Windows.Forms.Padding(10);
            this.Calendario.Size = new System.Drawing.Size(191, 71);
            this.Calendario.TabIndex = 10;
            this.Calendario.Tag = "Inventario";
            this.Calendario.Text = "Calendario";
            this.Calendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Calendario.UseVisualStyleBackColor = false;
            this.Calendario.Click += new System.EventHandler(this.Calendario_Click);
            // 
            // btnmaterias
            // 
            this.btnmaterias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnmaterias.BackColor = System.Drawing.Color.LightGray;
            this.btnmaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaterias.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmaterias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmaterias.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btnmaterias.IconColor = System.Drawing.Color.Black;
            this.btnmaterias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmaterias.IconSize = 35;
            this.btnmaterias.Location = new System.Drawing.Point(0, 322);
            this.btnmaterias.Name = "btnmaterias";
            this.btnmaterias.Padding = new System.Windows.Forms.Padding(10);
            this.btnmaterias.Size = new System.Drawing.Size(191, 71);
            this.btnmaterias.TabIndex = 9;
            this.btnmaterias.Tag = "Inventario";
            this.btnmaterias.Text = "Materias";
            this.btnmaterias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmaterias.UseVisualStyleBackColor = false;
            this.btnmaterias.Click += new System.EventHandler(this.btnmaterias_Click);
            // 
            // btnenviar
            // 
            this.btnenviar.BackColor = System.Drawing.Color.LightGray;
            this.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenviar.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnenviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnenviar.IconChar = FontAwesome.Sharp.IconChar.TruckPickup;
            this.btnenviar.IconColor = System.Drawing.Color.Black;
            this.btnenviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnenviar.IconSize = 35;
            this.btnenviar.Location = new System.Drawing.Point(0, 245);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Padding = new System.Windows.Forms.Padding(10);
            this.btnenviar.Size = new System.Drawing.Size(191, 71);
            this.btnenviar.TabIndex = 8;
            this.btnenviar.Tag = "Inventario";
            this.btnenviar.Text = "Enviar";
            this.btnenviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnenviar.UseVisualStyleBackColor = false;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // btnrepartir
            // 
            this.btnrepartir.BackColor = System.Drawing.Color.LightGray;
            this.btnrepartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrepartir.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnrepartir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrepartir.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.btnrepartir.IconColor = System.Drawing.Color.Black;
            this.btnrepartir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrepartir.IconSize = 35;
            this.btnrepartir.Location = new System.Drawing.Point(0, 168);
            this.btnrepartir.Name = "btnrepartir";
            this.btnrepartir.Padding = new System.Windows.Forms.Padding(10);
            this.btnrepartir.Size = new System.Drawing.Size(191, 71);
            this.btnrepartir.TabIndex = 7;
            this.btnrepartir.Tag = "Inventario";
            this.btnrepartir.Text = "Repartidores";
            this.btnrepartir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnrepartir.UseVisualStyleBackColor = false;
            this.btnrepartir.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnsolicitar
            // 
            this.btnsolicitar.BackColor = System.Drawing.Color.LightGray;
            this.btnsolicitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsolicitar.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnsolicitar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsolicitar.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.btnsolicitar.IconColor = System.Drawing.Color.Black;
            this.btnsolicitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsolicitar.IconSize = 35;
            this.btnsolicitar.Location = new System.Drawing.Point(0, 91);
            this.btnsolicitar.Name = "btnsolicitar";
            this.btnsolicitar.Padding = new System.Windows.Forms.Padding(10);
            this.btnsolicitar.Size = new System.Drawing.Size(191, 71);
            this.btnsolicitar.TabIndex = 6;
            this.btnsolicitar.Tag = "Inventario";
            this.btnsolicitar.Text = "Solicitar";
            this.btnsolicitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsolicitar.UseVisualStyleBackColor = false;
            this.btnsolicitar.Click += new System.EventHandler(this.btninventariomi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 5;
            this.label1.Tag = "Menu";
            this.label1.Text = "Opciones";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(849, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources._264855836_4713169605409097_2106932496429429410_n;
            this.pictureBox2.Location = new System.Drawing.Point(238, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GerizimZZ.Properties.Resources._274349672_4980421895350532_8429971338086587742_n;
            this.pictureBox3.Location = new System.Drawing.Point(549, 122);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(258, 226);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(238, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 112);
            this.label2.TabIndex = 7;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // frInicioBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 488);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "frInicioBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim Inicio Bodega";
            this.panel_titlebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_titlebar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnsolicitar;
        private FontAwesome.Sharp.IconButton btnmaterias;
        private FontAwesome.Sharp.IconButton btnenviar;
        private FontAwesome.Sharp.IconButton btnrepartir;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private FontAwesome.Sharp.IconButton Calendario;
    }
}