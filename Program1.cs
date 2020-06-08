using System;
using static System.Convert;
using static System.Console;
using static System.String;


namespace ConsoleApp13
{
    class Program
    {

        static void Main(string[] args)
        {
            WriteLine("1 - задание №1; \n2 - задание №2; \n3 - задание №3. ");
            int n = ToInt32(ReadLine());
            if (n == 1)
            {
                string s = ReadLine();
                int v = 0;
                int a = s.IndexOf("f");
                for (int i = a+1; i < s.Length; i++)
                {
                    string g = (s[i] + "");
                    if (String.Compare("f", g) == 0 )
                    {
                        WriteLine(i);
                        v++;
                        break;
                    }
                   
                }
                if (a < 0) WriteLine(-2);
                else if (v == 0) WriteLine(-1);
            }
            else if (n == 2)
            {
                string s = ReadLine();

                string pr = "";
                string[] r = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
                string[] e = { "A", "B", "V", "G", "D", "E", "YO", "ZH", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "KH", "c", "CH", "SH", "SHCH", "", "I", "'", "E", "YU", "YA" };


                for (int j = 0; j < s.Length; j++)
                {
                    int i = 0;
                    while (i < r.Length)
                    {
                        string a = s[j] + "";
                        if (String.Compare(a, r[i]) == 0)
                        {
                            pr = pr + e[i];
                            i++;
                        }
                        else i++;
                    }
                }
                WriteLine(pr);
            }
            else if (n == 3)
            {
                string s = ReadLine();
                int ds = s.IndexOf("h");
                int lol = s.LastIndexOf("h");
                string kt = "";
                for (int i = 0; i < s.Length; i++)
                {
                    string g = (s[i] + "");
                    if (String.Compare("h", g) == 0 && i != ds && i != lol)
                    {
                        kt = kt + "H";
                    }
                    else kt = kt + s[i];
                }
                WriteLine(kt);
            }
        }
    }
}
