namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            double average = (a + b) / 2.0;
            // ygftyftyfty

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine("Разность: " + difference);
            Console.WriteLine("Произведение: " + product);
            Console.WriteLine("Среднее арифметическое: " + average);
        }
    }
}
