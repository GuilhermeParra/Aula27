using System;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Codigo = 3;
            p1.Nome = "The Witcher 3";
            p1.Preco = 200.00f;

            p1.Cadastrar(p1);

            
            List<Produto> lista = p1.Ler();
            lista = p1.Ler();

            foreach(Produto item in lista){
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
        }
    }
}
