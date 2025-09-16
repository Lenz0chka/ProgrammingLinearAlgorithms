namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Введите число для перевода из двоичной системы в десятичную");
            string BinToDec = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(BinToDec, 2));

            // Задание 2
            Console.WriteLine("Введите число для перевода из десятичной системы в двоичную");
            int DecToBin = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(DecToBin, 2));

            //Задание 3
            Console.WriteLine("Введите во сколько N часов была заказана доставка");
            int N = int.Parse(Console.ReadLine()); // Часы
            Console.WriteLine("Введите во сколько M минут была заказана доставка");
            int M = int.Parse(Console.ReadLine()); // Минуты
            Console.WriteLine("Введите через сколько T минут будет осуществлена доставка");
            int T = int.Parse(Console.ReadLine()); // Продукты привезут через столько-то минут
            Console.WriteLine($"На электронных часах будет {Convert.ToDateTime($"{N}:{M}").AddMinutes(T).ToShortTimeString().ToString()}, когда привезут долгожданные продукты");
        }
    }
}
