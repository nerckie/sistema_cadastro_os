using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final
{
    class Serviço
    {
        private string nome;
        private double valor;
        private int qte;

        public Serviço(string nome, double valor, int qte)
        {
            this.nome = nome;
            this.valor = valor;
            this.qte = qte;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Valor { get => valor; set => valor = value; }
        public int Qte { get => qte; set => qte = value; }

        public double valortot()
        {
            return qte * valor;
        }
    }
}
