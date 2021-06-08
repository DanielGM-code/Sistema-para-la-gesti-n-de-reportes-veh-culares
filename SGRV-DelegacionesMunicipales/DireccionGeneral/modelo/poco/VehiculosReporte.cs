using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class VehiculosReporte
    {
        private int idVehiculosReporte;
        private int idReporte;
        private int idVehiculo;

        public int IdVehiculosReporte { get => idVehiculosReporte; set => idVehiculosReporte = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
    }
}
