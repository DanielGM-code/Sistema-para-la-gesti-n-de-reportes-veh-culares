using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Conductor
    {
        private int idConductor;
        private String nombre;
        private DateTime fechaNacimiento;
        private String numeroLicencia;
        private String telefono;
        private String estado;

        public int IdConductor { get => idConductor; set => idConductor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string NumeroLicencia { get => numeroLicencia; set => numeroLicencia = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
