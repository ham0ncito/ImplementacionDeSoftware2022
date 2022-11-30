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
    public partial class infotexto : UserControl
    {
        public infotexto()
        {
            InitializeComponent();
        }

        public void cambioinfo(String llenar)
        {
            this.BackColor = SystemColors.ControlDarkDark;
            lbinfo.Text = llenar;
        }
        private void infotexto_Load(object sender, EventArgs e)
        {
            lbinfo.Text = "Seleccione Un dia";
        }

        
    }
}
