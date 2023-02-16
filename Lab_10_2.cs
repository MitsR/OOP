namespace Work_2_2
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
            int sumNegativeNumfromArray = 0;
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
                Console.Write("Відсортований масив [ ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.Write("]");
                Console.WriteLine();
                int maxNum = array[array.Length-1];
                for (int i = 0; i < array.Length; i++ )
                {
                    if (array[i] < 0)
                    {
                        sumNegativeNumfromArray += array[i];
                    }
                    else 
                    {
                        break;
                    }

                }
                Console.WriteLine($"Сума від'ємних елементів масиву = {sumNegativeNumfromArray} , а максимальне число - {maxNum}");
            }
            else
            {
                Console.WriteLine("Розмір масиву введено не коректно");
            }
        }
    }
}
