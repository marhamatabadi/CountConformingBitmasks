using System.Diagnostics;

namespace CountConformingBitmasks.Test
{
    public class MainTest
    {
        [Theory]
        [InlineData([1073741727, 1073741631, 1073741679, 8])]
        [InlineData([0, 0, 0, 1073741824])]
        [InlineData([0, 1073741824, 0, 1073741824])]
        [InlineData([1, 1073741824, 1, 1073741824])]
        [InlineData([1073741823, 1073741824, 1073741825, 1073741824])]
        public void Solution_AnswerTest(int a, int b, int c, int expected)
        {
            int actual = Main.Solution(a, b, c);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Solution_PerformanceTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Act

            for (int i = 0; i < 10000; i++) // Run function multiple times (adjust iterations)
            {
                int a = new Random().Next(int.MaxValue);
                int b = new Random().Next(int.MaxValue);
                int c = new Random().Next(int.MaxValue);
                Main.Solution(a,b,c);

            }
            stopwatch.Stop();

            double elapsedMilliseconds = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMilliseconds < 100, "elapsed Milliseconds Should be less then 100ms");
        }
    }
}