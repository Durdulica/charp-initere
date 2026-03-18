using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace initiere
{
    internal class Spanzuratoarea
    {
        private static string RevealChar(string text, string letters)
        {
            string result = "";
            for (int i = 0; i < text.Length; i++) {
                int aux = letters.IndexOf(text[i]);
                if (aux >= 0)
                {
                    result += letters[aux];
                }
                else  if (text[i] == ' ')
                {
                    
                    result += " ";
                }
                else
                {
                    result += "_";
                }
            }
            return result;
        }

        private static string wordGenerator()
        {
            string list = "mere pere joaca cartofi penar creion calorifer casti gard scolar informatica bacalaureat castor masinuta spalatorie cumparaturi";
            string[] word = list.Split(' ');

            
            return word[RandomNumberGenerator.GetInt32(word.Length)];
        }
        public static void joc()
        {
            string sentence = wordGenerator();
            string letters = Char.ToString(sentence[0]);
            string result = RevealChar(sentence, letters);

            Console.WriteLine(result);

            for (int i = 0; i < 5; i++)
            {
                letters += Char.Parse(Console.ReadLine());
                System.Console.Clear();

                result = RevealChar(sentence, letters);

                if (!result.Contains("_"))
                {
                    Console.WriteLine("You won!");
                    return;
                }

                if (sentence.Contains(letters[letters.Length - 1])) i--;

                Console.WriteLine(result);
            }

            Console.WriteLine("You lost!");
            Console.WriteLine("The answer was: " + sentence);
        }

        //functie ce  ia ca paramtetru 2 text de ex "Ana are mere" ,"ae"=>"A_a a_e _e_e"      
    }
}