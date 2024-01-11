using Ex3.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.Entities.Classes
{
    internal class Inserir
    {
        public static int Int(string enunciado)
        {
            while (true)
            {
                Console.Write(enunciado);
                if (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out int result) && result > 0)
                    return result;

                Console.WriteLine("\nNota inválida!!!! Tente novamente");
            }
        }

        public static DateTime DateTime(string enunciado, string formato)
        {
            while (true)
            {
                Console.Write(enunciado);
                if (System.DateTime.TryParseExact(Console.ReadLine(), formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                    return data;

                Console.WriteLine("\nFecha inválida!!!! Tente novamente");
            }
        }

        public static Product Produto()
        {
            string nome = String("\n\tQual é o nome do novo produto?: ");
            double price = Double($"\n\tQual é o preço  de {nome}?: ");
            
            return new(nome, price);
        }

        public static ImportedProduct ProdutoImportado()
        {
            Product product = Produto();
            double customsFee = Double($"\n\tQual é o custom fee do {product.Name}?: ");

            return new(product.Name, product.Price, customsFee);
        }

        public static UsedProduct ProdutoUsado()
        {
            Product product = Produto();
            DateTime data = DateTime($"\n\tQuando voltaram o {product.Name}?(dd/MM/yyyy): ", "dd/MM/yyyy");

            return new(product.Name, product.Price, data);
        }

        public static double Double(string enunciado)
        {
            while (true)
            {
                Console.Write(enunciado);
                if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double result) && result >= 0)
                    return result;

                Console.WriteLine("\nNota inválida!!!! Tente novamente");
            }
        }

        public static Products NivelProdutos(int numeroDeProduto)
        {
            while (true)
            {
                string nivel = String("\nDe que nível é o novo produto (Common/Used/Imported)?: ");

                if(nivel.ToLower() == "common")
                {
                    Console.WriteLine($"\nInformação do {numeroDeProduto}º produto common:");
                    return Products.Common;
                }

                if (nivel.ToLower() == "used")
                {
                    Console.WriteLine($"\nInformação do {numeroDeProduto}º produto used:");
                    return Products.Used;
                }

                if (nivel.ToLower() == "imported")
                {
                    Console.WriteLine($"\nInformação do {numeroDeProduto}º produto imported:");
                    return Products.Imported;
                }

                Console.WriteLine("\nNivel inválido!!!! Tente novamente");
            }
        }

        public static string String(string enunciado)
        {
            string texto;

            while (true)
            {
                Console.Write(enunciado);
                texto = Console.ReadLine();

                if (!string.IsNullOrEmpty(texto))
                    return texto.Trim();

                Console.WriteLine("\n\tValor invalido!!!!!! Tente novamente");
            }
        }
    }
}
