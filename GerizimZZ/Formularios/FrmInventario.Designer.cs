namespace GerizimZZ
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.LogoGerizim = new System.Windows.Forms.PictureBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lvlcodigo_Barra = new System.Windows.Forms.Label();
            this.lblcodigo_Catologo = new System.Windows.Forms.Label();
            this.lblcantidad_Producto = new System.Windows.Forms.Label();
            this.lblcantidad_Minima = new System.Windows.Forms.Label();
            this.lblestado_Producto = new System.Windows.Forms.Label();
            this.lblfecha_Ingreso = new System.Windows.Forms.Label();
            this.txtPrecio_producto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.txtPesoProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtCodigoCatologo = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadMinima = new System.Windows.Forms.TextBox();
            this.txtEstadoPRoducto = new System.Windows.Forms.TextBox();
            this.txtFechaingreso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.AllowUserToResizeColumns = false;
            this.dgvProducto.AllowUserToResizeRows = false;
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(13, 170);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.RowTemplate.Height = 29;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(1206, 246);
            this.dgvProducto.TabIndex = 14;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            this.dgvProducto.Click += new System.EventHandler(this.dgvProducto_Click);
            // 
            // LogoGerizim
            // 
            this.LogoGerizim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoGerizim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoGerizim.Image = global::GerizimZZ.Properties.Resources.logoComprimido;
            this.LogoGerizim.Location = new System.Drawing.Point(570, -10);
            this.LogoGerizim.Margin = new System.Windows.Forms.Padding(4);
            this.LogoGerizim.Name = "LogoGerizim";
            this.LogoGerizim.Size = new System.Drawing.Size(154, 136);
            this.LogoGerizim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoGerizim.TabIndex = 29;
            this.LogoGerizim.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscar.Location = new System.Drawing.Point(533, 136);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PlaceholderText = "Nombre del producto a buscar";
            this.txtBuscar.Size = new System.Drawing.Size(249, 22);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(454, 136);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(59, 18);
            this.lblBuscar.TabIndex = 31;
            this.lblBuscar.Text = "Buscar :";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(64, 470);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(56, 18);
            this.lblPrecio.TabIndex = 35;
            this.lblPrecio.Text = "Precio :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(50, 505);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 539);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 18);
            this.lblDescripcion.TabIndex = 37;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(395, 431);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(46, 18);
            this.lblPeso.TabIndex = 38;
            this.lblPeso.Text = "Peso :";
            // 
            // lvlcodigo_Barra
            // 
            this.lvlcodigo_Barra.AutoSize = true;
            this.lvlcodigo_Barra.Location = new System.Drawing.Point(318, 467);
            this.lvlcodigo_Barra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlcodigo_Barra.Name = "lvlcodigo_Barra";
            this.lvlcodigo_Barra.Size = new System.Drawing.Size(118, 18);
            this.lvlcodigo_Barra.TabIndex = 39;
            this.lvlcodigo_Barra.Text = "Código de Barra :";
            // 
            // lblcodigo_Catologo
            // 
            this.lblcodigo_Catologo.AutoSize = true;
            this.lblcodigo_Catologo.Location = new System.Drawing.Point(311, 505);
            this.lblcodigo_Catologo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcodigo_Catologo.Name = "lblcodigo_Catologo";
            this.lblcodigo_Catologo.Size = new System.Drawing.Size(121, 18);
            this.lblcodigo_Catologo.TabIndex = 40;
            this.lblcodigo_Catologo.Text = "Código Catalogo :";
            // 
            // lblcantidad_Producto
            // 
            this.lblcantidad_Producto.AutoSize = true;
            this.lblcantidad_Producto.Location = new System.Drawing.Point(679, 437);
            this.lblcantidad_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad_Producto.Name = "lblcantidad_Producto";
            this.lblcantidad_Producto.Size = new System.Drawing.Size(135, 18);
            this.lblcantidad_Producto.TabIndex = 41;
            this.lblcantidad_Producto.Text = "Cantidad Producto :";
            // 
            // lblcantidad_Minima
            // 
            this.lblcantidad_Minima.AutoSize = true;
            this.lblcantidad_Minima.Location = new System.Drawing.Point(689, 476);
            this.lblcantidad_Minima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcantidad_Minima.Name = "lblcantidad_Minima";
            this.lblcantidad_Minima.Size = new System.Drawing.Size(125, 18);
            this.lblcantidad_Minima.TabIndex = 42;
            this.lblcantidad_Minima.Text = "Cantidad Mínima :";
            // 
            // lblestado_Producto
            // 
            this.lblestado_Producto.AutoSize = true;
            this.lblestado_Producto.Location = new System.Drawing.Point(697, 509);
            this.lblestado_Producto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado_Producto.Name = "lblestado_Producto";
            this.lblestado_Producto.Size = new System.Drawing.Size(123, 18);
            this.lblestado_Producto.TabIndex = 43;
            this.lblestado_Producto.Text = "Estado Producto :";
            // 
            // lblfecha_Ingreso
            // 
            this.lblfecha_Ingreso.AutoSize = true;
            this.lblfecha_Ingreso.Location = new System.Drawing.Point(13, 434);
            this.lblfecha_Ingreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfecha_Ingreso.Name = "lblfecha_Ingreso";
            this.lblfecha_Ingreso.Size = new System.Drawing.Size(104, 18);
            this.lblfecha_Ingreso.TabIndex = 44;
            this.lblfecha_Ingreso.Text = "Fecha Ingreso :";
            // 
            // txtPrecio_producto
            // 
            this.txtPrecio_producto.Location = new System.Drawing.Point(135, 461);
            this.txtPrecio_producto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrecio_producto.Name = "txtPrecio_producto";
            this.txtPrecio_producto.PlaceholderText = "100";
            this.txtPrecio_producto.Size = new System.Drawing.Size(151, 25);
            this.txtPrecio_producto.TabIndex = 2;
            this.txtPrecio_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_producto_KeyPress_1);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(135, 499);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PlaceholderText = "Nombre del Producto";
            this.txtNombreProducto.Size = new System.Drawing.Size(151, 25);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(135, 539);
            this.txtDescripcionProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescripcionProducto.Multiline = true;
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.PlaceholderText = "Esta fragancia es espectacular";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(689, 52);
            this.txtDescripcionProducto.TabIndex = 4;
            this.txtDescripcionProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionProducto_KeyPress);
            // 
            // txtPesoProducto
            // 
            this.txtPesoProducto.Location = new System.Drawing.Point(480, 427);
            this.txtPesoProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPesoProducto.Name = "txtPesoProducto";
            this.txtPesoProducto.PlaceholderText = "3";
            this.txtPesoProducto.Size = new System.Drawing.Size(161, 25);
            this.txtPesoProducto.TabIndex = 5;
            this.txtPesoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoProducto_KeyPress);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(480, 467);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.PlaceholderText = "QGerizim-23";
            this.txtCodigoBarra.Size = new System.Drawing.Size(161, 25);
            this.txtCodigoBarra.TabIndex = 6;
            // 
            // txtCodigoCatologo
            // 
            this.txtCodigoCatologo.Location = new System.Drawing.Point(480, 502);
            this.txtCodigoCatologo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCodigoCatologo.Name = "txtCodigoCatologo";
            this.txtCodigoCatologo.PlaceholderText = "100";
            this.txtCodigoCatologo.Size = new System.Drawing.Size(161, 25);
            this.txtCodigoCatologo.TabIndex = 7;
            this.txtCodigoCatologo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoCatologo_KeyPress);
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(858, 427);
            this.txtCantidadProducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.PlaceholderText = "100";
            this.txtCantidadProducto.Size = new System.Drawing.Size(151, 25);
            this.txtCantidadProducto.TabIndex = 8;
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadProducto_KeyPress);
            // 
            // txtCantidadMinima
            // 
            this.txtCantidadMinima.Location = new System.Drawing.Point(858, 467);
            this.txtCantidadMinima.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCantidadMinima.Name = "txtCantidadMinima";
            this.txtCantidadMinima.PlaceholderText = "1";
            this.txtCantidadMinima.Size = new System.Drawing.Size(151, 25);
            this.txtCantidadMinima.TabIndex = 9;
            this.txtCantidadMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadMinima_KeyPress);
            // 
            // txtEstadoPRoducto
            // 
            this.txtEstadoPRoducto.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2"});
            this.txtEstadoPRoducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEstadoPRoducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEstadoPRoducto.Location = new System.Drawing.Point(858, 502);
            this.txtEstadoPRoducto.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtEstadoPRoducto.Name = "txtEstadoPRoducto";
            this.txtEstadoPRoducto.PlaceholderText = "1";
            this.txtEstadoPRoducto.Size = new System.Drawing.Size(151, 25);
            this.txtEstadoPRoducto.TabIndex = 10;
            this.txtEstadoPRoducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstadoPRoducto_KeyPress);
            // 
            // txtFechaingreso
            // 
            this.txtFechaingreso.Location = new System.Drawing.Point(135, 428);
            this.txtFechaingreso.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtFechaingreso.Name = "txtFechaingreso";
            this.txtFechaingreso.Size = new System.Drawing.Size(151, 25);
            this.txtFechaingreso.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1047, 427);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(174, 31);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar Producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1047, 478);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(174, 31);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar Producto";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1047, 530);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(174, 31);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1047, 574);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 31);
            this.button1.TabIndex = 45;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtFechaingreso);
            this.Controls.Add(this.txtEstadoPRoducto);
            this.Controls.Add(this.txtCantidadMinima);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.txtCodigoCatologo);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.txtPesoProducto);
            this.Controls.Add(this.txtDescripcionProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.txtPrecio_producto);
            this.Controls.Add(this.lblfecha_Ingreso);
            this.Controls.Add(this.lblestado_Producto);
            this.Controls.Add(this.lblcantidad_Minima);
            this.Controls.Add(this.lblcantidad_Producto);
            this.Controls.Add(this.lblcodigo_Catologo);
            this.Controls.Add(this.lvlcodigo_Barra);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.LogoGerizim);
            this.Controls.Add(this.dgvProducto);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerizim Inventario";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoGerizim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvProducto;
        private PictureBox LogoGerizim;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Label lblPrecio;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblPeso;
        private Label lvlcodigo_Barra;
        private Label lblcodigo_Catologo;
        private Label lblcantidad_Producto;
        private Label lblcantidad_Minima;
        private Label lblestado_Producto;
        private Label lblfecha_Ingreso;
        private TextBox txtPrecio_producto;
        private TextBox txtNombreProducto;
        private TextBox txtDescripcionProducto;
        private TextBox txtPesoProducto;
        private TextBox txtCodigoBarra;
        private TextBox txtCodigoCatologo;
        private TextBox txtCantidadProducto;
        private TextBox txtCantidadMinima;
        private TextBox txtEstadoPRoducto;
        private TextBox txtFechaingreso;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button button1;
    }
}