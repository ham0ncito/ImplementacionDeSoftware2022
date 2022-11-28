using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ.Formularios
{
    public partial class UserControlDays : UserControl
    {
        String fechaDia;
        String fechaFormato;
        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
        //     displayEvent();
        }
        public void days(int numDay, int mes, int año)
        {
            lbdays.Text = numDay + "";
            fechaDia = numDay.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            fechaFormato = año.ToString() + "-" + mes.ToString() + "-" + numDay.ToString();
        }

        public void evento(String evento)
        {
            lbevent.Text = evento + "";
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //llamar evento display
          //  displayEvent();

        }

        public void UserControlDays_MouseClick(object sender, MouseEventArgs e)
        {
            
            frmCalendario fmcal = new frmCalendario();
            infotexto infotexto = new infotexto();

            if (lbevent.Text != "")
            {

                frmInfoCalendario infoCal = new frmInfoCalendario(fechaDia,fechaFormato);
                
                infoCal.Show();
            }
            else
            {
                lbevent.Text = "Sin ingreso";
                
            }

        }
    }
}
