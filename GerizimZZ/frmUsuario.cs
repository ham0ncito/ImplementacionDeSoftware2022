﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            label1.Text = "Bienvenido " + Usuario.username.ToString();
        }

        private void frmUsuario_Load()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para cualquier consulta puede llamar a soporte, estarán alegres de ayudarle", "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string contraseña = "";
            string contra;
            int cambio; 
            if(InputBox.inputBox("Cambio de Contraseña", "Ingrese su nueva contraseña", ref contraseña) == DialogResult.OK)
            {
                contra = contraseña;
              
                string consulta = "use Gerizim; Update Usuarios set contraseñaUsuario = '" + contraseña + "' where nombreUsuario = '" + Usuario.username + "';";
                Usuario.Conexion(consulta);    
                
            }
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void cambiarCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string correo = "";
            string con;
            int cambio;
            if (InputBox.inputBox("Cambio de Correo", "Ingrese su nuevo correo", ref correo) == DialogResult.OK)
            {
                con = correo;

                string consulta = "use Gerizim; Update Usuarios set EmailUsuario = '" + con + "' where nombreUsuario = '" + Usuario.username + "';";
                Usuario.Conexion(consulta);

            }
        }

        private void cambiarFotoDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en actualizaciones");
        }

        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en actualizaciones");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nos vemos pronto");
            FrmLogin fr = new FrmLogin();
            fr.Show();
        }
    }
}
