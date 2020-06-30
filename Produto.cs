using System.IO;
using System.Collections.Generic;

namespace Aula27_28_29_30
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/Produto.csv" ;


        public Produto(){
            //Solução do desafio
            string Pasta = PATH.Split('/')[0];
            if(!Directory.Exists(Pasta)){
                Directory.CreateDirectory(Pasta);
            }

            //Cria o arquivo, caso nao exista
            if(!File.Exists(PATH)){
                File.Create(PATH).Close();
            }
            }

            /// <summary>
            /// Cadastra um produto
            /// </summary>
            /// <param name="prod">Objeto Produto</param>
            public void Cadastrar(Produto prod){

                var linha = new string[] { PrepararLinha(prod) };
                File.AppendAllLines(PATH, linha);
                
            }

            public List<Produto> Ler(){

                //Criando uma lista que servirá como o retorno
                List<Produto> produtos = new List<Produto>();

                //Lendo o arquivo e tranformando em um array de linhas
                // [0] = Codigo=2;Nome=Gibson;Preco=5000
                string[] linhas = File.ReadAllLines(PATH);

                foreach (string linha in linhas)
                {

                    //separando os dados de cada linha com Split
                    //[0] = codigo=
                    //[1] = nome=Gibson
                    //[2] = preco =7500
                    string[] dado = linha.Split(";");
                    //Criando instância de produtos para serem colocados na lista

                    Produto p =new Produto();
                    
                    p.Codigo = int.Parse(Separar(dado[0]));
                    p.Nome = Separar(dado[1]);
                    p.Preco = float.Parse(Separar(dado[2]));
                    produtos.Add(p);

                    
                }
                return produtos;
            }
            private string Separar(string _coluna){

                //0      1
                //nome = Gibson
                return _coluna.Split ("=")[1];

            }

            //1;Celular;600
             private string PrepararLinha(Produto p){

                return $"Codigo={p.Codigo};Nome={p.Nome};Preco={p.Preco}";

        }
    }
}