using System;

namespace lab3
{
    class Program: overloading
    {
        static void Main()
        {

            byte task;
            string newname;

            Console.Write("Введите номер задания(1-5): ");
            while (!byte.TryParse(Console.ReadLine(), out task))
                Console.Write("Введите номер задания(1-5): ");
            Console.WriteLine("------------------------------------------------");
            switch (task)
            {
                case 1:
                case 2:
                    Cow cow = new Cow("Бурёнка");
                    cow.GetName();
                    Whale whale = new Whale("Степан");
                    whale.GetName();
                    break;
                case 3:
                    Kitty kit = new Kitty();
                    GetanimalType(kit);
                    Doggy doggy = new Doggy();
                    GetanimalType(doggy);
                    Bird bird = new Bird();
                    GetanimalType(bird);
                    Lamb lamp = new Lamb();
                    GetanimalType(lamp);

                    break;
                case 4:
                    Cat cat = new Cat("Барсик");
                    cat.info();
                    cat.Voice();
                    Console.Write("Введите имя котенка:");
                    newname = Console.ReadLine();
                    Cat minicat = cat.GetChild(newname);
                    Console.WriteLine($"Родился {minicat.name}");
                    minicat.info();
                    minicat.Voice();

                    Dog dog = new Dog("Бобик");
                    dog.info();
                    dog.Voice();
                    Console.Write("Введите имя собачки:");
                    newname = Console.ReadLine();
                    Dog minidog = dog.GetChild(newname);
                    Console.WriteLine($"Родился {minidog.name}");
                    minidog.info();
                    minidog.Voice();
                    break;
                case 5:                    
                    Print(5);
                    Print("Пять");
                    Console.WriteLine("Меньшие числа:");
                    Console.WriteLine(min(5,6));
                    Console.WriteLine(min(5.4, 5.1));
                    Console.WriteLine(min(5000000000000000002, 5000000000000000001));
                    Console.WriteLine("Большие числа:");
                    Console.WriteLine(max(5, 6));
                    Console.WriteLine(max(5.4, 5.1));
                    Console.WriteLine(max(5000000000000000002, 5000000000000000001));

                    break;
            }
            Console.WriteLine("------------------------------------------------");
            Main();
        }
        public static void GetanimalType(Object x)
        {

            string ans="Оптимус Прайм";
            switch (x.GetType().Name)
            {
                case "Kitty":
                    ans = "Котик";
                    break;
                case "Doggy":
                    ans = "Собакен";
                    break;
                case "Bird":
                    ans = "Пчичка";
                    break;
                case "Lamb":
                    ans = "Лам(п)а";
                    break;
            }
            Console.WriteLine($"Я - {ans}");


        }
    }
}
