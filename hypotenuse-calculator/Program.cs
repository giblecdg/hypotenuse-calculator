namespace hypotenuse_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"c = {c}");
        }
    }
}
