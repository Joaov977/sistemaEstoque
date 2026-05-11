using System.IO;

namespace SistemaEstoque
{
    public class Estoque
    {
        private const string CaminhoArquivo = "estoque.txt";
        private List<Produto> produtos = new();

        public Estoque() => CarregarDoArquivo();

        public void Adicionar(string nome, int qtd, double preco)
        {
            produtos.Add(new Produto { Nome = nome, Quantidade = qtd, Preco = preco });
            SalvarNoArquivo();
        }

        public void Listar()
        {
            Console.WriteLine("\n--- ITENS NO ESTOQUE ---");
            foreach (var p in produtos)
                Console.WriteLine($"Produto: {p.Nome} | Qtd: {p.Quantidade} | Preço: R${p.Preco:F2}");
        }

        private void SalvarNoArquivo()
        {
            
            var linhas = produtos.Select(p => p.ToString());
            File.WriteAllLines(CaminhoArquivo, linhas);
        }

        private void CarregarDoArquivo()
        {
            if (File.Exists(CaminhoArquivo))
            {
                var linhas = File.ReadAllLines(CaminhoArquivo);
                foreach (var linha in linhas)
                {
                    var dados = linha.Split(';');
                    produtos.Add(new Produto { 
                        Nome = dados[0], 
                        Quantidade = int.Parse(dados[1]), 
                        Preco = double.Parse(dados[2]) 
                    });
                }
            }
        }
    }
}