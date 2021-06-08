using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Reporte
    {
        private int idReporte;
        private DateTime fecha;
        private String direccion;
        private String descripcion;
        private String estado;
        private int idAgenteDeTransito;


        public int IdReporte { get => idReporte; set => idReporte = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdAgenteDeTransito { get => idAgenteDeTransito; set => idAgenteDeTransito = value; }
    }
}
