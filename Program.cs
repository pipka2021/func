using System;


namespace _16032021
{
    public struct User
    {
        public string name;
        public int age;
        public string sex;
        public string fav_color;
    };
    class Program
    {
        static void ck_uvlechenie( string text)
        {
            Console.Write("Ответ:");
            string data = Console.ReadLine();
            switch (data)
            {
                case "Д":
                case "Да":
                case "yes":
                case "Yes":
                case "y":
                case "да":
                case "д":
                    Console.WriteLine(text);
                    return;
                default:
                    return;
            }
        }
        static void Main(string[] args)
        {
            User user;

            Console.WriteLine("Ку.");
            Console.WriteLine("Кaк тебя зовуt?");
            Console.Write("Name:");
            user.name = Console.ReadLine();
            Console.WriteLine($"Привет, {user.name}\n");

            Console.WriteLine("Сколько тебе годиков?");
            Console.Write("Age:");
            Int32.TryParse(Console.ReadLine(), out user.age); //безопасное конвертирование в int
            Console.WriteLine($"Фига кабан, целых {user.age}\n");

            Console.WriteLine("Ты какого пола, М? (М - мужской, Ж - женский)");

            bool cur_sex = false;

            while (!cur_sex)
            {
                Console.Write("Пол:");
                string sex = Console.ReadLine();
                switch (sex)
                {
                    case "M": //eng UP
                    case "m": //eng
                    case "м": //rus
                    case "М": //rus UP
                        Console.WriteLine($"\n{user.name}, тебе нравится голубой цвет?");
                        Console.Write("Ответ:");
                        user.fav_color = Console.ReadLine();
                        cur_sex = true;
                        break;
                    case "F": //eng UP
                    case "f": //eng
                    case "Ж": //rus UP
                    case "ж": //rus
                        Console.WriteLine($"\n{user.name}, тебе нравится розовый цвет?");
                        Console.Write("Ответ:");
                        user.fav_color = Console.ReadLine();
                        cur_sex = true;
                        break;
                    default:
                        Console.WriteLine("Введите корректный пол!");
                        break;
                }
            }
            
            Console.Write("\n(Чтобы ответить да, можно использовать: Да, д, Yes, y.)");
            Console.Write("\n(Чтобы ответить нет, можно использовать: No, n, Нет, н.)");
            //1
            Console.WriteLine("\nТебе нравится играть в футбол?");
            ck_uvlechenie("Отлично!");
            //2
            Console.WriteLine("\nТебе нравится программировать?");
            ck_uvlechenie("Классно!");
            //3
            Console.WriteLine("\nТебе нравится читать?");
            ck_uvlechenie("Невероятно!");
            //4
            Console.WriteLine("\nТебе нравится петь?");
            ck_uvlechenie("Чудесно!");
            //5
            Console.WriteLine("\nТебе нравится танцевать?");
            ck_uvlechenie("Молодец!");
            //6
            Console.WriteLine("\nТебе нравится бегать?");
            ck_uvlechenie("Ого!");
            //7
            Console.WriteLine("\nТебе нравится пить пиво?");
            Console.Write("Ответ:");
            Console.ReadLine();
            Console.WriteLine("\nНам тоже нравится!");

            //пункт 5
            Console.WriteLine("\nТебе нравится твой код?");
            ck_uvlechenie("Ты молодец!");
        }
    }
}
