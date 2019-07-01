using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castle_practice_
{
    static class Program
    {
        public static string BinaryConvert(int n) //задание 3
        {
            string s;
            switch (n)
            {
                case 0: s = "0000"; break;
                case 1: s = "0001"; break;
                case 2: s = "0010"; break;
                case 3: s = "0011"; break;
                case 4: s = "0100"; break;
                case 5: s = "0101"; break;
                case 6: s = "0110"; break;
                case 7: s = "0111"; break;
                case 8: s = "1000"; break;
                case 9: s = "1001"; break;
                case 10: s = "1010"; break;
                case 11: s = "1011"; break;
                case 12: s = "1100"; break;
                case 13: s = "1101"; break;
                case 14: s = "1110"; break;
                case 15: s = "1111"; break;
                default: s = "0000"; break;
            }

            return s;
        }
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
    }
}
