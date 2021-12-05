
namespace TestesDeUnidadeRhinoMocks
{
    public abstract class ProdutoBase
    {
        public abstract string Nome { get; set; }
        public abstract double Preco { get; set; }

        // Método responsável por salavar o conceito produto.
        public abstract void Salvar();
    }
}
