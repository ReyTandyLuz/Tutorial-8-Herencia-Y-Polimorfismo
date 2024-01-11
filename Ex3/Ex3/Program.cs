using Ex3.Entities.Classes;
using Ex3.Entities.Enums;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("\nBem-vindo à mercadoria de maximinos");

int numeroAnimais = Inserir.Int("\nQuantos produtos vai desejar registrar: ");

int i = 0;
Products ProdutoAtual;
List<Product> produtos = new(); //Adaptar el código

while (i < numeroAnimais)
{
    i++;
    ProdutoAtual = Inserir.NivelProdutos(i);

    if (ProdutoAtual is Products.Common)
    {
        produtos.Add(Inserir.Produto());
        continue;
    }

    if (ProdutoAtual is Products.Used)
    {
        produtos.Add(Inserir.ProdutoUsado());
        continue;
    }

    produtos.Add(Inserir.ProdutoImportado());

}

if (produtos.Count == 0)
{
    Console.WriteLine("\nVocê não insiriu algúm produto ._.");
    Console.WriteLine("\nObrigado por ter utilizado o programa :)");
    return;
}

string menssagem = produtos.Count == 1 ?
    $"\nFoi {produtos.Count} produto inserido:" :
    $"\nForom {produtos.Count} produtos inseridos:";

Console.WriteLine(menssagem);

foreach (var produto in produtos)
{
    if (produto is ImportedProduct)
    {
        Console.WriteLine("\n\t" + produto.PriceTag());
        continue;
    }

    if (produto is UsedProduct)
    {
        Console.WriteLine("\n\t" + produto.PriceTag());
        continue;
    }

    Console.WriteLine("\n\t" + produto.PriceTag());
}

Console.WriteLine("\nMuito obrigado por ter utilizado este programa (:");