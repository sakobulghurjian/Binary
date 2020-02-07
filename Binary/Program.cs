using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Binary(n);
            Console.ReadLine();
        }
        static void Binary(int n)
        {
            List<int> a = new List<int>();
            int x;
            byte b = 1;
            while (n > 0)
            {
                x = n % 2;
                n = n / 2;
                a.Add(x);
            }

            int num = 0;
            for (int i = 0; i < a.Count - 1; i++)
            {
                bool y = false;
                if (a[i] == a[i + 1] && a[i] == 1)
                {
                    b++;
                    y = true;
                }
                if (!y || i == a.Count - 2)
                {
                    if (num < b)
                    {
                        num = b;
                    }
                    b = 1;
                }

            }
            Console.WriteLine(num);
        }
    }
}
