namespace lab7t6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 10];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = rnd.Next(-5, 5);
                }
            }
            Console.WriteLine("Номера строк с положительными элементами:");
            for (int i = 0; i < 5; i++)
            {
                bool vsePlus = true;
                for (int j = 0; j < 10; j++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        vsePlus = false;
                        break;
                    }
                }
                if (vsePlus)
                {
                    Console.Write($"{i + 1} ");
                }
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
