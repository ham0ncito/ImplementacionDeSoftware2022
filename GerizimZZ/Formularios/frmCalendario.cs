using Org.BouncyCastle.Asn1.Mozilla;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ.Formularios
{
    public partial class frmCalendario : Form
    {
        int month, year;
        public static List<string> listafechas = new List<string>();
        List<string> listafechascompletas = new List<string>();
        public SqlDataReader read2;
        public static SqlConnection conex2 = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
        public SqlCommand cm;
        private bool mouseDown;
        private Point lastLocation;
        private bool texto = false;

        public frmCalendario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCalendario_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmonth.Text = nombremes.ToUpper() + "  " + year;
            // primer dia del mes
            DateTime inicioMes = new DateTime(year, month, 1);

            // cantidad de dias del mes
            int days = DateTime.DaysInMonth(year, month);

            //
            // convertir inicio del mes a int
            int daysoftheweek = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            // usercontrol vacio
            for(int i = 1; i< daysoftheweek; i++)
            {
                UserControlEmpty ucempty = new UserControlEmpty();
                Contenedor_dia.Controls.Add(ucempty);
            }
            listafechas.Clear();
            listafechascompletas.Clear();
            // usercontrol para dias
            for (int i = 0; i<days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i + 1, month, year);
                

                try
                {
                    
                    conex2.Open();
                    String sql = "Select * from Producto";
                    cm = new SqlCommand(sql, conex2);
                    cm.CommandType = CommandType.Text;
                    DataSet ds = new DataSet();
                    read2 = cm.ExecuteReader();
                    var indexcolumna = read2.GetOrdinal("fechaIngreso");
                    bool breaker = false;
                    while(read2.Read())
                    {
                        
                        var lfecha = read2.GetValue(indexcolumna);
                        int index = (lfecha.ToString()).LastIndexOf(" ");
                        
                        foreach(string item in listafechas)
                        {
                            if(item == (lfecha.ToString()).Remove(index))
                            {
                                breaker = true;
                            }
                        }
                        if(breaker == true)
                        {
                            break;
                        }
                        listafechascompletas.Add(lfecha.ToString());
                        listafechas.Add((lfecha.ToString()).Remove(index));
                    }
                    
                        
                    string fechafor;

                    fechafor = (i+1).ToString() + "/" + month.ToString() + "/" + year;

                    foreach( var itemlistfecha in listafechas)
                    {
                        if (itemlistfecha == fechafor)
                        {
                            ucdays.evento("Ingreso inventario");
                            break;
                        }
                        else
                        {
                            ucdays.evento("");
                        }
                    }
                        
                        
                    read2.Dispose();
                    cm.Dispose();
                    conex2.Close();
                    Contenedor_dia.Controls.Add(ucdays);

                }
                catch
                {

                }
                
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            
            //vaciar contenedor
            Contenedor_dia.Controls.Clear();
            //decrementar? mes al mes anteriror
            if(month == 1)
            {
                month = 12;
                year--;
            }
            else
            {
                month--;
            }
            
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmonth.Text = nombremes.ToUpper() + "  " + year;

            // primer dia del mes
            DateTime inicioMes = new DateTime(year, month, 1);

            // cantidad de dias del mes
            int days = DateTime.DaysInMonth(year, month);

            //
            // convertir inicio del mes a int
            int daysoftheweek = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            // usercontrol vacio
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlEmpty ucempty = new UserControlEmpty();
                Contenedor_dia.Controls.Add(ucempty);
            }
            // usercontrol para dias
            for (int i = 0; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i + 1, month, year);
                
                string fechafor;
                

                fechafor = (i+1).ToString() + "/" + month.ToString() + "/" + year;
                foreach (var itemlistfecha in listafechas)
                {
                    if (itemlistfecha == fechafor  )
                    {
                        ucdays.evento("Ingreso inventario");
                        break;
                    }
                    else
                    {
                        ucdays.evento("");
                    }

                }
                Contenedor_dia.Controls.Add(ucdays);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmCalendario_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void frmCalendario_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frmCalendario_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //vaciar contenedor
            Contenedor_dia.Controls.Clear();
            //incrementar mes al siguiente mes y chequear si no pasa el año
             if (month == 12)
            {
                month = 1;
                year++;
            }
            else
            {
                month++;
            }
            
            
            String nombremes = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbmonth.Text = nombremes.ToUpper() + "  " + year;

            // primer dia del mes
            DateTime inicioMes = new DateTime(year, month, 1);

            // cantidad de dias del mes
            int days = DateTime.DaysInMonth(year, month);

            //
            // convertir inicio del mes a int
            int daysoftheweek = Convert.ToInt32(inicioMes.DayOfWeek.ToString("d")) + 1;

            // usercontrol vacio
            for (int i = 1; i < daysoftheweek; i++)
            {
                UserControlEmpty ucempty = new UserControlEmpty();
                Contenedor_dia.Controls.Add(ucempty);
            }
            // usercontrol para dias
            for (int i = 0; i < days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i + 1, month, year);

                string fechafor;

                fechafor = (i+1).ToString() + "/" + month.ToString() + "/" + year;
                foreach (var itemlistfecha in listafechas)
                {
                    if (itemlistfecha == fechafor)
                    {
                        ucdays.evento("Ingreso inventario");
                        break;
                    }
                    else
                    {
                        ucdays.evento("");
                    }

                }
                Contenedor_dia.Controls.Add(ucdays);
             }
        }



    }
}
;