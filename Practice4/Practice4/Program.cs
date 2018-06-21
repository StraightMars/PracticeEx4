using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4_практика
{
    class Program
    {
        static List<int> Multiplication(List<int> list)
        {
            int result;
            int perenos = 0;
            for (int i = 0; i < list.Count; i++)
            {
                result = list[i] * 5;
                list[i] = (result + perenos) % 10;
                perenos = (result + perenos) / 10;
            }
            if (perenos != 0)
            {
                list.Add(perenos);
            }
            return list;
        }
        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            int dot = 1;
            string nuli = "", chisla = "";
            string chislaReversed;
            for (int i = 1; i < 200; i++)
            {
                Multiplication(list);
                dot++;
            }
            for(int i = 0; i < dot; i++)
            {
                nuli += "0";
            }
            for (int i = 0; i < list.Count; i++)
            {
                 chisla += list[i];
            }
            chislaReversed = Reverse(chisla);
            Console.WriteLine("0." + nuli + chislaReversed);
        }
    }
}