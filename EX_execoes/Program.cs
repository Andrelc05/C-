using System;
using EX_execoes.Classes;

namespace EX_execoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Dados da conta");
                Console.Write("Digite o numero da conta: ");
                int NumeroConta = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome: ");
                string Nome = Console.ReadLine();
                Console.Write("Digite o valor da conta: ");
                double Valor = double.Parse(Console.ReadLine());
                Console.Write("Digite o limite de saque: ");
                double Limite = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor de saque: ");
                double Saque = double.Parse(Console.ReadLine());

                Conta Pessoa = new Conta(NumeroConta, Nome, Valor, Limite, Saque);
                Pessoa.CalculoS();

                Console.WriteLine(Pessoa);
            }

            catch (Ex e) //e é apelido
            {
                Console.WriteLine(e.Message); // função para capturar a mensagem da classe de Exeções
            }
            catch (FormatException a) //a é apelido
            {
                Console.WriteLine("Erro de formato: " + a);
            }

        }
    }
}






