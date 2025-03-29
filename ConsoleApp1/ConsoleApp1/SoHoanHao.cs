

namespace ConsoleApp1
{
    public class SoHoanHao
    {
        public void Main()
        {
            Console.WriteLine("Nhap so");
            int n = int.Parse(Console.ReadLine());

            if (PerfectNUmber(n))
            {
                Console.WriteLine("So hoan hao");
            }
            else if (Palindrome(n))
            {
                Console.WriteLine("Số Palindrome");
            }
            else if(Armstrong(n))
            {
                Console.WriteLine("La so Armstrong");
            }
            else
            {
                Console.WriteLine("Khong thuoc so dac biet");
            }

        }

        public bool PerfectNUmber(int n)
        {
            int t = 0;
            for (int i = 1;i< n; i++)
            {
                if (n %i == 0)
                {
                    t = t+ i;
                }
            }
            return n == t? true : false;
        }
        public bool Palindrome(int n)
        {
            int r = 0;
            int temp = n;
            bool soNT = true;
            while (n > 0)
            {
                int t = n % 10;
                r = r * 10 + t;
                n = n / 10;
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) soNT = false;
            }

            if (r == temp && soNT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Armstrong(int n)
        {
            int hat = 0;
            int a = n;
            while (a > 0)
            {
                a = a / 10;
                hat++;
            }
            int temp = 0;
            a = n;
            while (a > 0)
            {
                int t = a % 10;
                temp = (int)(temp + Math.Pow(t, hat));
                a = a / 10;
            }

            return temp == n? true: false;
        }

    }
}
