using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Entities
{
    internal class Insertar
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

        public static Employee Employee()
        {
            Console.WriteLine("\nInformações do novo Employee: ");

            string nombre = String("\nQual é o nome do novo empregado?: ");
            int horas = Int($"\nQuantas horas trabalha {nombre} ao dia?: ");
            double valorPorHora = Double($"\nQual é o valor por hora feita de {nombre}?: ");

            return new(nombre, horas,valorPorHora);
        }

        public static OutSourcedEmployee OutSourcedEmployee()
        {
            Console.WriteLine("\nInformações do novo out sourced employee: ");

            var empregado = Employee();
            double additionalCharge = Double("\nQual é a comissão do empregado?: ");


            return new(empregado.Name, empregado.Hours, empregado.ValuePerHour, additionalCharge);
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

        public static bool IsOutput()
        {
            string texto;

            while (true)
            {
                Console.Write("\nO empregado é externo? Sim/Não?: ");
                texto = Console.ReadLine();

                if (!string.IsNullOrEmpty(texto))
                {
                    if (texto.ToLower() == "sim")
                        return true;

                    if (texto.ToLower() == "não" || texto.ToLower() == "nao")
                        return false;
                }

                Console.WriteLine("\nOpção inválida!!!!! É SIM/NÃO!!!");
            }
        }
    }
}
