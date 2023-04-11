using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv22_C
{
    public class StartClass
    {
        public static void Main(string[] args)
        {
            //string nimi = "Python";
            //Alamprog.Tere(nimi);
            //int a = 12;
            //int b = 2;
            //int vastus = Alamprog.Korruta(a, b);
            //Console.WriteLine(vastus);
            //Console.WriteLine(Alamprog.Korruta(5,6));

            //Console.WriteLine("Palin, sisestage numbrite arv: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Keskmine arv on {0}",Alamprog.Keskarv(n));
            //Console.WriteLine(Alamprog.Kassik(1,2,));
            //Alamprog.Stars(n);
            Alamprog.NStars();

            //{
            //    Random rnd = new Random();
            //    //for (int i = 0; i < 10; i++)
            //    //{
            //    //    int nr = rnd.Next(1, 7);
            //    //    Console.WriteLine(nr);
            //    //    string paev = "";
            //    //    switch (nr)
            //    //    {
            //    //        case 1: paev = "Esmaspäev"; break;
            //    //        case 2: paev = "Teisipäev"; break;
            //    //        case 3: paev = "Kolmapäev"; break;
            //    //        case 4: paev = "Neljapäev"; break;
            //    //        case 5: paev = "Reede"; break;
            //    //        case 6: paev = "Laupäev"; break;
            //    //        case 7: paev = "Pühapäev"; break;
            //    //        default:
            //    //            paev = "Tundmatu päev";
            //    //            break;
            //    //    }
            //    //    int j = 0;
            //    //    while (j < 10)
            //    //    {
            //    //        Console.WriteLine(paev);
            //    //        j++;
            //    //    }
            //    //    Console.WriteLine(j);
            //    //    do
            //    //    {
            //    //        Console.WriteLine(paev);
            //    //        j--;

            //    //    } while (j != 0);
            //    //    Console.WriteLine(j);
            //    //    int[] arvud = new int[10];
            //    //    for (int i = 0 < i < arvud.Length; i++)
            //    //    {
            //    //        arvud[i] = rnd.Next(-100, 100);
            //    //    }
            //    //    foreach (var arv in arvud)
            //    //    {
            //    //        Console.WriteLine(arv);
            //    //    }
            //    //}
            //    //Console.WriteLine("Tere tulemast!\n Mis on sinu nimi?");
            //    //string eesnimi=Console.ReadLine();
            //    //Console.WriteLine("Tere " + eesnimi + "!");
            //    //Console.WriteLine(eesnimi + ", sisestage palun kaks arvud");
            //    //Console.WriteLine("Arv1: ");
            //    //int arv1 = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("Arv2: ");
            //    //int arv2 = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("Tehe: ");
            //    //char tehe = char.Parse(Console.ReadLine());
            //    //if (tehe=='+')
            //    //{
            //    //    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}! :3", arv1, arv2, arv1 + arv2);
            //    //}
            //    //else if (tehe=='-')
            //    //{
            //    //    Console.WriteLine("Arvude {0} ja {1} summa võrdub {2}! :3", arv1, arv2, arv1 - arv2);
            //    //}

            //    //&&-and ||-or
            //    //{
            //    //    Console.WriteLine("Zadanie 1");
            //    //    Console.WriteLine("Tere tulemast! Mis on sinu nimi? ");
            //    //    string eesnimi = Console.ReadLine();
            //    //    Console.WriteLine("Tere, " + eesnimi);
            //    //    if (eesnimi.ToLower() == "juku")
            //    //    {
            //    //        Console.WriteLine("Tule minu juurde külla!");
            //    //        Console.WriteLine(eesnimi + ", skolko tebe let? ");
            //    //        int let = int.Parse(Console.ReadLine());
            //    //        if (let < 6)
            //    //            Console.WriteLine("Bilet besplatnij!");
            //    //        else if (let >= 6 && let <= 14)
            //    //            Console.WriteLine("Detskij bilet!");
            //    //        else if (let >= 15 && let <= 65)
            //    //            Console.WriteLine("Polnij bilet!");
            //    //        else if (let >= 65 && let <= 65)
            //    //            Console.WriteLine("Lgotnij bilet!");
            //    //        else if (let < 0 && let > 100)
            //    //            Console.WriteLine("Value error");

            //    //    else
            //    //        Console.WriteLine("Täna mind kodus pole!");
            //    //    }
            //    //    {
            //    //        Console.WriteLine("----------------------");
            //    //        Console.WriteLine("Zadanie 2");
            //    //        Console.WriteLine("Tere tulemast! Sisestage palun kaks nimi?");
            //    //        string eesnimi1 = Console.ReadLine();
            //    //        string eesnimi2 = Console.ReadLine();
            //    //        if (eesnimi1 == "M" && eesnimi2 == "A" || eesnimi1 == "A" && eesnimi2 == "M")
            //    //        {
            //    //            Console.WriteLine("Tere " + eesnimi1 + "!");
            //    //            Console.WriteLine("Tere " + eesnimi2 + "!");
            //    //            Console.WriteLine(eesnimi1 + " ja " + eesnimi2 + " istuge täna õhtul üksteise kõrvale!");
            //    //        }
            //    //    }
            //    //    {
            //    //        Console.WriteLine("----------------------");
            //    //        Console.WriteLine("Zadanie 3");
            //    //        Console.WriteLine("See on ristkülikukujuline tuba. Palun sisestage selle ruumi seinte pikkus meetrites: ");
            //    //        Console.WriteLine("Arv1: ");
            //    //        int razmer1 = int.Parse(Console.ReadLine());
            //    //        Console.WriteLine("Arv2: ");
            //    //        int razmer2 = int.Parse(Console.ReadLine());
            //    //        Console.WriteLine("Ruumi pindala on {0} m2", razmer1 * razmer2);
            //    //        Console.WriteLine("Kas soovite remonti teha?");
            //    //        string answer = Console.ReadLine();
            //    //        if (answer == "jah")
            //    //            {
            //    //            Console.WriteLine("Kui palju maksab 1 ruutmeeter? ");
            //    //            }
            //    //        int cena = int.Parse(Console.ReadLine());
            //    //        Console.WriteLine("1 ruutmeeter maksab {cent}");
            //    //        Console.WriteLine("Põranda vahetus läheb maksma {0} * {1}", razmer1 * razmer2, cena);
            //    //        else if (answer == "ei")
            //    //            {
            //    //            Console.WriteLine("Oki");
            //    //            }
            //    //    }
            //    //    int arv1 = int.Parse(Console.ReadLine());
            //    //    int arv2 = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            //    //    Console.ReadLine();
            //    //}




            //        Console.WriteLine("Zadanie 1");
            //        int N = rnd.Next(-10, 10);
            //        int M = rnd.Next(1, 10);
            //        int chis = 0;
            //        if (N < 0 && M < 0)
            //        {
            //            if (N < M)
            //            {
            //                chis = Math.Abs(N) - Math.Abs(M);
            //            }
            //            else
            //            {
            //                chis = Math.Abs(M) - Math.Abs(N);
            //            }
            //        }
            //        else if (N<0 && M>0)
            //        {
            //            chis = Math.Abs(N) + M;
            //        }
            //        else if (M<0 && N>0)
            //        {
            //            chis = Math.Abs(M) + N;
            //        }
            //        else
            //        {
            //            if (M>N)
            //            {
            //                chis = M - N;
            //            }
            //            else
            //            {
            //                chis = N - M;
            //            }
            //        }
            //    //    Console.WriteLine("Zadanie 2");
            //    //    Console.WriteLine("Sisestage palun viis arvud: ");
            //    //    Console.WriteLine("Arv1: ");
            //    //    int arv1 = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine("Arv2: ");
            //    //    int arv2 = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine("Arv3: ");
            //    //    int arv3 = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine("Arv4: ");
            //    //    int arv4 = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine("Arv5: ");
            //    //    int arv5 = int.Parse(Console.ReadLine());
            //    //    Console.WriteLine("{0}+{1}+{2}+{3}+{4}",arv1 + arv2 + arv3 + arv4 + arv5);
            //    //    Console.WriteLine("");
            //    //    Console.WriteLine("");
            //}
            //Console.WriteLine("1    2    3    4    5    6    7    8    9   10\n2    4    6    8   10   12   14   16   18   20\n3    6    9   12   15   18   21   24   27   30\n4    8   12   16   20   24   28   32   36   40\n5   10   15   20   25   30   35   40   45   50\n6   12   18   24   30   36   42   48   54   60\n7   14   21   28   35   42   49   56   63   70\n8   16   24   32   40   48   56   64   72   80\n9   18   27   36   45   54   63   72   81   90\n10   20   30   40   50   60   70   80   90  100");
            Console.ReadKey();//используется для того, что бы не вылетала слишком быстро консоль






            //11.04.2023











        }
    }
}