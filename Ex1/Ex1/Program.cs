using Ex1.Entities.Classes;
using Ex1.Entities.Enum;
using System.Globalization;

Console.WriteLine("\nBem-vindo ao zoologico de maximinos");

int numeroAnimais = Inserir.Int("\nQuantos animais deseja registrar: ");

int i = 0;
Animais animalAtual;
List<Animal> animais = new();

while (i < numeroAnimais)
{
    animalAtual = Inserir.QueAnimalEs();
    i++;

    if (animalAtual is Animais.Peixe)
    {
        animais.Add(new Peixe());
        continue;
    }

    if (animalAtual is Animais.Ave)
    {
        animais.Add(new Ave());
        continue;
    }

    animais.Add(new Mamifero());

}

if(animais.Count == 0)
{
    Console.WriteLine("\nVocê não insiriu animais ._.");
    Console.WriteLine("\nObrigado por ter utilizado o programa :)");
    return;
}

string menssagem = animais.Count == 1 ? 
    $"\nFoi {animais.Count} animal inserido:" :
    $"\nForom os {animais.Count} animais inseridos:";

Console.WriteLine(menssagem);

foreach(var animal in animais)
{
    if(animal is Ave)
    {
        Console.WriteLine("\n\t" + animal.EmitirSom());
        continue;
    }

    if(animal is Mamifero)
    {
        Console.WriteLine("\n\t" + animal.EmitirSom());
        continue;
    }

    if(animal is Peixe)
    {
        Console.WriteLine("\n\t" + animal.EmitirSom());
        continue;
    }
}

Console.WriteLine("\nMuito obrigado por ter utilizado este programa (:");