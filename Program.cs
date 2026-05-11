using SistemaEstoque;

Estoque estoque = new();
while (true)
{
    Console.WriteLine("\n1- Novo | 2- Listar | 0- Sair");
    string opcao = Console.ReadLine() ?? "";

    if (opcao == "1")
    {
        Console.Write("Nome: "); string nome = Console.ReadLine() ?? "";
        Console.Write("Qtd: "); int qtd = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Preço: "); double preco = double.Parse(Console.ReadLine() ?? "0");
        
        estoque.Adicionar(nome, qtd, preco);
        Console.WriteLine("✅ Produto salvo!");
    }
    else if (opcao == "2") { estoque.Listar(); }
    else if (opcao == "0") { break; }
}