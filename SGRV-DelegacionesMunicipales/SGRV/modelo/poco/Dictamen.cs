using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Dictamen
    {
        int folio;
        String descripcion;
        DateTime fecha;
        int idPerito;
        int idReporte;
        String hora;
        String estado;

        public int Folio { get => folio; set => folio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdPerito { get => idPerito; set => idPerito = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
