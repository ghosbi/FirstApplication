namespace FirstApplication.ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
             Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Greet(name, age);
            Console.WriteLine("Из какого вы города?");
            string city = Console.ReadLine();
            Console.WriteLine("Город {0}", city + " очень красивый!");
            Console.WriteLine("Рад с вами познакомиться!");
        }
        
        static void Greet(string name, string age)
        {
            Console.WriteLine("Здравствуйте, {0}", name);
            Console.WriteLine("Ого вам {0}", age + " лет!");
        }
    }
}