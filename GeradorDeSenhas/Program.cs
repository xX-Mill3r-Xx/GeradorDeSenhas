using System;
using System.Text;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Entre com um valor que representa a força da Senha: ");
            int qte = int.Parse(Console.ReadLine());
            string Possiblechars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" 
                + "abcdefghijklmnopqrstuvwxyzç" 
                + "123456789" + "#@%$!&";
            Random sort = new Random();
            int sortNumber = 0;
            StringBuilder passWorld = new StringBuilder();
            for(int i = 0; i < qte; i++)
            {
                sortNumber = sort.Next(0, Possiblechars.Length - 1);
                passWorld.Append(Possiblechars[sortNumber]);
            }
            Console.WriteLine($"A senha gerada é: {passWorld}");
            Console.WriteLine();
            Question:
            Console.WriteLine("Gerar Nova senha? (S/N)");
            char res = char.Parse(Console.ReadLine());
            if(res == 's' || res == 'S')
            {
                Console.Clear();
                goto Inicio;
            }
            else if (res == 'n' || res == 'N')
            {
                Console.WriteLine("Obrigado por usar esta Applicação");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Digite um comando valido!");
                goto Question;
            }
        }
    }
}
