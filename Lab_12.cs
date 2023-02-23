namespace work_12
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int Firstside, Secondside, Firstside2, Secondside2;

            Console.WriteLine("Введіть значення 1 сторони Хреста");
            Firstside=int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення 2 сторони Хреста");
            Secondside = int.Parse(Console.ReadLine());
            Cross examp1 = new Cross(Firstside,Secondside);
            Console.WriteLine(examp1.ToString());

            Console.WriteLine("\t\t\tВводимо значенення для ДРУГОГО Хреста");

            Console.WriteLine("Введіть значення 1 сторони Хреста");
            Firstside2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть значення 2 сторони Хреста");
            Secondside2 = int.Parse(Console.ReadLine());
            Cross examp2 = new Cross(Firstside2, Secondside2);
            Console.WriteLine(examp2.ToString());

            Cross examp3 = examp1 + examp2;
            Console.WriteLine("Новий Хрест створений через додавання параметрів інших екзмемлярів має наступні параметри");
            Console.WriteLine(examp3.ToString());

        }
    }

    class Cross 
    {
        private double area;
        int obj1, obj2;
        public Cross() 
        {
            obj1 = 0;
            obj2 = 0;
        }
        public Cross(int obj1, int obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }
        public double Area()
        {
            return this.area =((obj1*obj2)*4)+obj1*obj1;
        }
        public override string ToString()
        {
            return $"Площа хреста зі сторонами {obj1} i {obj2} = {Area()}";
        }
        public static Cross operator +(Cross examp1, Cross examp2)
        {
            int obj1, obj2;
            return new Cross
            {
                obj1 = examp1.obj1+examp2.obj1,
                obj2 = examp1.obj2+examp2.obj2
            };
        }
    }
}
