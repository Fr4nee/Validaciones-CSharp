using System;

namespace VALIDACIONES
{
	class Program
	{
        static void Main(string[] args)
        {
            string datostr;
            string valstr;
            int datoint;
            string valint;

            // VALIDACION DE STRING

            Console.Write("introduci el dato: ");
            datostr = Console.ReadLine();

            Console.WriteLine($"{datostr} es correcto? s/n");
            valstr = Console.ReadLine().Trim().ToLower();

            while (valstr != "s" && valstr != "n")
            {
                Console.WriteLine("Error, ingrese 's' o 'n'");
                valstr = Console.ReadLine().Trim().ToLower();
            }

            while (valstr == "n")
            {
                Console.WriteLine("Reingrese el dato");
                datostr = Console.ReadLine();
                Console.WriteLine($"{datostr} es correcto? s/n");
                valstr = Console.ReadLine().Trim().ToLower();
            }

            if (valstr == "s")
            {
                Console.WriteLine("Ok");
            }

            Console.ReadKey();

            // VALIDACION DE NUMERO ENTERO 

            Console.Write("introduci el numero: ");
            int.TryParse(Console.ReadLine(), out datoint);

            Console.WriteLine($"{datoint} es correcto? s/n");
            valint = Console.ReadLine().Trim().ToLower();

            while (valint != "s" && valint != "n")
            {
                Console.WriteLine("Error, ingrese 's' o 'n'");
                valint = Console.ReadLine().Trim().ToLower();
            }

            while (valint == "n")
            {
                Console.Write("Reingrese el numero: ");
                int.TryParse(Console.ReadLine(), out datoint);
                Console.WriteLine($"{datoint} es correcto? s/n");
                valint = Console.ReadLine().Trim().ToLower();
            }

            if (valint == "s")
            {
                Console.WriteLine("Ok");
            }

            Console.ReadKey();

        }
	}
}
