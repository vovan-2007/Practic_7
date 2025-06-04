namespace lab7t13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 5];
            Random rnd = new Random();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(20, 41);
                }
            }
            int resultRow = -1;
            for (int i = 0; i < 8; i++)
            {
                int chetCount = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        chetCount++;
                    }
                }
                if (chetCount <= 3)
                {
                    resultRow = i + 1;
                    break;
                }
            }
            Console.WriteLine($"Номер строки с не более 3 чётными числами: {resultRow}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
