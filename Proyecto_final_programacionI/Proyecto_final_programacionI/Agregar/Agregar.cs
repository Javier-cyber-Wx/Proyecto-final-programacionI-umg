using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_final_programacionI.Agregar
{
    public class Agregar
    {
        public static int agregar(datos.Datos pcodigo)
        {
            int retorno = 0;
            using (MySqlConnection conn = Conexion.conexion_sql.obtenerConexion())
            {
                conn.Open();
                MySqlCommand Comando = new MySqlCommand(string.Format("Insert Into servicio (Codigo) values ('{0}') ",
                    pcodigo.Codigo
                    ),conn);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
