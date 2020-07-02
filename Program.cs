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
            p1.Nome = "Sunset Overdrive";
            p1.Preco = 42f;

            p1.Cadastrar(p1);

            Produto alterado = new Produto();
            alterado.Codigo = 1;
            alterado.Nome = "Halo2";
            alterado.Preco = 250f;

            p1.Alterar(alterado);

            p1.Remover("Forza");

            
            
            
            List<Produto> lista = p1.Ler();
            lista = p1.Ler();

            foreach(Produto item in lista){
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
        }
    }
}
