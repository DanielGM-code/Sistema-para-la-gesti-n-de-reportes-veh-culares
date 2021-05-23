using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Delegacion
    {
        int idDelegacion;
        String nombre;
        String direccion;
        String codigoPostal;
        String municipio;
        String telefono;
        String correo;
        String estado;

        public int IdDelegacion { get => idDelegacion; set => idDelegacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public string Municipio { get => municipio; set => municipio = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Estado { get => estado; set => estado = value; }

        override
        public string ToString()
        {
            return this.Nombre;
        }
    }
}
