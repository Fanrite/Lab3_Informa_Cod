using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Informa_Cod
{
    class Program
    {
        static string Ob (ref string m)
        {
            string output = "";
            char[] mc = m.ToCharArray();


            output += "Перевірка на Парність - ";
            byte t = 0;

            for (int i = 0; i <= 6; i++)
                if(mc[i] == '1') t ++;

            if (t % 2 == 0) output += m + "0";
            else output += m + "1";

            output += "\n";


            output += "Код з Повтором - ";
            output += m + m;
            output += "\n";


            output += "Код Кореляціїї - ";

            string bufK = "";
            for (int i = 0; i <= 6; i++)
            {
                if (mc[i] == '0') bufK += "01";
                else if (mc[i] == '1') bufK += "10";
            }
            output += bufK + "\n";


            output += "Інверсний код - ";

            if (t % 2 == 0) output += m + m + "\n";
            else if (t % 2 != 0)
            {
                bufK = "";
                for (int i = 0; i <= 6; i++)
                {
                    if (mc[i] == '0') bufK += "1";
                    else if (mc[i] == '1') bufK += "0";
                }

                output += m + bufK + "\n";
            }

            return output + "\n";
        }

        static string MoreO (ref string m)
        {
            while (m.Length < 7) m = 0 + m;

            return m;
        }


        static void Main(string[] args)
        {
            int mUser = 18;
            string output = "404";

            Console.WriteLine("Введіть m: ");
            mUser = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            string m = Convert.ToString(mUser, 2);
            m = MoreO(ref m);

            string m2 = Convert.ToString((mUser * 2), 2);
            m2 = MoreO(ref m2);

            string m3 = Convert.ToString((mUser * 3), 2);
            m3 = MoreO(ref m3);

            string m4 = Convert.ToString((mUser * 4), 2);
            m4 = MoreO(ref m4);


            output = "Для m :\n";
            output += Ob(ref m);

            output += "Для m2 :\n";
            output += Ob(ref m2);

            output += "Для m3 :\n";
            output += Ob(ref m3);

            output += "Для m4 :\n";
            output += Ob(ref m4);



            Console.WriteLine($"{output}");
            Console.ReadKey();
        }
    }
}
