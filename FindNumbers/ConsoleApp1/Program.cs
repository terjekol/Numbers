namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lastPre = null;
            for (long number = 123456789; number <= 9876543210; number++)
            {
                var nStr = "" + number;
                var pre = nStr.Substring(0, 2);
                if (pre != lastPre)
                {
                    Console.WriteLine(pre);
                    lastPre = pre;
                }
                if (nStr.Length!=9) nStr = '0' + nStr;
                if (isValidNumber(nStr) && isCorrectNumbers(nStr))
                    Console.WriteLine(nStr);
            }
        }


        static bool isValidNumber(string n)
        {
            return n.Contains('0')
                && n.Contains('1')
                && n.Contains('2')
                && n.Contains('3')
                && n.Contains('4')
                && n.Contains('5')
                && n.Contains('6')
                && n.Contains('7')
                && n.Contains('8')
                && n.Contains('9');
        }

        static bool isCorrectNumbers(string allNumbers)
        {
            var number1 = Convert.ToInt32(allNumbers.Substring(0, 3));
            var number2 = Convert.ToInt32(allNumbers.Substring(3, 2));
            var number3 = Convert.ToInt32(allNumbers.Substring(5, 3));
            var number4 = Convert.ToInt32(allNumbers.Substring(8, 2));
            return number1 * number2 == number3 * number4;
        }

    }
}