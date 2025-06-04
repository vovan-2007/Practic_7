 namespace lab7t1
{
    internal class Program
    {
        static int[,] GenRandArray(int rows, int cols, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rnd.Next(minValue, maxValue + 1);
                }
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[,] array = GenRandArray(5, 5, 1, 100);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите на любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
