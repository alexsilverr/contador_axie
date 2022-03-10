using System;

namespace ConsoleApp7
{
    class ContadorDeEnergiaaxie
    {
        static void Main(string[] args)
        {

            int s = 0;
            int r = 0;
            int e = 3;
            int total = e;
            int siguiente = 2;
            bool salir = true;



            while (salir)
            {
                Console.WriteLine("--------------axie ----------------");
                Console.WriteLine(" z suma || x resta || c sieguiente ");
                Console.WriteLine("--------------axie ----------------");
                Console.WriteLine("energia total :" + total + ":          ");
                Console.WriteLine("-------------axie ---------------- ");
                Console.WriteLine("         (v) calculador            ");
                string sele = Console.ReadLine();
                if (sele == "z")
                {
                    r++;
                    total = total + r;
                    r = 0;


                }
                Console.Clear();
                if (sele == "x")
                {

                    total = total - 1;
                    r = 0;

                }
                Console.Clear();
                if (sele == "c")
                {

                    total = total + 3;
                }
                Console.Clear();
                if (sele == "v")
                {

                    Console.WriteLine("ingrese el nuemro :");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el nuemro :");
                    int num2 = int.Parse(Console.ReadLine());
                    int total1 = num1 + num2;
                    Console.WriteLine("total:"+total1);

                }

            }
        }
    }

}
