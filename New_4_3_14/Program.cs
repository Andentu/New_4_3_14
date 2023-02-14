namespace New_4_3_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[2] { 1, 2 };
            array[1] = new int[3] { 1, 2, 3 };
            array[2] = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Вывод массива на экран по символам в одну строку: ");
            // Для того, чтобы сделать вывод многомерного массива, необходимо сделать вложенный цикл foreach
            foreach (var ch in array)
            {
                foreach (var num in ch)
                {
                    Console.Write(num + " ");
                }
            }

        }
    }
}