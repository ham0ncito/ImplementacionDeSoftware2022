using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ.Formularios
{
    public partial class frInicioBodega : Form
    {
        public frInicioBodega()
        {
            InitializeComponent();
        }

        private void frInicioBodega_Load(object sender, EventArgs e)
        {
            
        }

        private void btninventariomi_Click(object sender, EventArgs e)
        {
            FrmSolicitudInventario inventario = new FrmSolicitudInventario();
            AddOwnedForm(inventario);
            inventario.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FrmRepartidores frRepartidores = new FrmRepartidores();
            AddOwnedForm(frRepartidores);
            frRepartidores.Show();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en nuevas actualizaciones");
        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente en nuevas actualizaciones");
        }
    }
}
