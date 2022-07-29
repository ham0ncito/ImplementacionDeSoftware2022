namespace GerizimZZ
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.lblID_cliente = new System.Windows.Forms.Label();
            this.lblprimerNombre = new System.Windows.Forms.Label();
            this.lblsegundoNombre = new System.Windows.Forms.Label();
            this.lblprimerApellido = new System.Windows.Forms.Label();
            this.lblsegundoApellido = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtID_cliente = new System.Windows.Forms.TextBox();
            this.txtprimerNombre = new System.Windows.Forms.TextBox();
            this.txtsegundoNombre = new System.Windows.Forms.TextBox();
            this.txtprimerApellido = new System.Windows.Forms.TextBox();
            this.txtsegundoApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.btnagregar_Cliente = new System.Windows.Forms.Button();
            this.btnmodificar_Cliente = new System.Windows.Forms.Button();
            this.btneliminar_Cliente = new System.Windows.Forms.Button();
            this.lblBuscar_Cliente = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.LineaNegraEstetica = new System.Windows.Forms.PictureBox();
            this.LogoGerizim = new System.Windows.Forms.PictureBox();
            this.bteliminar_Cliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID_cliente
            // 
            this.lblID_cliente.AutoSize = true;
            this.lblID_cliente.Location = new System.Drawing.Point(52, 515);
            this.lblID_cliente.Name = "lblID_cliente";
            this.lblID_cliente.Size = new System.Drawing.Size(134, 22);
            this.lblID_cliente.TabIndex = 0;
            this.lblID_cliente.Text = "Numero de ID :";
            // 
            // lblprimerNombre
            // 
            this.lblprimerNombre.AutoSize = true;
            this.lblprimerNombre.Location = new System.Drawing.Point(52, 559);
            this.lblprimerNombre.Name = "lblprimerNombre";
            this.lblprimerNombre.Size = new System.Drawing.Size(142, 22);
            this.lblprimerNombre.TabIndex = 1;
            this.lblprimerNombre.Text = "Primer Nombre :";
            // 
            // lblsegundoNombre
            // 
            this.lblsegundoNombre.AutoSize = true;
            this.lblsegundoNombre.Location = new System.Drawing.Point(52, 601);
            this.lblsegundoNombre.Name = "lblsegundoNombre";
            this.lblsegundoNombre.Size = new System.Drawing.Size(156, 22);
            this.lblsegundoNombre.TabIndex = 2;
            this.lblsegundoNombre.Text = "Segundo Nombre :";
            // 
            // lblprimerApellido
            // 
            this.lblprimerApellido.AutoSize = true;
            this.lblprimerApellido.Location = new System.Drawing.Point(423, 562);
            this.lblprimerApellido.Name = "lblprimerApellido";
            this.lblprimerApellido.Size = new System.Drawing.Size(144, 22);
            this.lblprimerApellido.TabIndex = 3;
            this.lblprimerApellido.Text = "Primer Apellido :";
            // 
            // lblsegundoApellido
            // 
            this.lblsegundoApellido.AutoSize = true;
            this.lblsegundoApellido.Location = new System.Drawing.Point(423, 605);
            this.lblsegundoApellido.Name = "lblsegundoApellido";
            this.lblsegundoApellido.Size = new System.Drawing.Size(158, 22);
            this.lblsegundoApellido.TabIndex = 4;
            this.lblsegundoApellido.Text = "Segundo Apellido :";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(52, 643);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(95, 22);
            this.lbldireccion.TabIndex = 5;
            this.lbldireccion.Text = "Dirección :";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(423, 515);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(88, 22);
            this.lbltelefono.TabIndex = 6;
            this.lbltelefono.Text = "Teléfono :";
            // 
            // txtID_cliente
            // 
            this.txtID_cliente.Location = new System.Drawing.Point(203, 512);
            this.txtID_cliente.Name = "txtID_cliente";
            this.txtID_cliente.Size = new System.Drawing.Size(171, 30);
            this.txtID_cliente.TabIndex = 7;
            this.txtID_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_cliente_KeyPress);
            // 
            // txtprimerNombre
            // 
            this.txtprimerNombre.Location = new System.Drawing.Point(203, 559);
            this.txtprimerNombre.Name = "txtprimerNombre";
            this.txtprimerNombre.Size = new System.Drawing.Size(171, 30);
            this.txtprimerNombre.TabIndex = 8;
            this.txtprimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerNombre_KeyPress);
            // 
            // txtsegundoNombre
            // 
            this.txtsegundoNombre.Location = new System.Drawing.Point(203, 598);
            this.txtsegundoNombre.Name = "txtsegundoNombre";
            this.txtsegundoNombre.Size = new System.Drawing.Size(171, 30);
            this.txtsegundoNombre.TabIndex = 9;
            this.txtsegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoNombre_KeyPress);
            // 
            // txtprimerApellido
            // 
            this.txtprimerApellido.Location = new System.Drawing.Point(580, 559);
            this.txtprimerApellido.Name = "txtprimerApellido";
            this.txtprimerApellido.Size = new System.Drawing.Size(171, 30);
            this.txtprimerApellido.TabIndex = 10;
            this.txtprimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimerApellido_KeyPress);
            // 
            // txtsegundoApellido
            // 
            this.txtsegundoApellido.Location = new System.Drawing.Point(580, 605);
            this.txtsegundoApellido.Name = "txtsegundoApellido";
            this.txtsegundoApellido.Size = new System.Drawing.Size(171, 30);
            this.txtsegundoApellido.TabIndex = 11;
            this.txtsegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegundoApellido_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(580, 517);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(171, 30);
            this.txtTelefono.TabIndex = 12;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(160, 643);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(591, 45);
            this.txtdireccion.TabIndex = 13;
            // 
            // btnagregar_Cliente
            // 
            this.btnagregar_Cliente.Location = new System.Drawing.Point(810, 530);
            this.btnagregar_Cliente.Name = "btnagregar_Cliente";
            this.btnagregar_Cliente.Size = new System.Drawing.Size(154, 33);
            this.btnagregar_Cliente.TabIndex = 14;
            this.btnagregar_Cliente.Text = "Agregar Cliente";
            this.btnagregar_Cliente.UseVisualStyleBackColor = true;
            this.btnagregar_Cliente.Click += new System.EventHandler(this.btnagregar_Cliente_Click);
            // 
            // btnmodificar_Cliente
            // 
            this.btnmodificar_Cliente.Location = new System.Drawing.Point(810, 585);
            this.btnmodificar_Cliente.Name = "btnmodificar_Cliente";
            this.btnmodificar_Cliente.Size = new System.Drawing.Size(154, 33);
            this.btnmodificar_Cliente.TabIndex = 15;
            this.btnmodificar_Cliente.Text = "Modificar Cliente";
            this.btnmodificar_Cliente.UseVisualStyleBackColor = true;
            this.btnmodificar_Cliente.Click += new System.EventHandler(this.btnmodificar_Cliente_Click);
            // 
            // btneliminar_Cliente
            // 
            this.btneliminar_Cliente.Location = new System.Drawing.Point(810, 817);
            this.btneliminar_Cliente.Name = "btneliminar_Cliente";
            this.btneliminar_Cliente.Size = new System.Drawing.Size(154, 35);
            this.btneliminar_Cliente.TabIndex = 16;
            this.btneliminar_Cliente.Text = "Eliminar Cliente";
            this.btneliminar_Cliente.UseVisualStyleBackColor = true;
            this.btneliminar_Cliente.Click += new System.EventHandler(this.btneliminar_Cliente_Click);
            // 
            // lblBuscar_Cliente
            // 
            this.lblBuscar_Cliente.AutoSize = true;
            this.lblBuscar_Cliente.Location = new System.Drawing.Point(304, 157);
            this.lblBuscar_Cliente.Name = "lblBuscar_Cliente";
            this.lblBuscar_Cliente.Size = new System.Drawing.Size(71, 22);
            this.lblBuscar_Cliente.TabIndex = 17;
            this.lblBuscar_Cliente.Text = "Buscar :";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(388, 160);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 30);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(23, 191);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 29;
            this.dgvCliente.Size = new System.Drawing.Size(941, 298);
            this.dgvCliente.TabIndex = 19;
            this.dgvCliente.Click += new System.EventHandler(this.dgvCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(468, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Clientes";
            // 
            // LineaNegraEstetica
            // 
            this.LineaNegraEstetica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaNegraEstetica.Image = global::GerizimZZ.Properties.Resources.substract;
            this.LineaNegraEstetica.Location = new System.Drawing.Point(12, 119);
            this.LineaNegraEstetica.Name = "LineaNegraEstetica";
            this.LineaNegraEstetica.Size = new System.Drawing.Size(989, 35);
            this.LineaNegraEstetica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LineaNegraEstetica.TabIndex = 21;
            this.LineaNegraEstetica.TabStop = false;
            // 
            // LogoGerizim
            // 
            this.LogoGerizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGerizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoGerizim.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.LogoGerizim.Location = new System.Drawing.Point(404, 2);
            this.LogoGerizim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoGerizim.Name = "LogoGerizim";
            this.LogoGerizim.Size = new System.Drawing.Size(213, 110);
            this.LogoGerizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGerizim.TabIndex = 20;
            this.LogoGerizim.TabStop = false;
            // 
            // bteliminar_Cliente
            // 
            this.bteliminar_Cliente.Location = new System.Drawing.Point(810, 643);
            this.bteliminar_Cliente.Name = "bteliminar_Cliente";
            this.bteliminar_Cliente.Size = new System.Drawing.Size(154, 33);
            this.bteliminar_Cliente.TabIndex = 23;
            this.bteliminar_Cliente.Text = "Eliminar Cliente";
            this.bteliminar_Cliente.UseVisualStyleBackColor = true;
            this.bteliminar_Cliente.Click += new System.EventHandler(this.bteliminar_Cliente_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1017, 698);
            this.Controls.Add(this.bteliminar_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LineaNegraEstetica);
            this.Controls.Add(this.LogoGerizim);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar_Cliente);
            this.Controls.Add(this.btneliminar_Cliente);
            this.Controls.Add(this.btnmodificar_Cliente);
            this.Controls.Add(this.btnagregar_Cliente);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtsegundoApellido);
            this.Controls.Add(this.txtprimerApellido);
            this.Controls.Add(this.txtsegundoNombre);
            this.Controls.Add(this.txtprimerNombre);
            this.Controls.Add(this.txtID_cliente);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblsegundoApellido);
            this.Controls.Add(this.lblprimerApellido);
            this.Controls.Add(this.lblsegundoNombre);
            this.Controls.Add(this.lblprimerNombre);
            this.Controls.Add(this.lblID_cliente);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblID_cliente;
        private Label lblprimerNombre;
        private Label lblsegundoNombre;
        private Label lblprimerApellido;
        private Label lblsegundoApellido;
        private Label lbldireccion;
        private Label lbltelefono;
        private TextBox txtID_cliente;
        private TextBox txtprimerNombre;
        private TextBox txtsegundoNombre;
        private TextBox txtprimerApellido;
        private TextBox txtsegundoApellido;
        private TextBox txtTelefono;
        private TextBox txtdireccion;
        private Button btnagregar_Cliente;
        private Button btnmodificar_Cliente;
        private Button btneliminar_Cliente;
        private Label lblBuscar_Cliente;
        private TextBox txtBuscar;
        private DataGridView dgvCliente;
        private Label label3;
        private PictureBox LineaNegraEstetica;
        private PictureBox LogoGerizim;
        private Button bteliminar_Cliente;
    }
}