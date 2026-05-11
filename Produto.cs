namespace SistemaEstoque
{
    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        // Linha formatada para salvar no arquivo .txt
        public override string ToString() => $"{Nome};{Quantidade};{Preco}";
    }
}