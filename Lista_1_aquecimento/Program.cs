using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lista_1_aquecimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome : ");
            Console.WriteLine("Digite seu CPF : ");
            Console.WriteLine("Digite sua data de nascimento: ");
            Console.WriteLine("Digite sua renta mensal: ");
            Console.WriteLine("Digite seu estado civil(C,S V OU D) : ");
            Console.WriteLine("Digite o número de seus dependentes: ");
            


            string nome = Console.ReadLine();
            string cpf = Console.ReadLine();
            string dataNascimento = Console.ReadLine();
            string rendaMensal = Console.ReadLine();
            string estadoCivil = Console.ReadLine();
            string dependentes = Console.ReadLine();

            


            Console.WriteLine(nome);
            Console.WriteLine(cpf);
            Console.WriteLine(dataNascimento);
            Console.WriteLine(rendaMensal);
            Console.WriteLine(estadoCivil);
            Console.WriteLine(dependentes);

            //Validação do cpf
            try
            {
                if (cpf.Length == 11)
                {
                    Console.WriteLine($"Seu CPF é : + {cpf}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Digite um número com exatamente 11 dígitos");
                Console.WriteLine(e.Message);
            }

            //Validação da data de nascimento

            if ()
            {
                dataNascimentoFormatado = dataNascimento.ToString(dataNascimento);
            }



            Console.ReadLine();
        }
    }
}
