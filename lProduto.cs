using System.Collections.Generic;


namespace Aula27_28_29_30
{
    public interface lProduto
    {
         
         List<Produto> Ler();
         

         void Cadastrar(Produto prod);
            

            void Remover(string _termo);

            void Alterar(Produto produtoAlterado);
         }
    }
