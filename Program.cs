using System;

namespace VS_code
{
    class Program
    {
        static int[] s;
        static Random r = new Random();
        static int b, max;
        static void Main(string[] args)
        {
            s = new int[100];
            b = s.Length;
            for (int i = 0; i < b; i++)
            {
                s[i] = r.Next(-100, 100);
                Console.WriteLine("Элемент №{0}: значение {1}.", i + 1, s[i]);
            }
            max = s[1];
            for (int j = 2; j < b; j++)
            {
                if (s[j] > max)
                {
                    max = s[j];
                }
            }
            for (int a = 0; a < b; a++)
            {
                if (max == s[a])
                {
                    Console.WriteLine("Максимальный элемент №{0} массива со значением {1}", a + 1, max);
                }
            }
			Console.ReadKey();
        }
    }
}