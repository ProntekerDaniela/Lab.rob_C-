using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLab12
{
    class Number1 : Number
    {
        int n;
       
        public int[] number_1()
        {
            int[] arr = new int[n];
            Random ran = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < n; i++)
            {
                arr[i] = ran.Next(-100, 100);

            }
            return arr;

        }
        public int[] number_2()
        {
            while (true)
            {
                int[] rim = new int[n];
                Random ran = new Random(DateTime.Now.Millisecond);
                int summa = 0;

                for (int i = 0; i < rim.Length; i++)
                {
                    if (i < rim.Length - 1 && rim[i] == 'I' && rim[i + 1] != 'I') continue;
                    else if (rim[i] == 'I')
                        summa += 1;
                    else if (rim[i] == 'V')
                    {
                        if (i > 0 && rim[i - 1] == 'I') summa += 4;
                        else summa += 5;
                    }

                    else if (rim[i] == 'X')
                    {
                        if (i > 0 && rim[i - 1] == 'I') summa += 9;
                        else if (i < rim.Length - 1 && (rim[i + 1] == 'L' || rim[i + 1] == 'C')) continue;
                        else summa += 10;
                    }

                    else if (rim[i] == 'L')
                    {
                        if (i > 0 && rim[i - 1] == 'X') summa += 40;
                        else summa += 50;
                    }

                    else if (rim[i] == 'C')
                    {
                        if (i > 0 && rim[i - 1] == 'X') summa += 90;
                        else if (i < rim.Length - 1 && (rim[i + 1] == 'D' || rim[i + 1] == 'M')) continue;
                        else summa += 100;
                    }
                    else if (rim[i] == 'D')
                    {
                        if (i > 0 && rim[i - 1] == 'C') summa += 400;
                        else summa += 500;
                    }

                    else if (rim[i] == 'M')
                    {
                        if (i > 0 && rim[i - 1] == 'C') summa += 900;
                        else summa += 1000;
                    }

                }
            }
        }

        static string[] nums_1_9 = "ноль один два три чотири п'ять шість сім вісім дев'ять".Split();
        static string[] nums_10_19 = "десять одинадцять дванадцять тринадцять чотирнадцять п'ятнадцять шістнадцять сімнадцать вісімнадцять дев'ятнадцять".Split();
        static string[] nums_20_90 = "ноль десять двадцять тридцять сорок п'ятдесят шістдесят сімдесят вісімдесят дев'яносто".Split();
        static string[] nums_100_900 = "ноль сто двісті тристо чотиристо п'ятсот шістсот сімсот вісімсот дев'ятсот".Split();
        static string[] razrad = @" тисяч мільйон міліард трильион квадрильйон квинтильйон".Split();


        static string[] number_3()
        {
           var n = "54308428790203478762340052723346983453487023489987231275412390872348475";
           
        }
        
        static IEnumerable<string> splitIntoCategories(string s)
        {
            s = s.PadLeft(s.Length + 3 - s.Length % 3, '0');
            return Enumerable.Range(0, s.Length / 3).Select(i => s.Substring(i * 3, 3));
        }
        
        static IEnumerable<string> solve(IEnumerable<string> n)
        {
            var ii = 0;
            foreach (var s in n)
            {
                var countdown = n.Count() - ++ii;
                yield return
                    String.Format(@"{0} {1} {2} {3}",
                        s[0] == '0' ? "" : nums_100_900[getDigit(s[0])],
                        getE1(s[1], s[2]),
                        getE2(s[1], s[2], countdown),
                        s == "000" ? "" : getRankName(s, countdown)
                    );
            }

        }
        
        private static string getE1(char p1, char p2)
        {
            if (p1 != '0')
            {
                if (p1 == '1')
                    return nums_10_19[getDigit(p2)];
                return nums_20_90[getDigit(p1)];
            }
            return "";
        }
      
        private static string getE2(char p1, char p2, int cd)
        {
            if (p1 != '1')
            {
                if (p2 == '0') return "";
                return (p2 == '2' && cd == 1) ? "две" : nums_1_9[getDigit(p2)];
            }
            return "";
        }

        private static int getDigit(char p1)
        {
            return Int32.Parse(p1.ToString());
        }
        
        public string getRankName(string s, int ii)
        {
            if (ii == 0) return "";
            var r = razrad[ii];
            //10 11 ...
            if (s[1] == '1') return r + (ii == 1 ? "" : "ов");

            if (new[] { '2', '3', '4' }.Contains(s[2]))
            {
                return r + (ii == 1 ? "і" : "а");
            }
            else
                return r + (ii == 1 ? "" : "");
        }
        
    }
}
