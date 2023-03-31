using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7лаба_Андреева_ориг_
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static string ReverseChar(string str)
        {
            string tamp = str;
            string a_en = "qwertyuiopasdfghjklzxcvbnm";
            string A_en = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string a_ru = "йцукенгшщзхъфывапролджэячсмитьбю";
            string A_ru = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮ";

            for(int i = 0; i < tamp.Length; i++)
            {
                if (a_en.Contains(tamp[i]))
                {
                    int index = a_en.IndexOf(tamp[i]);
                    tamp = tamp.Remove(i, 1);
                    tamp = tamp.Insert(i, Convert.ToString(A_en[index]));
                }
                else if (A_en.Contains(tamp[i]))
                {
                    int index = A_en.IndexOf(tamp[i]);
                    tamp = tamp.Remove(i, 1);
                    tamp = tamp.Insert(i, Convert.ToString(a_en[index]));
                }
                else if (a_ru.Contains(tamp[i]))
                {
                    int index = a_ru.IndexOf(tamp[i]);
                    tamp = tamp.Remove(i, 1);
                    tamp = tamp.Insert(i, Convert.ToString(A_ru[index]));
                }
                else if (A_ru.Contains(tamp[i]))
                {
                    int index = A_ru.IndexOf(tamp[i]);
                    tamp = tamp.Remove(i, 1);
                    tamp = tamp.Insert(i, Convert.ToString(a_ru[index]));
                }
            }

            return tamp;
        }
    }
}
