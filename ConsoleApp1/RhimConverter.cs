using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class RhimConverter
    {
        private int number { get; set; }
        private char[] charArr { get; set; }

        private List<int> listNum = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private List<string> listString = new List<string> { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        private Dictionary<string, int> dict = new Dictionary<string, int> { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, {"M", 1000} };
        public RhimConverter(string num)
        {
            var num1 = int.Parse(num);
            if (num1 > 0 && num1 < 4000)
            {
                this.number = num1;
                ShowRhimType();
            }
            else if (int.TryParse(num, out int n))
            {
                charArr = num.ToCharArray();
                ShowArabType();
            }
            else Console.WriteLine("Число должно быть от 1 до 3999!");
        }
        public void ShowRhimType()
        {
            var rhimNum = "";

            for (int i = 0; i < listNum.Count; i++)
            {
                while (number >= listNum[i])
                {
                    number -= listNum[i];
                    rhimNum += listString[i];
                }
            }

            Console.WriteLine(rhimNum);
        }

        public void ShowArabType()
        {
            var resultNum = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                resultNum += dict[charArr[i].ToString()];
            }
            Console.WriteLine(resultNum.ToString());
        }
    }
}
