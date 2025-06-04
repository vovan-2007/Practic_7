namespace lab7t9
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
                    matrix[i, j] = rnd.Next(1, 10);
                }
            }
            int minIndex = 0, maxIndex = 0;
            for (int i = 1; i < 4; i++)
            {
                if (matrix[i, i] < matrix[minIndex, minIndex])
                {
                    minIndex = i;
                }
                if (matrix[i, i] > matrix[maxIndex, maxIndex])
                {
                    maxIndex = i;
                }
            }
            int temp = matrix[minIndex, minIndex];
            matrix[minIndex, minIndex] = matrix[maxIndex, maxIndex];
            matrix[maxIndex, maxIndex] = temp;

            Console.WriteLine("Матрица после обмена:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
