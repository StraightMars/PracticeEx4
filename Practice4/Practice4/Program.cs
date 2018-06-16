using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int osn = 2;
            int step = -200;
            string s, tt;
            int k, a, b, length;
            s = "2";
            tt = s;
            k = 0;
            a = (Convert.ToInt32(tt[0]) * osn + k);
            Console.WriteLine(a);
            //for (int i = -190; i > step; i--)
            //{
            //    tt = s;
            //    length = tt.Length;
            //    s = "";
            //    k = 0;
            //    for (int j = 0; j < length; j++)
            //    {
            //        a = (Convert.ToInt32(tt[j])) * osn + k;
            //        b = a % 10;
            //        k = a / 10;
            //        s += Convert.ToString(b);
            //        if (k != 0)
            //        {
            //            s += Convert.ToString(k);
            //        }
            //    }
            //}
            //char[] ch = s.ToCharArray();
            //for (int i = 0; i < ch.Length / 2; i++)
            //{
            //    char tmp = ch[ch.Length - i - 1];
            //    ch[ch.Length - i - 1] = ch[i];
            //    ch[i] = tmp;
            //}
            //s = new string(ch);
            ////Console.WriteLine(s);
        }
    }
}
