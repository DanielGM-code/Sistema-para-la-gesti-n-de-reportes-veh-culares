using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Usuario
    {
        int idUsuario;
        String username;
        String contraseña;
        String cargo;
        int idDelegacion;
        String estado;
        String delegacion;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Username { get => username; set => username = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Delegacion { get => delegacion; set => delegacion = value; }
    }
}
