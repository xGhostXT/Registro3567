using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Registro
{
    public class cnn
    {
        public static string db = @"server=DESKTOP-TFVTCNK\SQLEXPRESS; database=DBpractica04; integrated security =true";
        public static string bd = @"server=DESKTOP-M9NLRNM\SQLEXPRESS; database=NWIND; integrated security =true";
    }

    public class Busco
    {
        public static string Fabrica(string nFabrica)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);  // le indica la conexion a la base de datos por medio la clase cnn
            cnx.Open();

            string stQuery = "SELECT NombreDeFabrica " +
                             "  FROM Fabrica " +
                             " WHERE idFabrica ='" + nFabrica + "'";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            if (rcd.Read())
            {
                return Convert.ToString(rcd["NombreDeFabrica"]);
            }

            cmd.Dispose();
            cnx.Close();
            return null;
        }
    }
}
