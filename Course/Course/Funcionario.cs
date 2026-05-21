using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Course
{
    class Funcionario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoDeSalario(double porcetagem)
        {
            Salario += Salario * porcetagem / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario.ToString("F2" , CultureInfo.InvariantCulture);
        }
    }
}
