using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    public class Cl_conexiones
    {
        protected SqlConnection conex;

        public static SqlConnection GetConnection()
        {

            SqlConnection conex = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            return conex;
        }
    }

}