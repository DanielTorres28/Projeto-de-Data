using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj02_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem = "\n\nBoa Noite", nome; // Declaração de Variáveis 
            Console.WriteLine(DateTime.Now);
            mensagem = "\n\nBoa Noite"; // Atribuição de Valor 
            nome = "Daniel"; // Atribuição de Valor   
            Console.WriteLine(mensagem +" "+ nome);
            Console.Write("\n\nRepresentantes do 1bds: " + nome + " e "); // os caracteres \n (arrab n) corresponde espaçamento de linhas 
            nome = "Carlos";
            Console.WriteLine(nome);
            Console.WriteLine(mensagem + " " + nome);
                //Console.Writeline("\n\nRepresentantes do 1bds: " + nome +" e " + nome);
            nome = "";
            Console.Write("Pressione qualquer tecla para encerrar este programa...");
            Console.ReadKey();
        }
    }
}
