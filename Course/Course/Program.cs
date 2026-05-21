using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantas pessoas registradas: ");
            int pessoasRegistradas = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < pessoasRegistradas; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Funcionario: {i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.Write("Nome: ");
                string nome =Console.ReadLine()!;
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine()! , CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(id , nome, salario);

                lista.Add(funcionario);
            }

            Console.WriteLine();
            Console.Write("Entre com id da pessoa para aumento: ");
            int idFunc = int.Parse(Console.ReadLine()!);

            Funcionario comparaId = lista.Find(x => x.Id == idFunc)!;

            if (comparaId != null)
            {
                Console.WriteLine();
                Console.Write("Digite a porcentagem: ");
                double porcetagem = double.Parse(Console.ReadLine()! , CultureInfo.InvariantCulture);
                comparaId.AumentoDeSalario(porcetagem);
            }
            else
            {
                Console.WriteLine("ID não correspondente.");
            }

            foreach (var listaFuncionario in lista)
            {
                Console.WriteLine();
                Console.WriteLine(listaFuncionario);
            }
        }
    }
}