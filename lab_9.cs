namespace Work_1
{
     internal class Program
    {
        static double Calculation(double x, double y, double z)
        {
            double fpart, spart, a;
             fpart = x + (Math.Pow(z,2))+ (y/4) ;
             spart = z * (y-2) + (1/(4+(Math.Pow(z,2)))) ;
            a = fpart / spart;
            return a;
        }
        static void RangeForX(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Х негативне x");
            }
            else
            {
                Console.WriteLine("Х позитивне");
            }
            if (x < -10)
            {
                Console.WriteLine("Х менше за -10");
            }
            else if (x < -1)
            {
                Console.WriteLine("Х менше за -1");
            }
            else if (x < 10)
            {
                Console.WriteLine("Х бiльше за 1");
            }
            else
            {
                Console.WriteLine("Х бiльше за 10");
            }
        }

        static void Main()
        {
            double x, y, z, result;


            Console.WriteLine("Якщо ви бажаєте закінчити програму, введіть х = 0");
            do
            {
                Console.WriteLine("Введіть значення Х, У та Z");
                x = double.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                y = double.Parse(Console.ReadLine());
                z = double.Parse(Console.ReadLine());
                result = Calculation(x, y, z);
                RangeForX(x);
                Console.WriteLine("Результат розрахунку прикладу - " + result);


                
            } while (x != 0);
            Console.WriteLine("Виконання програми завершено");
            
        }
    }
}
