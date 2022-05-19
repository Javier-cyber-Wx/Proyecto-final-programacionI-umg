using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_programacionI.datos
{
    public class Datos
    {
        public Int64 Codigo { get; set; }
        

        public Datos() { }
        public Datos(Int64 pcodigo)
        {
            Codigo = pcodigo;
        }
    }
}
