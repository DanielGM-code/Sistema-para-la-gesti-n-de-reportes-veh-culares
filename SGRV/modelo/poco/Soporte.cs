using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Soporte
    {
        int idSoporte;
        String nombre;
        String correo;
        String estado;

        public int IdSoporte { get => idSoporte; set => idSoporte = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
