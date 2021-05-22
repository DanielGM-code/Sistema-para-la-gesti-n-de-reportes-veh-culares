using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Fotografia
    {
        private int idFotografia;
        private String rutaArchivo;
        private int idReporte;
        private String estado;

        public int IdFotografia { get => idFotografia; set => idFotografia = value; }
        public string RutaArchivo { get => rutaArchivo; set => rutaArchivo = value; }
        public int IdReporte { get => idReporte; set => idReporte = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
