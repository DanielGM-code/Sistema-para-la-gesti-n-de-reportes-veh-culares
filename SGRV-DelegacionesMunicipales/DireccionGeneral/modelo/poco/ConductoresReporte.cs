using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class ConductoresReporte
    {
        private int idConductoresReporte;
        private int idReporte;
        private int idConductor;

        public int IdConductoresReporte { get => idConductoresReporte; set => idConductoresReporte = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
        public int IdConductor { get => idConductor; set => idConductor = value; }
    }
}
