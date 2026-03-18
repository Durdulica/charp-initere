using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
        public static void Joc()
        {
            List<int> list = new List<int>();
            List<int> numbers = new List<int>(6);
            List<int> winningNumbers = new List<int>(6);

            NumGenerator(winningNumbers);

            for (int i = 0; i < numbers.Capacity; i++)
            {
                int aux = Int32.Parse(Console.ReadLine());
                while (numbers.Contains(aux) || aux < 1 || aux > 49)
                {
                    if(aux < 1 || aux > 49)
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

            Console.Clear();
            Console.WriteLine("Winning Numbers: ");
            int index = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write(winningNumbers[i] + " ");
                if (numbers.Contains(winningNumbers[i]))
                {
                    index++;
                }
            }

            if (index == 6) {
                Console.WriteLine("\nYOU WON!!!");
            }
            else
            {
                Console.WriteLine("\nYou got " + index + " numbers right");
            }
        }
    }
}
