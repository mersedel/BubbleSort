namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;

            while (run)
            {
                Console.Clear();

                int[] array = ArrayGenerator.GenerateArray(10, 1, 10);

                Console.WriteLine("Before sorting: \n");

                ArrayWriter.WriteArray(array);


                BubbleSort.Sort(array);


                Console.WriteLine("\n\nAfter sorting: \n");

                ArrayWriter.WriteArray(array);


                Console.WriteLine("\n\nRestart?(y/n)");

                
                ConsoleKey key = Console.ReadKey().Key;

                
                if (key == ConsoleKey.N)
                {
                    run = false;
                }
            }
        }
    }
}
