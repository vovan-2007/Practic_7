namespace lab7t14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 5];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
            int minRow = 0, minColumn = 0;
            int minAbsolut = Math.Abs(matrix[0, 0]);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int currentAbs = Math.Abs(matrix[i, j]);
                    if (currentAbs < minAbsolut)
                    {
                        minAbsolut = currentAbs;
                        minRow = i;
                        minColumn = j;
                    }
                }
            }
            Console.WriteLine($"Наименьший по модулю элемент: {matrix[minRow, minColumn]} в строке {minRow}, столбце {minColumn}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
