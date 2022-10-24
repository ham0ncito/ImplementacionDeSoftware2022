namespace GerizimZZ
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnMaximizar = new FontAwesome.Sharp.IconButton();
            this.panelsidemenu = new System.Windows.Forms.Panel();
            this.btnayuda = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblUsernma = new System.Windows.Forms.Label();
            this.btnclientesmi = new FontAwesome.Sharp.IconButton();
            this.btnventasmi = new FontAwesome.Sharp.IconButton();
            this.btnpedidosmi = new FontAwesome.Sharp.IconButton();
            this.btninventariomi = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelsidemenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.pictureBox1.Location = new System.Drawing.Point(236, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1131, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorProvider1.SetIconAlignment(this.btnMinimizar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMinimizar.IconSize = 15;
            this.btnMinimizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizar.Location = new System.Drawing.Point(6, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 25);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorProvider1.SetIconAlignment(this.btnMaximizar, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.btnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximizar.IconColor = System.Drawing.Color.Black;
            this.btnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnMaximizar.IconSize = 15;
            this.btnMaximizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaximizar.Location = new System.Drawing.Point(45, 14);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(34, 25);
            this.btnMaximizar.TabIndex = 8;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // panelsidemenu
            // 
            this.panelsidemenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelsidemenu.Controls.Add(this.btnayuda);
            this.panelsidemenu.Controls.Add(this.iconButton3);
            this.panelsidemenu.Controls.Add(this.iconButton2);
            this.panelsidemenu.Controls.Add(this.iconButton1);
            this.panelsidemenu.Controls.Add(this.lblUsernma);
            this.panelsidemenu.Controls.Add(this.btnclientesmi);
            this.panelsidemenu.Controls.Add(this.btnventasmi);
            this.panelsidemenu.Controls.Add(this.btnpedidosmi);
            this.panelsidemenu.Controls.Add(this.btninventariomi);
            this.panelsidemenu.Controls.Add(this.panel3);
            this.panelsidemenu.Controls.Add(this.panel2);
            this.panelsidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelsidemenu.Location = new System.Drawing.Point(0, 0);
            this.panelsidemenu.Name = "panelsidemenu";
            this.panelsidemenu.Size = new System.Drawing.Size(240, 749);
            this.panelsidemenu.TabIndex = 11;
            this.panelsidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelsidemenu_Paint);
            // 
            // btnayuda
            // 
            this.btnayuda.BackColor = System.Drawing.Color.LightGray;
            this.btnayuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnayuda.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnayuda.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnayuda.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnayuda.IconColor = System.Drawing.Color.Black;
            this.btnayuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnayuda.IconSize = 35;
            this.btnayuda.Location = new System.Drawing.Point(0, 625);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Padding = new System.Windows.Forms.Padding(10);
            this.btnayuda.Size = new System.Drawing.Size(240, 84);
            this.btnayuda.TabIndex = 8;
            this.btnayuda.Tag = "user";
            this.btnayuda.Text = "Ayuda";
            this.btnayuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnayuda.UseVisualStyleBackColor = false;
            this.btnayuda.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.LightGray;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.Location = new System.Drawing.Point(0, 541);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton3.Size = new System.Drawing.Size(240, 84);
            this.iconButton3.TabIndex = 7;
            this.iconButton3.Tag = "user";
            this.iconButton3.Text = "Bodega";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LightGray;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.Location = new System.Drawing.Point(0, 457);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton2.Size = new System.Drawing.Size(240, 84);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Tag = "user";
            this.iconButton2.Text = "Facturar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightGray;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.Location = new System.Drawing.Point(0, 385);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10);
            this.iconButton1.Size = new System.Drawing.Size(240, 72);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.TabStop = false;
            this.iconButton1.Tag = "user";
            this.iconButton1.Text = "Menu de usuario";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblUsernma
            // 
            this.lblUsernma.AutoSize = true;
            this.lblUsernma.Location = new System.Drawing.Point(86, 544);
            this.lblUsernma.Name = "lblUsernma";
            this.lblUsernma.Size = new System.Drawing.Size(0, 20);
            this.lblUsernma.TabIndex = 12;
            this.lblUsernma.Visible = false;
            // 
            // btnclientesmi
            // 
            this.btnclientesmi.BackColor = System.Drawing.Color.LightGray;
            this.btnclientesmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientesmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientesmi.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnclientesmi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclientesmi.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnclientesmi.IconColor = System.Drawing.Color.Black;
            this.btnclientesmi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclientesmi.IconSize = 35;
            this.btnclientesmi.Location = new System.Drawing.Point(0, 311);
            this.btnclientesmi.Name = "btnclientesmi";
            this.btnclientesmi.Padding = new System.Windows.Forms.Padding(10);
            this.btnclientesmi.Size = new System.Drawing.Size(240, 74);
            this.btnclientesmi.TabIndex = 4;
            this.btnclientesmi.Tag = "user";
            this.btnclientesmi.Text = "Clientes";
            this.btnclientesmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclientesmi.UseVisualStyleBackColor = false;
            this.btnclientesmi.Click += new System.EventHandler(this.btnclientesmi_Click);
            this.btnclientesmi.MouseLeave += new System.EventHandler(this.btnclientesmi_MouseLeaves);
            this.btnclientesmi.MouseHover += new System.EventHandler(this.btnclientesmi_Hover);
            // 
            // btnventasmi
            // 
            this.btnventasmi.BackColor = System.Drawing.Color.LightGray;
            this.btnventasmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnventasmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventasmi.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnventasmi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnventasmi.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnventasmi.IconColor = System.Drawing.Color.Black;
            this.btnventasmi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnventasmi.IconSize = 35;
            this.btnventasmi.Location = new System.Drawing.Point(0, 241);
            this.btnventasmi.Name = "btnventasmi";
            this.btnventasmi.Padding = new System.Windows.Forms.Padding(10);
            this.btnventasmi.Size = new System.Drawing.Size(240, 70);
            this.btnventasmi.TabIndex = 3;
            this.btnventasmi.Tag = "ventas";
            this.btnventasmi.Text = "Ventas";
            this.btnventasmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnventasmi.UseVisualStyleBackColor = false;
            this.btnventasmi.Click += new System.EventHandler(this.btnventasmi_Click);
            this.btnventasmi.MouseLeave += new System.EventHandler(this.btnventasmi_MouseLeaves);
            this.btnventasmi.MouseHover += new System.EventHandler(this.btnventasmi_Hover);
            // 
            // btnpedidosmi
            // 
            this.btnpedidosmi.BackColor = System.Drawing.Color.LightGray;
            this.btnpedidosmi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpedidosmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpedidosmi.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnpedidosmi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnpedidosmi.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnpedidosmi.IconColor = System.Drawing.Color.Black;
            this.btnpedidosmi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnpedidosmi.IconSize = 35;
            this.btnpedidosmi.Location = new System.Drawing.Point(0, 172);
            this.btnpedidosmi.Name = "btnpedidosmi";
            this.btnpedidosmi.Padding = new System.Windows.Forms.Padding(10);
            this.btnpedidosmi.Size = new System.Drawing.Size(240, 69);
            this.btnpedidosmi.TabIndex = 2;
            this.btnpedidosmi.Tag = "pedidos";
            this.btnpedidosmi.Text = "Pedidos";
            this.btnpedidosmi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnpedidosmi.UseVisualStyleBackColor = false;
            this.btnpedidosmi.Click += new System.EventHandler(this.btnpedidosmi_Click);
            this.btnpedidosmi.MouseLeave += new System.EventHandler(this.btnpedidosmi_MouseLeaves);
            this.btnpedidosmi.MouseHover += new System.EventHandler(this.btnpedidosmi_Hover);
            // 
            // btninventariomi
            // 
            this.btninventariomi.BackColor = System.Drawing.Color.LightGray;
            this.btninventariomi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninventariomi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventariomi.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btninventariomi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninventariomi.IconChar = FontAwesome.Sharp.IconChar.CommentMedical;
            this.btninventariomi.IconColor = System.Drawing.Color.Black;
            this.btninventariomi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninventariomi.IconSize = 35;
            this.btninventariomi.Location = new System.Drawing.Point(0, 93);
            this.btninventariomi.Name = "btninventariomi";
            this.btninventariomi.Padding = new System.Windows.Forms.Padding(10);
            this.btninventariomi.Size = new System.Drawing.Size(240, 79);
            this.btninventariomi.TabIndex = 1;
            this.btninventariomi.Tag = "Inventario";
            this.btninventariomi.Text = "Inventario";
            this.btninventariomi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninventariomi.UseVisualStyleBackColor = false;
            this.btninventariomi.Click += new System.EventHandler(this.btninventariomi_Click);
            this.btninventariomi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn);
            this.btninventariomi.MouseLeave += new System.EventHandler(this.btninventarioomi_MouseLeaves);
            this.btninventariomi.MouseHover += new System.EventHandler(this.btninventarioomi_Hover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(12, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 93);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Menu";
            this.label1.Text = "Dashboard";
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
            this.btnCerrar.Location = new System.Drawing.Point(83, 14);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 45D;
            this.btnCerrar.Size = new System.Drawing.Size(34, 25);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_titlebar.Controls.Add(this.btnCerrar);
            this.panel_titlebar.Controls.Add(this.btnMaximizar);
            this.panel_titlebar.Controls.Add(this.btnMinimizar);
            this.panel_titlebar.Location = new System.Drawing.Point(1224, 3);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(143, 44);
            this.panel_titlebar.TabIndex = 2;
            this.panel_titlebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_titlebar_Paint);
            this.panel_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_titlebar_MouseDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(305, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(596, 112);
            this.label2.TabIndex = 14;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GerizimZZ.Properties.Resources._274349672_4980421895350532_8429971338086587742_n;
            this.pictureBox3.Location = new System.Drawing.Point(636, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(258, 226);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GerizimZZ.Properties.Resources._264855836_4713169605409097_2106932496429429410_n;
            this.pictureBox2.Location = new System.Drawing.Point(304, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(326, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GerizimZZ.Properties.Resources.blog_Como_hacer_un_reporte_de_ventas61;
            this.pictureBox4.Location = new System.Drawing.Point(931, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(410, 274);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1123, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 112);
            this.label3.TabIndex = 16;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BackgroundImage = global::GerizimZZ.Properties.Resources._273186167_4918331624892893_6754485724703248458_n;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(636, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 220);
            this.panel1.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BackgroundImage = global::GerizimZZ.Properties.Resources._272963207_4918331628226226_5944811752821849762_n;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(931, 415);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 262);
            this.panel5.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1123, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 150);
            this.label5.TabIndex = 21;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(301, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 217);
            this.label4.TabIndex = 22;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelsidemenu);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelsidemenu.ResumeLayout(false);
            this.panelsidemenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private Component1 component11;
        private Component1 component12;
        private Panel panelsidemenu;
        private FontAwesome.Sharp.IconButton btnclientesmi;
        private FontAwesome.Sharp.IconButton btnventasmi;
        private FontAwesome.Sharp.IconButton btnpedidosmi;
        private FontAwesome.Sharp.IconButton btninventariomi;
        private Panel panel3;
        private Label label1;
        public Label lblUsernma;
        private Panel panel2;
        private Panel panel_titlebar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMaximizar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnayuda;
        private Label label3;
        private PictureBox pictureBox4;
        private Label label2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel5;
        private Label label5;
        private Label label4;
    }
}