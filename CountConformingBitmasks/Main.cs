
namespace CountConformingBitmasks
{
    public static class Main
    {
        public static int Solution(int A, int B, int C)
        {
            int total = 0;
            total = ZeroBitCounter(A)
                 + ZeroBitCounter(B)
                 + ZeroBitCounter(C)
                 - ZeroBitCounter(A | B)
                 - ZeroBitCounter(A | C)
                 - ZeroBitCounter(B | C)
                 + ZeroBitCounter(A | B | C);

            return total;
        }
        private static int ZeroBitCounter(int n)
        {
            int count = 0;
            int index = 30;
            int lastBit = 0;
            while (index > 0)
            {
                index--;
                lastBit = n & 1;
                if (lastBit == 0)
                    count++; //we are counting the Bit which is set 0
                n >>= 1;  // Right shift by 1

            }

            return (int)System.Math.Pow(2,count);
        }

    }
}
