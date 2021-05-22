using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Administrativo
    {
        int idAdministrativo;
        String nombre;
        String correo;
        String estado;

        public int IdAdministrativo { get => idAdministrativo; set => idAdministrativo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
