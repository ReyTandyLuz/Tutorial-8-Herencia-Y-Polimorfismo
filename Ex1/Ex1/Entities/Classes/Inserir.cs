using Ex1.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.Entities.Classes
{
    internal class Inserir
    {
        public static int Int(string enunciado)
        {
            while (true)
            {
                Console.Write(enunciado);
                if (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out int result) && result > 0 - 1)
                    return result;

                Console.WriteLine("\nNúmero inválida!!!! Tente novamente");
            }
        }

        public static Animais QueAnimalEs()
        {
            string texto;

            while (true)
            {
                Console.Write("\nQual animal é? Peixe/Mamífero/Ave?: ");
                texto = Console.ReadLine();

                if (!string.IsNullOrEmpty(texto))
                {
                    if (texto.ToLower() == "peixe")
                    {
                        Console.WriteLine("\nPeixe inserido com sucesso");
                        return Animais.Peixe;
                    }

                    if (texto.ToLower() == "ave")
                    {
                        Console.WriteLine("\nAve inserido com sucesso");
                        return Animais.Ave;
                    }

                    if (texto.ToLower() == "mamífero" || texto.ToLower() == "mamifero")
                    {
                        Console.WriteLine("\nMamífero inserido com sucesso");
                        return Animais.Mamifero;
                    }
                }

                Console.WriteLine("\nOpção inválida!!!!! É PEIXE/MAMIFERO/AVE!!!");
            }
        }
    }
}
