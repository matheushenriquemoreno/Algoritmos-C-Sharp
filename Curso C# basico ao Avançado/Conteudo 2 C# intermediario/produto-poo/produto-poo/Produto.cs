using System.Globalization;


namespace produto_poo {
    class Produto {

        private string _nome;
        public double Preco { get; private set; } // auto property e utilizada em atributos que não tem alterações
        public double Quantidade { get; private set; }

        public Produto() { // construtor padrao
            Quantidade = 0;
        }

        public Produto(string nome, double preco) : this() { //contrustor com parametros a receber, utilizando sobrecarga
            _nome = nome;
            Preco = preco;
        }


        public Produto(string nome, double preco, int quantidade) : this(nome, preco) { // contrustor com parametros a receber 
            Quantidade = quantidade;
        }

     

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {// value = valor atribuido/ adiconado 
                    _nome = value;
                }

            }

        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
           Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " , "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
