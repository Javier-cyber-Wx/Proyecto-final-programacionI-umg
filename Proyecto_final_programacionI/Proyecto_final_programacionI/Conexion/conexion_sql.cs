using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_final_programacionI.Conexion
{
    public class conexion_sql
    {
        public static MySqlConnection obtenerConexion()
        {
            
            string servidor = "SERVER=127.0.0.1;PORT=3306;DATABASE=proyectofinal;UID=root;PASSWORDS=;";
            MySqlConnection conexionBD = new MySqlConnection(servidor);
            try
            {
                return conexionBD;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message+e.StackTrace);
                return null;
            }
            
        }
    }
}
