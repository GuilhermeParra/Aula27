using System.IO;

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
            
  
            public void Cadastrar(Produto prod){
                var linha = new string[] { PrepararLinha(prod) };
                File.AppendAllLines(PATH, linha);
            }
            //1;Celular;600
             private string PrepararLinha(Produto p){
                return $"Codigo={p.Codigo};Nome={p.Nome};Preco={p.Preco}";
        }
    }
}