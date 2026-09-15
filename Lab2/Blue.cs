using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    
    
    public class Blue
    {
        public static long Fact(long n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Fact(n - 1);
        }
        
        const double E = 0.0001;
        public double Task1(int n, double x)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += (Math.Sin(i * x)) / (Math.Pow(x, i - 1));
            }
            // end

            return answer;
        }
        public double Task2(int n)
        {
            double ans = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                ans += (Math.Pow(-1, i) * ((Math.Pow(5, i)) / (Fact(i))) );
            }
            // end

            return ans;
        }
        public long Task3(int n)
        {
            long answer = 0;
            int prev = 0;
            int num1 = 0;
            // code here
            for (int i = 0; i < n; i++)
            {
                
            }
            // end

            return answer;
        }
        public int Task4(int a, int h, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            // end

            return answer;
        }
        public int Task6(int h, int S, int L)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double a, int b, int c) Task7(double S, double I)
        {
            double a = 0;
            int b = 0;
            int c = 0;

            // code here

            // end

            return (a, b, c);
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}
