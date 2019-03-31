using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Petle
{
    class Program
    {
        const char CHAR = '*';
        static void Star() => Console.Write(CHAR);
        static void StarLn() => Console.WriteLine(CHAR);
        static void Space() => Console.Write(" ");
        static void SpaceLn() => Console.WriteLine(" ");
        static void NewLine() => Console.WriteLine();

        public static void Prostokat(int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            for (int j = 1; j < m - 1; j++)
            {
                Star();
                for (int i = 1; i < n - 1; i++)
                    Space();

                StarLn();
            }

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
        }

        static void LiteraX(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            //górna połówka
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //pojedyncza gwiazdka w środku
            for(int i=0;i<n/2;i++)
            {
                Space();
            }
            StarLn();

            //dolna połówka, symetrycznie do górnej
            for(int i=0;i<n/2;i++)
            {
                for(int j=0;j<n/2-1-i;j++)
                {
                    Space();
                }
                Star();
                for(int j=0;j<2*i+1;j++)
                {
                    Space();
                }
                StarLn();
            }

        }
        static void LiteraZ(int n)
        {
            
            for(int i=0;i<n;i++)
            {
                Star();
            }
            NewLine();
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n-1-i;j++)
                {
                    Space();
                }
                StarLn();
            }
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
        }
        static void LiteraZv2(int n)
        {

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Space();
                }
                StarLn();
            }
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
        }

        static void Klepsydra(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            //górna połówka
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                    Space();
                Star();
                for (int j = 0; j < n - 2 - 2 * i; j++)
                    Space();
                StarLn();
            }

            //pojedyncza gwiazdka w środku
            for (int i = 0; i < n / 2; i++)
            {
                Space();
            }
            StarLn();

            //dolna połówka, symetrycznie do górnej
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Space();
                }
                StarLn();

               
            }
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
        }

        static void Klepsydrav2(int n)
        {
            if (n < 3) throw new ArgumentException("zbyt mały rozmiar");
            if (n % 2 == 0) n = n + 1;

            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();

            
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < n-3 - 2 * i; j++)
                {
                    Space();
                }
                StarLn();
            }


           
            for (int i = 0; i < n / 2; i++)
            {
                for (int j = 0; j < n / 2 - 1 - i; j++)
                {
                    Space();
                }
                Star();
                for (int j = 0; j < 2 * i; j++)
                {
                    Space();
                }
                StarLn();


            }
            for (int i = 0; i < n; i++)
            {
                Star();
            }
            NewLine();
        }

        static void trojkat_pusty(int n)
        {
           
        }

        public static void Main(string[] args)
        {
            //Prostokat(5, 7);
            LiteraX(14);
            Console.WriteLine("------------");
            LiteraX(8);
            Console.WriteLine("------------");
            LiteraZ(8);
            Console.WriteLine("------------");
            LiteraZv2(8);
            Console.WriteLine("------------");
            Klepsydra(8);
            Console.WriteLine("------------");
            Klepsydrav2(15);
            Console.WriteLine("------------");
            trojkat_pusty(7);
        }

    }
}
