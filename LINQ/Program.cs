using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)

        {
            // Method Syntax
            Console.WriteLine("------Method Syntax------");
            List<string> Games = new List<string>
            {
                "call of duty warzone",//20
                "rocket leage",//12
                "elden ring",//10
                "ark" //1
            };
            //--------------------------------\\

            IEnumerable<String> Order = Games.OrderBy(x => x.Length);// took me so long to see i needed .length
             foreach (string Game in Order)
             {
                Console.WriteLine(Game);
             }
             Console.WriteLine("-------------------------");
            //Query Syntax
            Console.WriteLine("------Query Syntax-------");
            List<string> Gamestwo = new List<string>
            {
                "call of duty warzone",//20
                "rocket leage",//12
                "elden ring",//10
                "ark" //1
            };
            var Length = from GameX in Gamestwo
                         orderby GameX.Length ascending
                         select GameX;
            foreach (string GameX in Length)
            {
                Console.WriteLine(GameX);
            }
            Console.WriteLine("---------------------------");
            







        }
    }
}