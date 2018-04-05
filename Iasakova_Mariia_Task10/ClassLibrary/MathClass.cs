namespace ClassLibrary
{
    public class MathClass
    {
        public static long Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        public static long Power(int n, int m)
        {
            var n1 = 1;

            for (int i = 1; i <= m; i++)
            {
                n1 = n1 * n;
            }

            return n1;
        }
    }
}
