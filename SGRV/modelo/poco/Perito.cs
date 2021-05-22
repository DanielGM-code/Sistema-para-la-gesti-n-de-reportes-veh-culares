using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Perito
    {
        int idPerito;
        String nombre;
        String correo;
        String estado;

        public int IdPerito { get => idPerito; set => idPerito = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
