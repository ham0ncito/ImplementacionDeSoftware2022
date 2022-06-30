﻿namespace GerizimZZ
{
    partial class frmPantallaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPantallaPedido));
            this.LineaNegraEstetica = new System.Windows.Forms.PictureBox();
            this.BarraDeBusqueda = new System.Windows.Forms.TextBox();
            this.datagridPedidosRecientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtRepartidor = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.txtFechaPedido = new System.Windows.Forms.TextBox();
            this.botonCancelarPedido = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosRecientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LineaNegraEstetica
            // 
            this.LineaNegraEstetica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LineaNegraEstetica.Image = global::GerizimZZ.Properties.Resources.substract;
            this.LineaNegraEstetica.Location = new System.Drawing.Point(29, 81);
            this.LineaNegraEstetica.Name = "LineaNegraEstetica";
            this.LineaNegraEstetica.Size = new System.Drawing.Size(688, 29);
            this.LineaNegraEstetica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LineaNegraEstetica.TabIndex = 5;
            this.LineaNegraEstetica.TabStop = false;
            // 
            // BarraDeBusqueda
            // 
            this.BarraDeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraDeBusqueda.Location = new System.Drawing.Point(12, 154);
            this.BarraDeBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BarraDeBusqueda.Multiline = true;
            this.BarraDeBusqueda.Name = "BarraDeBusqueda";
            this.BarraDeBusqueda.Size = new System.Drawing.Size(305, 29);
            this.BarraDeBusqueda.TabIndex = 6;
            this.BarraDeBusqueda.TextChanged += new System.EventHandler(this.BarraDeBusqueda_TextChanged);
            // 
            // datagridPedidosRecientes
            // 
            this.datagridPedidosRecientes.AllowUserToAddRows = false;
            this.datagridPedidosRecientes.AllowUserToDeleteRows = false;
            this.datagridPedidosRecientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridPedidosRecientes.Location = new System.Drawing.Point(12, 224);
            this.datagridPedidosRecientes.Name = "datagridPedidosRecientes";
            this.datagridPedidosRecientes.RowTemplate.Height = 25;
            this.datagridPedidosRecientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridPedidosRecientes.Size = new System.Drawing.Size(351, 200);
            this.datagridPedidosRecientes.TabIndex = 9;
            this.datagridPedidosRecientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPedidosRecientes_CellContentClick);
            this.datagridPedidosRecientes.ClientSizeChanged += new System.EventHandler(this.PantallaDescripcionProducto_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(326, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pedidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pedidos Recientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Introduzca dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(457, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo de factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(434, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Codigo de Repartidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(434, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dirección de Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(466, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha de pedido:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(588, 201);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 23);
            this.txtFactura.TabIndex = 20;
            // 
            // txtRepartidor
            // 
            this.txtRepartidor.Location = new System.Drawing.Point(588, 239);
            this.txtRepartidor.Name = "txtRepartidor";
            this.txtRepartidor.Size = new System.Drawing.Size(100, 23);
            this.txtRepartidor.TabIndex = 21;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Location = new System.Drawing.Point(588, 275);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(100, 23);
            this.txtEntrega.TabIndex = 22;
            // 
            // txtFechaPedido
            // 
            this.txtFechaPedido.Location = new System.Drawing.Point(588, 309);
            this.txtFechaPedido.Name = "txtFechaPedido";
            this.txtFechaPedido.Size = new System.Drawing.Size(100, 23);
            this.txtFechaPedido.TabIndex = 23;
            // 
            // botonCancelarPedido
            // 
            this.botonCancelarPedido.Location = new System.Drawing.Point(521, 364);
            this.botonCancelarPedido.Name = "botonCancelarPedido";
            this.botonCancelarPedido.Size = new System.Drawing.Size(127, 36);
            this.botonCancelarPedido.TabIndex = 24;
            this.botonCancelarPedido.Text = "Cancelar pedido";
            this.botonCancelarPedido.UseVisualStyleBackColor = true;
            this.botonCancelarPedido.Click += new System.EventHandler(this.botonCancelarPedido_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerizimZZ.Properties.Resources._199848567_4174426372616759_1130399733558613204_n_PhotoRoom1;
            this.pictureBox1.Location = new System.Drawing.Point(310, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmPantallaPedido
            // 
            this.ClientSize = new System.Drawing.Size(744, 446);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botonCancelarPedido);
            this.Controls.Add(this.txtFechaPedido);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.txtRepartidor);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagridPedidosRecientes);
            this.Controls.Add(this.BarraDeBusqueda);
            this.Controls.Add(this.LineaNegraEstetica);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPantallaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PantallaDescripcionProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LineaNegraEstetica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPedidosRecientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox LineaNegraEstetica;
        public TextBox BarraDeBusqueda;
        private DataGridView datagridPedidosRecientes;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtFactura;
        private TextBox txtRepartidor;
        private TextBox txtEntrega;
        private TextBox txtFechaPedido;
        private Button botonCancelarPedido;
        private PictureBox pictureBox1;
        //private Button button1;
    }
}