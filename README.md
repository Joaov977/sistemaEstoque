# Sistema de Controle de Estoque (C#)

Este é um projeto pré-intermediário desenvolvido em C# para demonstrar conceitos de Orientação a Objetos, manipulação de arquivos locais e lógica de programação em console.

O sistema permite cadastrar produtos, definir quantidades e preços, e mantém os dados salvos mesmo após fechar o programa.

## Funcionalidades

*   **Cadastro de Produtos:** Adiciona nome, quantidade e preço.
*   **Persistência de Dados:** Salva tudo automaticamente em um arquivo `.txt`.
*   **Listagem Dinâmica:** Lê o arquivo e exibe os itens formatados no console.
*   **Arquitetura Limpa:** Separação entre Modelo (Dados) e Lógica de Negócio.

## Tecnologias Utilizadas

*   **Linguagem:** C#
*   **Plataforma:** .NET 8.0 (ou superior)
*   **IDE:** Visual Studio Code
*   **Manipulação de Arquivos:** `System.IO`
*   **Gerenciamento de Versão:** Git & GitHub

## Estrutura do Projeto

*   `Program.cs`: Interface do usuário e menu principal.
*   `Estoque.cs`: Lógica principal (Salvar, Carregar, Adicionar).
*   `Produto.cs`: Classe modelo com as propriedades do item.
*   `estoque.txt`: Banco de dados simples gerado automaticamente.