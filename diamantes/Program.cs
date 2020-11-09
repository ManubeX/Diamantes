using System;

namespace diamantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int ladoRombo = 0, indiceLinea = 0;
            int numBlancos;
            int caracteres = 0;

            Console.WriteLine("Tamaño del lado del rombo");

            ladoRombo = int.Parse(Console.ReadLine());


            if (ladoRombo <= 20 && ladoRombo > 0)
            {
                for (int i = 0; i < ladoRombo; i++)
                {
                    indiceLinea = i;
                    numBlancos = (ladoRombo - indiceLinea);

                    caracteres = (ladoRombo - numBlancos);

                    for (int y = 0; y < numBlancos; y++) {
                        Console.Write(" "); 
                    }

                    for (int k = 0; k <= i; k++)
                    {
                        caracteres = k % 4; 
                        if (caracteres == 0)
                        {
                            Console.Write("@");
                        }
                        else if (caracteres == 1)
                        {
                            Console.Write(".");
                        }
                        else if (caracteres == 2)
                        {
                            Console.Write("o");
                        }
                        else if (caracteres == 3)
                        {
                            Console.Write(".");
                        }

                    }

                    Console.WriteLine();
                }
            }
        }


    }
}

