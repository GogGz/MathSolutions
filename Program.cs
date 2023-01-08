namespace MathSolutions;
class Program
{
    static void Main(string[] args)
    {
        { //Tsragravorman Khndirnero Zhoghovatsu

            int x = 2;
            int y = 3;
            double z;

            //1. Gtsayin algorithm

            Console.Write("N1: ");
            Console.WriteLine((y + 1) * (x + Math.Pow((Math.Pow(x, 2) + 1), 6) * Math.Sin(Math.Pow(x, 2) - 3) - Math.Tan(3)));

            Console.Write("N3: ");
            Console.WriteLine(1 / Math.Tan(Math.Abs(Math.Pow(x, 2) - y) / (Math.Pow(x, 2) + Math.Pow(y, 2))) + Math.Log(Math.Pow(x, 2) + 1));

            Console.Write("N5: ");
            Console.WriteLine((Math.Pow(2, x) - 5) / (Math.Pow(3, y) + 2) + Math.Log2(Math.Pow((Math.Abs(x) + 1), 4) + Math.Pow(y, 2)));

            Console.Write("N7: ");
            Console.WriteLine(Math.Pow((Math.Pow((Math.Pow(x, 2) + Math.Pow(y, 2)), 5) + 4), 7) + Math.Sin(Math.Cos(x + y)));

            Console.Write("N9: ");
            z = Math.Pow(((x + 4) / Math.Pow((Math.Pow(y, 2) + 4), 3)), 1 / 5);
            Console.WriteLine(Math.Sin(Math.Pow((x + z), 2)) + 3 * z + (y / Math.Pow(x, 2)));
        }



        {    //2. Jyughavorvats algorithm

            Console.Write("Print a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Print b: ");
            int b = int.Parse(Console.ReadLine());

            double c = Math.Pow(a,2) + Math.Pow(b, 2);

            Console.Write("N11: ");





        }



        Console.ReadKey();

    }
}

