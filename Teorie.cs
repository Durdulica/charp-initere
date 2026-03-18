using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace initiere
{
    internal class Teorie
    {
        public static void Afisare()
        {

            Console.WriteLine("test");

        }

        public static void Lungime()
        {

            string text = "Ana are mere";

            Console.WriteLine(text.Length);
        }

        public static void Copiere()
        {
            string text1 = "Mergem la scoala";
            string text2 = text1;

            Console.WriteLine(text2);
        }

        public static void Concatenare()
        {
            string text1 = "Ana are ";
            string text2 = "mere";
            string result = text1 + text2;
            Console.WriteLine(result);
        }

        public static void ConcatenareDim()
        {
            string text1 = "Ana are ";
            string text2 = "mere si pere";
            int dimensiune = 7;
            string result = text1 + text2.Substring(0, dimensiune);
            Console.WriteLine(result);
        }

        public static void CautareCaracter()
        {
            char ch = 'a';
            string text = "Ana are mere";

            if (text.Contains(ch))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        public static void Comparare()
        {
            string text1 = "mere";
            string text2 = "pere";
            int comparison = String.Compare(text1, text2);
            if (comparison < 0)
            {
                Console.WriteLine($"<{text1}> e mai mic decat <{text2}>");
            }
            else if (comparison > 0)
            {
                Console.WriteLine($"<{text1}> e mai mare decat <{text2}>");
            }
            else
            {
                Console.WriteLine($"<{text1}> si <{text2}> sunt echivalente");
            }
        }

        public static void Subsir()
        {
            string text1 = "Ana are mere";
            string text2 = "merre";

            if (text1.Contains(text2) || text2.Contains(text1))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }


        public static void Cuvinte()
        {
            string text = "Ana;are mre";

            string[] cuvinte = text.Split(';');

            for (int i = 0; i < cuvinte.Length; i++)
            {
                Console.WriteLine(cuvinte[i]);
            }
        }
    }
}
