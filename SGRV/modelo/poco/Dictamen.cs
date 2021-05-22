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
        DateTime fehcaYHora;
        int idPerito;
        int idReporte;
        String estado;

        public int Folio { get => folio; set => folio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FehcaYHora { get => fehcaYHora; set => fehcaYHora = value; }
        public int IdPerito { get => idPerito; set => idPerito = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
