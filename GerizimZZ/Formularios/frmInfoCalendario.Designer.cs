namespace GerizimZZ.Formularios
{
    partial class frmInfoCalendario
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
            this.panel_titlebar = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoGerizim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIdProveedor = new System.Windows.Forms.TextBox();
            this.txbFrmDirProveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbFrmProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFrmCantProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrmPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbFrmProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFrmCodigo = new System.Windows.Forms.TextBox();
            this.lblfrmfecha = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_titlebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.BackColor = System.Drawing.Color.Transparent;
            this.panel_titlebar.Controls.Add(this.btnCerrar);
            this.panel_titlebar.Controls.Add(this.btnMinimizar);
            this.panel_titlebar.Location = new System.Drawing.Point(685, 0);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(179, 44);
            this.panel_titlebar.TabIndex = 5;
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
            this.btnCerrar.Location = new System.Drawing.Point(64, 14);
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
            this.btnMinimizar.Location = new System.Drawing.Point(16, 14);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(34, 25);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.LogoGerizim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbIdProveedor);
            this.panel1.Controls.Add(this.txbFrmDirProveedor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txbFrmProveedor);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txbFrmCantProducto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtFrmPrecioProducto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbFrmProducto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbFrmCodigo);
            this.panel1.Controls.Add(this.lblfrmfecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(94, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 328);
            this.panel1.TabIndex = 6;
            // 
            // LogoGerizim
            // 
            this.LogoGerizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGerizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoGerizim.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.LogoGerizim.Location = new System.Drawing.Point(462, -1);
            this.LogoGerizim.Margin = new System.Windows.Forms.Padding(4);
            this.LogoGerizim.Name = "LogoGerizim";
            this.LogoGerizim.Size = new System.Drawing.Size(143, 90);
            this.LogoGerizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGerizim.TabIndex = 31;
            this.LogoGerizim.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // txbIdProveedor
            // 
            this.txbIdProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txbIdProveedor.Location = new System.Drawing.Point(482, 222);
            this.txbIdProveedor.Name = "txbIdProveedor";
            this.txbIdProveedor.Size = new System.Drawing.Size(62, 23);
            this.txbIdProveedor.TabIndex = 19;
            // 
            // txbFrmDirProveedor
            // 
            this.txbFrmDirProveedor.Location = new System.Drawing.Point(179, 261);
            this.txbFrmDirProveedor.Name = "txbFrmDirProveedor";
            this.txbFrmDirProveedor.ReadOnly = true;
            this.txbFrmDirProveedor.Size = new System.Drawing.Size(265, 23);
            this.txbFrmDirProveedor.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dirección Proveedor";
            // 
            // txbFrmProveedor
            // 
            this.txbFrmProveedor.Location = new System.Drawing.Point(179, 222);
            this.txbFrmProveedor.Name = "txbFrmProveedor";
            this.txbFrmProveedor.ReadOnly = true;
            this.txbFrmProveedor.Size = new System.Drawing.Size(265, 23);
            this.txbFrmProveedor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Proveedor";
            // 
            // txbFrmCantProducto
            // 
            this.txbFrmCantProducto.Location = new System.Drawing.Point(179, 183);
            this.txbFrmCantProducto.Name = "txbFrmCantProducto";
            this.txbFrmCantProducto.ReadOnly = true;
            this.txbFrmCantProducto.Size = new System.Drawing.Size(265, 23);
            this.txbFrmCantProducto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad Producto";
            // 
            // txtFrmPrecioProducto
            // 
            this.txtFrmPrecioProducto.Location = new System.Drawing.Point(179, 144);
            this.txtFrmPrecioProducto.Name = "txtFrmPrecioProducto";
            this.txtFrmPrecioProducto.ReadOnly = true;
            this.txtFrmPrecioProducto.Size = new System.Drawing.Size(265, 23);
            this.txtFrmPrecioProducto.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio Producto";
            // 
            // txbFrmProducto
            // 
            this.txbFrmProducto.Location = new System.Drawing.Point(179, 107);
            this.txbFrmProducto.Name = "txbFrmProducto";
            this.txbFrmProducto.ReadOnly = true;
            this.txbFrmProducto.Size = new System.Drawing.Size(265, 23);
            this.txbFrmProducto.TabIndex = 10;
            this.txbFrmProducto.TextChanged += new System.EventHandler(this.txbFrmProducto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre Producto";
            // 
            // txbFrmCodigo
            // 
            this.txbFrmCodigo.Location = new System.Drawing.Point(179, 71);
            this.txbFrmCodigo.Name = "txbFrmCodigo";
            this.txbFrmCodigo.ReadOnly = true;
            this.txbFrmCodigo.Size = new System.Drawing.Size(265, 23);
            this.txbFrmCodigo.TabIndex = 8;
            // 
            // lblfrmfecha
            // 
            this.lblfrmfecha.AutoSize = true;
            this.lblfrmfecha.BackColor = System.Drawing.Color.Transparent;
            this.lblfrmfecha.Font = new System.Drawing.Font("Garamond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfrmfecha.Location = new System.Drawing.Point(202, 11);
            this.lblfrmfecha.Name = "lblfrmfecha";
            this.lblfrmfecha.Size = new System.Drawing.Size(201, 27);
            this.lblfrmfecha.TabIndex = 7;
            this.lblfrmfecha.Text = "Ingreso 00/00/0000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Producto";
            // 
            // frmInfoCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoCalendario";
            this.Text = "frmInfoCalendario";
            this.Load += new System.EventHandler(this.frmInfoCalendario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmInfoCalendario_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmInfoCalendario_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmInfoCalendario_MouseUp);
            this.panel_titlebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_titlebar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private Panel panel1;
        private TextBox txbFrmDirProveedor;
        private Label label7;
        private TextBox txbFrmProveedor;
        private Label label6;
        private TextBox txbFrmCantProducto;
        private Label label5;
        private TextBox txtFrmPrecioProducto;
        private Label label4;
        private TextBox txbFrmProducto;
        private Label label3;
        private TextBox txbFrmCodigo;
        private Label lblfrmfecha;
        private Label label2;
        private Label label1;
        private TextBox txbIdProveedor;
        private PictureBox LogoGerizim;
    }
}