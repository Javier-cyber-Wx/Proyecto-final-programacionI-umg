using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Proyecto_final_programacionI.datos;

namespace Proyecto_final_programacionI
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void boton_agregar_Click(object sender, EventArgs e)
        {
            Datos Datos = new Datos();
            Datos.Codigo = Convert.ToInt64(txt_codigo.Text);
            int resultado = Agregar.Agregar.agregar(Datos);
            if(resultado > 0)
            {
                MessageBox.Show("Datos guaradados con exito","Datos Guardados",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error en el guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
