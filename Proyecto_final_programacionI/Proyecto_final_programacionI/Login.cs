using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace Proyecto_final_programacionI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion_sql.obtenerConexion();
            try
            {
                conexionBD.Open();
                MySqlCommand login = new MySqlCommand();
                login.Connection = conexionBD;
                login.CommandText = ("select *from login where Username = '"+txtUsuario.Text+"'and Contraseña = '"+txtContraseña.Text+"' ");
                MySqlDataReader leer_datos = login.ExecuteReader();
                if (leer_datos.Read())
                {
                    MessageBox.Show("Bienvenido estimado");
                    Sistema Principal = new Sistema();
                    Principal.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectas");
                }
                conexionBD.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message + b.StackTrace);
            }
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}