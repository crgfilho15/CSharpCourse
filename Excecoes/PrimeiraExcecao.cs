using System;
using System.Collections.Generic;
using System.Text;

// 'throw' lança a exceção
// 'try' tenta executar o código
// 'catch' captura a exceção para tratá-la, caso haja alguma
// 'finally' sempre será executado independente de ter exceção ou não

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente!");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_223.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");
            } catch (Exception ex) // Tipo mais genérico: Exception (Pega todas as exceções)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            } finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
