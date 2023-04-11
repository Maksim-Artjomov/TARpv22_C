using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv22_C
{
    public class Alamprog
    {
        public static void NStars()
        {
            Console.WriteLine("Kordade arv: ");
            int n = int.Parse(Console.ReadLine());
            int[] stars = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} arv",i+1);
                stars[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int num in stars)
            {
                Console.Write(Stars(num));
                Console.WriteLine();
            }
        }
        public static string Stars(int n)
        {
            string var = "";
            for (int i = 0; i < n; i++)
            {
                var += "*";
            }
            return var;
        }
        public static string Kassik(int arv1, int arv2, char tehe)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            double j = Convert.ToDouble(table.Compute(arv1.ToString()+tehe.ToString() + arv2.ToString(), String.Empty));

            j=Math.Round(j,2);
            string vastus = "";
            string nur = "nurr";
            for (int i = 0; i < Math.Abs(Convert.ToInt32(j)); i++)
            {
                vastus = vastus + nur;
            }

            return vastus;
        }
        //public static void Kassik()
        //{
        //    Console.WriteLine("Sisestage esimene arv: ");
        //    int a = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Sisestage esimene arv: ");
        //    int b = int.Parse(Console.ReadLine());
        //    string t = Console.ReadLine();
        //    int n = 0;
        //    if (t == "+")
        //    {
        //        n = a + b;
        //    }
        //    else if (t == "-")
        //    {
        //        n = a - b;
        //    }
        //    else if (t == "*")
        //    {
        //        n = a * b;
        //    }
        //    else if (t == "/")
        //    {
        //        n = a / b;
        //        n = Math.Round(n, 2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error");
        //    }
        //    if (n > 0)
        //    {
        //        for (int i =0; i < n; i++) 
        //        {
        //            Console.WriteLine("nurr ");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error");
        //    }
        //}
        public static int Keskarv(int n)
        {
            int x;
            int y = 0;
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("Palun, sisestage {0} arvud",i+1);
                x = int.Parse(Console.ReadLine());
                y += x;
            }
            return y / n;
        }
        public static int Korruta(int arv1, int arv2) 
        {
            return arv1 * arv2;
        }
        public static void Tere(string name)
        { 
            Console.WriteLine("Tere {0}",name);
        }
    }
}
