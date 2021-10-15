
namespace exercicio_fixacao_vetores {
    class Quarto {
        public string Nome { get; set; }
        public string Email { get; set; }
       
        public Quarto(string name, string email) {
            Nome = name;
            Email = email;
        }

        public override string ToString() {
            return Nome +", "+ Email ;
        }

    }
}
