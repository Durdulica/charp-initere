using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace initiere
{
    internal class Lotto
    {
        private static void NumGenerator(List<int> winningNumbers)
        {
           for(int i = 0; i < 6; i++)
            {
                int tryRes = RandomNumberGenerator.GetInt32(49);
                while (winningNumbers.Contains(tryRes) || tryRes == 0)
                {
                    tryRes = RandomNumberGenerator.GetInt32(49);
                }
                winningNumbers.Add(tryRes);
            }
        }

        private static void NumReader(List<int> numbers)
        {
            for (int i = 0; i < numbers.Capacity; i++)
            {
                int aux = Int32.Parse(Console.ReadLine());
                while (numbers.Contains(aux) || aux < 1 || aux > 49)
                {
                    if (aux < 1 || aux > 49)
                    {
                        Console.WriteLine("Number out of bounds, try another one: ");
                    }
                    else
                    {
                        Console.WriteLine("Already choose this number, try another one: ");
                    }
                    aux = Int32.Parse(Console.ReadLine());
                }
                numbers.Add(aux);
            }
        }

        private static List<int> IntersectLists(List<int> first, List<int> second)
        {
            List<int> result = new List<int>(int.Min(first.Count, second.Count));

            if(first.Count < second.Count)
            {
                for(int i = 0; i < first.Count; i++)
                {
                    if (second.Contains(first[i]))
                    {
                        result.Add(first[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < second.Count; i++) {
                    if (first.Contains(second[i]))
                    {
                        result.Add(second[i]);
                    }
                }
            }

            return result;
        }

        public static void Joc()
        {
            List<int> numbers = new List<int>(6);
            List<int> winningNumbers = new List<int>(6);

            NumGenerator(winningNumbers);
            NumReader(numbers);

            Console.Clear();
            List<int> results = IntersectLists(numbers, winningNumbers);

            Console.Write("Winning Numbers: ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(winningNumbers[i] + " ");
            }

            if (results.Count == winningNumbers.Count)
            {
                Console.WriteLine("\nYOU WON!!!");
            }
            else
            {
                if (results.Any())
                {
                    Console.Write("You guessed the numbers: ");
                    for (int i = 0; i < results.Count; i++)
                    {
                        Console.Write(results[i] + " ");
                    }
                }
                else
                {
                    Console.Write("You did NOT guess any number");
                }
            }
        }

        //functie ce primeste ca parametru 2 liste de numere intregi si reurneaza o lista cu numere intregi intersecta celor 2 liste
    }
}