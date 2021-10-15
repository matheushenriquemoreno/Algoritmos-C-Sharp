using System.Globalization;

namespace exercicio_Poo_list {
    class Funcionario {
        public int Id { get; private set; }
        public string Name { get; private set;  }
        public  double Salary { get; private set; }
       
        public Funcionario(int id, string name, double salario) {
            Id = id;
            Name = name;
            Salary = salario;
        }
        public void IncreaseSalary(double porcentagem) {
            double aumento = Salary * (porcentagem / 100.00);
            Salary += aumento;
        }


        public override string ToString() {
            return Id +", "+ Name +", $ " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }


    }
}
