namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine($"{i} * {i} = {Logic.Power(i)}");
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}