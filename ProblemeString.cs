using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace initiere{
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
                    text = text.Substring(0, i) + char.ToLower(text[i]) + text.Substring(i + 1);
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
        {   //se considera un sir de n cuv. Sa se det. cuv. cel mai mic in ordine lexicografica obtinut prin concatenarea a doua dintre cuv. citite
            string text;
            int n = Int32.Parse(Console.ReadLine());
            text = Console.ReadLine();

            string[] cuvinte = text.Split(' ');
            int max = int.MinValue, maxLast = int.MinValue;
            string best = null, bestLast = null;

            for (int i = 0; i < n; i++)
            {
                if (max < string.Compare(best, cuvinte[i]))
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

        public static void ex8()
        {   //se da un sir de max. 200 carac. Sa se elim spatiile multiple dintre cuvinte
            string text = "Ana   are  mere";
            string textNou = "";
            string[] cuvinte = text.Split(' ');
            for (int i = 0; i < cuvinte.Length; i++)
            {
                if (cuvinte[i] != "")
                {
                    textNou += cuvinte[i] + " ";
                }
            }
            Console.WriteLine(textNou.Trim());
        }

        public static void ex9()
        {
            //sa se transforme prima litera din fiecare cuvant in litera mare si sa se inlocuiasca ultima litera din fiecare
            //cuv. cu urmatoarea de dupa ea in alfabet
            string text = "Ana are mere";
            string textNou = "";
            string[] cuvinte = text.Split(' ');

            for (int i = 0; i < cuvinte.Length; i++)
            {
                textNou += char.ToUpper(cuvinte[i][0]) + cuvinte[i].Substring(1, cuvinte[i].Length - 2);
                if (cuvinte[i][cuvinte[i].Length - 1] == 'z')
                {
                    textNou += "a ";
                }
                else
                {
                    textNou += (char)(cuvinte[i][cuvinte[i].Length - 1] + 1) + " ";
                }
            }

            Console.WriteLine(textNou.Trim());
        }

        public static void ex10()
        {
            //sa se dubleze toate vocalele mari si sa se stearga toate vocalele mici
            string text = "Ana are mEre";

            text = text.Replace("A", "AA").Replace("E", "EE").Replace("I", "II").Replace("O", "OO").Replace("U", "UU");
            text = text.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

            Console.WriteLine(text);
        }

        public static void ex11()
        {
            //sa se realizeze suma tuturor cifrelor din sir
            string text = "Ana are 80 mere,13 pere si 7 prune";
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    int number = (int)text[i] - '0';
                    i++;
                    while (char.IsDigit(text[i]))
                    {
                        number *= 10;
                        number += (int)text[i] - '0';
                        i++;
                    }
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }

        public static void ex12()
        {
            //sa se verifice de cate ori apare ultimul cuvant in tot sirul
            string text = "Ana are mere mere si mere";
            string[] cuvinte = text.Split(' ');
            int index = 0;
            for (int i = 0; i < cuvinte.Length; i++)
            {
                if (string.Compare(cuvinte[i], cuvinte[cuvinte.Length - 1]) == 0)
                {
                    index++;
                }
            }

            Console.WriteLine(index);
        }


        public static void ex13()
        {
            //sa se interschimbe elementele sirului in oglinda fata de mijloc
            string text = "lupus";
            string textNou = null;
            for (int i = 0; i < text.Length; i++)
            {
                textNou += text[text.Length - 1 - i];

            }

            Console.WriteLine(textNou.Trim());
        }

        public static void ex14()
        {   //sa se numere toate literele mici. Sa se verifice daca toate literele sunt consoane
            string text = "Ana are mere";

            string vocale = "aeiou";

            for(int i = 0; i < text.Length; i++)
            {
                
            }
        }
    }
}