namespace work_13
{


    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int size = 5;
            double totalweight=0;
            Sweet[] gift=new Sweet[size];
            gift[0] = new Candy("Гулівер",0.1,17);
            gift[1] = new ChocolateBar("Milka",0.9,3);
            gift[2] = new Cookie("Артемон",0.04,30);
            gift[3] = new Candy("Шоколапкі",0.02,5);
            gift[4] = new ChocolateBar("Lacmy",0.9,3);
            for (int i = 0; i < gift.Length; i++)
            {
                Console.WriteLine(gift[i].InfoAboutSweets());
            }
            for (int i = 0; i<gift.Length;i++)
            {
                totalweight += gift[i].Weight * gift[i].Kilkist;
            }
            Console.WriteLine("Загальна вага подарунку = "+totalweight+" кг");
        }

    }
    abstract class Sweet
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Kilkist { get; set; }
        public Sweet() { }
        public Sweet(string name, double weight, int kilkist)
        {
            Name = name;
            Weight = weight;
            Kilkist = kilkist;
        }
        public abstract string Type { get; }
        public abstract string InfoAboutSweets();
        public double TotalWeight(double weight, double kilkist)
        {
            return weight * kilkist;
        }

    }
    class Candy : Sweet
    {
        public override string Type => "цукерка";
        public Candy() { }
        public Candy(string name, double weight, int kilkist)
        {
            Name= name;
            Weight = weight;
            Kilkist = kilkist;
        }
        public override bool Equals(object obj)
        {
            return obj is Candy @class && Name == @class.Name && Weight == @class.Weight && Kilkist == @class.Kilkist;
        }
        public double TotalWeight(double weight, double kilkist)
        {
            return weight * kilkist;
        }
        public override string InfoAboutSweets()
        {
            return "Тип солодощів: " + Type + ". Назва: " + Name + ". Кількість: " + Kilkist + ". Вага: " + Weight;
        }
    }

    class Cookie : Sweet
    {
        public override string Type => "печиво";
        public Cookie() { }

        public Cookie(string name, double weight, int kilkist)
        {
            Name = name;
            Weight = weight;
            Kilkist = kilkist;
        }

        public override bool Equals(object obj)
        {
            return obj is Cookie @class && Name == @class.Name && Weight == @class.Weight && Kilkist == @class.Kilkist;
        }
        public double TotalWeight(double weight, double kilkist)
        {
            return weight * kilkist;
        }
        public override string InfoAboutSweets()
        {
            return "Тип солодощів: " + Type + ". Назва: " + Name + ". Кількість: " + Kilkist + ". Вага: " + Weight;
        }


    }


    class ChocolateBar : Sweet
    {
        public override string Type => "Шоколадка";
        public ChocolateBar() { }
        public ChocolateBar(string name, double weight, int kilkist)
        {
            Name = name;
            Weight = weight;
            Kilkist = kilkist;
        }
        public override bool Equals(object obj)
        {
            return obj is ChocolateBar @class && Name == @class.Name && Weight == @class.Weight && Kilkist == @class.Kilkist;
        }
        public double TotalWeight(double weight, double kilkist)
        {
            return weight * kilkist;
        }
        public override string InfoAboutSweets()
        {
            return "Тип солодощів: " + Type + ". Назва: " + Name + ". Кількість: " + Kilkist + ". Вага: " + Weight;
        }

    }


}
