using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComArquivosExercicio.Entities
{
    class Produto
    {

        public string Nome { get; set; }

        public double Valor { get; set; }

        public int QuantidadeVendida { get; set; }


        public Produto(string nome, double valor, int quantidade)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.QuantidadeVendida = quantidade;
        }


        public double RetornaTotalVendas()
        {
            return Valor * QuantidadeVendida;
        }


        public override string ToString()
        {
            return $"Nome: {Nome} Valor do Produto: {Valor.ToString("F2", CultureInfo.InvariantCulture)} Quantidade de itens vendido: {QuantidadeVendida}";
        }

    }
}
