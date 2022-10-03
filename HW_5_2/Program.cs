namespace HW_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] radiusMass = new int[10] { 0, 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            do
            {
                bool isWin = false;
                var x = random.Next(-50, 50);
                var y = random.Next(-50, 50);
                var a = Math.Sqrt(x * x + y * y);

                for (int i = 1; i < radiusMass.Length; i += 2)
                {
                    if (a <= radiusMass[i] && a > radiusMass[i - 1])
                    {
                        Console.WriteLine($"You win {10 - (i - 1)}");
                        isWin = true;
                    }
                }

                if (!isWin)
                {
                    Console.WriteLine("You lose");
                }
                Console.WriteLine("Exit? /n(Yes / No)");
            } while (Console.ReadLine().ToLower().Contains("n"));
        }

    }
}