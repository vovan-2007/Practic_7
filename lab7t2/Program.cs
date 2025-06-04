namespace lab7t2
{
    internal class Program
    {
        static void Print(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] odnomerArray = { 1, 2, 3, 4, 5 };
            int[,] dvumerArray = { { 1, 2 }, { 3, 4 } };
            Print(odnomerArray);
            Print(dvumerArray);
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
