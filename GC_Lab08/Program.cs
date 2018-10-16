using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Lab08
{
    class Program

    {
        static void Main(string[] args)
        {
            /// int [,] = new int [ 3,2] // array with three rows and 2 columns
            string[,] StudentInfo = new string[,]
            {
                {"Yuga Aoyama", "Shining Hero", "Navel Laser"},
                { "Denki Kaminari", "Chargebolt", "Electrification"},
                { "Eijiro Kirishma", "Red Riot", "Hardening"},
                { "Koji Koda", "Anima", "Anivoice" },
                { "Rikido Sato", "Sugarman", "Sugar Rush"},
                { "Mina Ashido", "Alien Queen", "Acid"},
                { "Tsuyu Asiu", "Froppy", "Frog"},
                { "Tena Iida", "Ingeniumu", "Engine"},
                { "Ochaco Uraraka", "Uravity", "Zero Gravity"},
                { "Mashirao Ojiro", "Tailman", "Tail"},
                { "Mezo Shoji", "Tentacole", "Dupli-Arms"},
                { "Kyoka Jiro", "Earphone Jack", "Earphone Jack"},
                { "Hanta Sero", "Cellophane", "Tape"},
                { "Fumikage Tokoyami", "Tsukuyomi", "Dark Shadow"},
                { "Shoto Todoroki", "Shoto", "Half-Hot Half-Cold"},
                { "Toru Hgakure", "Invisible Girl", "Invisibility" },
                { "Kasuki Bakugo", "Kacchan", "Explosion"},
                { "Izuku Midoriya", "Deku", "One For All"},
                { "Minoru Mineta", "Grape Juice", "Pop Off"},
                { "Momo Yaoyorozu", "Creati", "Creation"},
            };

            while (true)
            {
                try
                {
                    Console.WriteLine("U.A. High: Class 1-A Directory. Enter number of student to look up (1-20)");
                    int num = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine($"Student number {num}: {Name(StudentInfo, num)}");

                    while (true)
                    {
                        Console.WriteLine($"What would you like to know about {StudentInfo[num - 1, 0]}? (you may enter 'name' to get ther student's Hero Name or 'quirk' for their quirk.)");
                    string entry = Console.ReadLine();
                    
                        if (entry.ToLower() == "name")
                        {
                            Console.WriteLine(HeroName(StudentInfo, num));
                        }
                        if (entry.ToLower() == "quirk")
                        {
                            Console.WriteLine(Quirk(StudentInfo, num));
                        }
                        else
                        {
                            Console.WriteLine("Incorrect entry. Please start again.");
                            break;
                        }
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Oops, something went wrong. Please start again");
                    continue;
                }

            }
        }
        public static string Name(string[,] StudentInfo, int num)
        {
            return StudentInfo[num - 1, 0];
        }

        public static string HeroName(string[,] StudentInfo, int num)
        {
            string heroName = StudentInfo[num - 1, 1];
            return $"{Name(StudentInfo, num)}'s hero name is {heroName}";
        }

        public static string Quirk(string[,] StudentInfo, int num)
        {
            string quirk = StudentInfo[num - 1, 2];
            return $"{Name(StudentInfo, num)}'s quirk is {quirk}";
        }
    }
}
