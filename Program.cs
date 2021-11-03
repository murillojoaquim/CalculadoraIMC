using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Digite o seu peso em kg: ");
            string peso = Console.ReadLine();
            Console.Write("Digite sua altura em m: ");
            string altura = Console.ReadLine();

            double imc = Convert.ToDouble(peso) / (Convert.ToDouble(altura) * Convert.ToDouble(altura));

            Console.WriteLine($"Seu IMC é {imc:N2} kg/m²");
            Console.Write("Diagnóstico: ");

            if (imc < 17)
            {
                Console.WriteLine("Muito abaixo do peso.");
            }
            else if (imc <= 18.49)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (imc <= 24.99)
            {
                Console.WriteLine("Peso normal.");
            }
            else if (imc <= 29.99)
            {
                Console.WriteLine("Acima do peso.");
            }
            else if (imc <= 34.99)
            {
                Console.WriteLine("Obesidade I");
            }
            else if (imc <= 39.99)
            {
                Console.WriteLine("Obesidade II (severa)");
            }
            else
            {
                Console.WriteLine("Obesidade III (mórbida)");
            }
        }
    }
}
