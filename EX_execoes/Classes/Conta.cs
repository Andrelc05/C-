using System;
using System.Collections.Generic;
using System.Text;

namespace EX_execoes.Classes
{
    class Conta
    {
        public int Numero { get; set; }
        public string Nome { get; set; }

        public double Valor { get; set; }

        public double Liminte { get; set; }

        public double Saque { get; set; }

        public Conta(int numero, string nome, double valor, double liminte, double saque)
        {
            Numero = numero;
            Nome = nome;
            Valor = valor;
            Liminte = liminte;
            Saque = saque;
        }

        public void CalculoS() 
        {
            if (Valor < Saque)
            {
                throw new Ex("Saque muito maior que valor contido na conta");
            }
            if (Liminte < Saque)
            {
                throw new Ex("Saque muito maior que valor Limite");
            }
            Valor -= Saque; 
            
        }
        public override string ToString()
        {
            return "Valor restante da conta: " + Valor;                           
        }



    }
}
