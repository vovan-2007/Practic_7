namespace lab7t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[15, 9];
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                }
            }
            for (int i = 0; i < 15; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < 9; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                Console.WriteLine($"Минимальный элемент строки {i}: {min}");
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
