namespace Work_2_1
{
    internal class Program
    {

        static int[] ValueOfArray(int sizeOfArray)
        {
            Random random = new();
            int[] array = new int[sizeOfArray];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 20);
            }

            return array;
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int sum2NumfromArray = 0;
            Console.WriteLine("Введіть розмір масиву");
            if (int.TryParse(Console.ReadLine(), out int sizeOfArray))
            {
                Console.Write("Ваш масив [ ");
                int[] array = new int[sizeOfArray];
                array = ValueOfArray(sizeOfArray);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.Write("]");
                Array.Sort(array);
                Console.WriteLine();
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                sum2NumfromArray = array[array.Length-1]+array[array.Length-2]; 
                Console.WriteLine("Сума двох найбільших елементів масиву - " + sum2NumfromArray);
            }
            else
            {
                Console.WriteLine("Розмір масиву введено не коректно");
            }
        }
    }
}
