using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final
{
    class Veiculo
    {
        private string modelo;
        private string placa;

        public Veiculo(string modelo, string placa)
        {
            this.modelo = modelo;
            this.placa = placa;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
    }
}
