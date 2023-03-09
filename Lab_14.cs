namespace work_14
{
        interface ISphere
        {
            double radius { get; set; }

            void SetWeight(double radius);
            double GetWeight();
            void print_val();
        }

        class Sphere : ISphere
        {
            public double radius { get; set; }

            public Sphere(double radius)
            {
                this.radius = radius;
            }

            public void SetWeight(double weidht)
            {
                radius = (weidht/3.14)*(3/4);
            }
            public double GetWeight()
            {
                return 4.0 * 3.14 * radius * radius * radius ;
            }

            public void print_val()
            {
                Console.WriteLine($"Sphere: {GetWeight()}");
            }

            public override string ToString()
            {
                return $"Radius: {radius}\tWeight: {GetWeight()}\n";
            }
        }

        internal class Program
        {
            static void Main()
            {
                const int SIZE = 10;

                Sphere[] spheres = new Sphere[SIZE];
                int[] keys = new int[SIZE];

                Random rand = new Random();

                for (int i = 0; i < SIZE; i++)
                {
                    int radius = rand.Next(20);

                    spheres[i] = new Sphere(radius);
                    keys[i] = radius;
                }
                foreach (Sphere i in spheres)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("-----------Sort-----------\n");
                Array.Sort(keys, spheres);

                foreach (Sphere i in spheres)
                {
                    Console.WriteLine(i);
                }
            }
        }
}
