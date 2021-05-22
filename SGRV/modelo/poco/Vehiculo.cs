using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.poco
{
    class Vehiculo
    {
        private int idVehiculo;
        private String marca;
        private String modelo;
        private String ano;
        private String color;
        private String nombreAseguradora;
        private String polizaSeguro;
        private String placas;
        private String estado;
        private int idConductor;

        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Ano { get => ano; set => ano = value; }
        public string Color { get => color; set => color = value; }
        public string NombreAseguradora { get => nombreAseguradora; set => nombreAseguradora = value; }
        public string PolizaSeguro { get => polizaSeguro; set => polizaSeguro = value; }
        public string Placas { get => placas; set => placas = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdConductor { get => idConductor; set => idConductor = value; }
    }
}
