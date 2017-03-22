using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning8
{
    class Program
    {
        //Skapar en array med 5 index
        static string[] namesArray = new string[5];

        static void Main(string[] args)
        {
            //Metod som låter användaren mata in namn
            AddNames();
            //Sorterar namn
            ReverseNameArray();
            //Byta nam
            ChangeName();
            //Skriver ut alla namn
            AllNames();
            //Sorterar alfabetiskt
            SortAlphabetically();
        }

        private static void SortAlphabetically()
        {
            Console.WriteLine("Sorterar alfabetiskt");



        }

        //Skriver ut alla namn genom en for-loop
        private static void AllNames()
        {
            for (int i = 0; i < namesArray.Length; i++)
            {
                Console.WriteLine(namesArray[i]);
            }
        }

        //Frågar vilket namn användaren vill byta, samt ändrar det
        private static void ChangeName()
        {
            Console.WriteLine("Vilken plats vill du byta namn på? ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vad är det nya namnet? ");
            string inputName = Console.ReadLine();

            inputNumber--;
            Console.WriteLine(inputNumber);

            namesArray[inputNumber] = inputName;
        }

        //Sorterar namn så de blir baklänges
        private static void ReverseNameArray()
        {
            Console.WriteLine("Baklänges blir det:");
            for (int i = namesArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(namesArray[i]);
            }
        }

        //Lägger till namn som användare matar in genom en for-loop i en do while
        private static void AddNames()
        {
            bool isRunning = true;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Skriv in ett namn: ");
                    string name = Console.ReadLine();
                    namesArray[i] = name;
                }
                isRunning = false;
            } while (isRunning);
        }
    }
}
