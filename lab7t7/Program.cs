namespace lab7t7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            bool found = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] < 0 && matrix[i, j] % 2 != 0)
                    {
                        found = true;
                        Console.WriteLine($"Найден нечётный отрицательный элемент: {matrix[i, j]}");
                        break;
                    }
                }
                if (found) break;
            }
            if (!found)
            {
                Console.WriteLine("Нечётный отрицательный элемент не найден.");
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
