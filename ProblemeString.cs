using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

    internal class ProblemeString
    {
        public static void ex1()
        {   //nr. de aparitii al unei litere in text, litera fiind citita de la tastatura
            string text = "Ana are mere si pere";

            char x = Console.ReadLine()[0];

            string[] cuvinte = text.Split(x);

            int length = cuvinte.Length - 1;

            if (x == text[0])
            {
                length++;
            }

            Console.WriteLine(length);

            //cate vocale apar in textul citit


            string faraVocale = text.ToLower().Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
            Console.WriteLine(text.Length - faraVocale.Length);

            //nr. de aparitii al unei silabe in text. Silaba fiind citita de la tastatura

            string silaba = Console.ReadLine();
            string faraSilabe = text.ToLower().Replace(silaba, "");

            Console.WriteLine((text.Length - faraSilabe.Length) / silaba.Length);
        }

        public static void ex2()
        { //se considera un cuv. Sa se stearga toate aparitiile primei litere din acel cuvant
            string cuvant = "mamaie";

            cuvant = cuvant.Replace(cuvant[0], (char)0);

            Console.WriteLine(cuvant);
        }

        public static void ex3()
        { //se considera un cuv. Sa se afiseze cuvintele obtinute din cuvantul initial prin eliminarea succesiva a primului si ultimului carac. al sirului
            string text = "deosebit";

            while (text != "")
            {
                text = text.Substring(1, text.Length - 2);
                Console.WriteLine(text);
            }
        }

        public static void ex4()
        { //se considera o matr. de dim. nxm cu elem. de tip sir de carac. Sa se afis. sirul de carac. de lungime max. de pe fiecare linie a matr.
            char[][] matr = { };
            int n = 3, m = 3;
            for (int i = 0; i < n; i++)
            {
                string aux = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    matr[i][j] = aux[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                int max = int.MinValue;
                if (matr[i].Length > max)
                {
                    max = matr[i].Length;
                }
                Console.WriteLine(max);
            }
        }

        public static void ex5()
        {   //sa se transforme literele mari in litere mici si literele mici in literele mari
            string text = "Ana ArE meRe";

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    text=text.Substring(0,i)+char.ToLower(text[i])+text.Substring(i+1);
                }
                else if (char.IsLower(text[i]))
                {
                    text = text.Substring(0, i) + char.ToUpper(text[i]) + text.Substring(i + 1);
                }
            }
            Console.WriteLine(text);
        }

        public static void ex6()
        {   //se considera un sir de n cuvinte. Sa se det. cuv. de lung. max. care se poate forma prin concatenarea a doua dintre cuv. citite
            string text;
            int n = Int32.Parse(Console.ReadLine());
            text = Console.ReadLine();

            string[] cuvinte = text.Split(' ');
            int max = -1, maxLast = -1;
            string best = null, bestLast = null;

            for (int i = 0; i < n; i++)
            {
                if (cuvinte[i].Length > max)
                {
                    maxLast = max;
                    bestLast = best;
                    max = cuvinte[i].Length;
                    best = cuvinte[i];
                }
                else if (cuvinte[i].Length > maxLast)
                {
                    maxLast = cuvinte[i].Length;
                    bestLast = cuvinte[i];
                }
            }

            Console.WriteLine(best + bestLast);
        }

        public static void ex7()
        {   //se consider un sir de n cuv. Sa se det. cuv. cel mai mic in ordine lexicografica obtinut prin concatenarea a doua dintre cuv. citite
            string text;
            int n = Int32.Parse(Console.ReadLine());
            text = Console.ReadLine();

            string[] cuvinte = text.Split(' ');
            int max = int.MinValue, maxLast = int.MinValue;
            string best = null, bestLast = null;

            for (int i = 0; i < n; i++)
            {
                if (max < string.Compare(best,cuvinte[i]))
                {
                    maxLast = max;
                    bestLast = best;
                    max = string.Compare(best, cuvinte[i]);
                    best = cuvinte[i];
                }
                else if (maxLast < string.Compare(bestLast, cuvinte[i]))
                {
                    maxLast = string.Compare(best, cuvinte[i]);
                    bestLast = cuvinte[i];
                }
            }

            Console.WriteLine(best + bestLast);
        }
    }
}