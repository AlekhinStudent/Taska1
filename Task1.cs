using System;

Console.WriteLine("Введите день и месяц вашего рождения в формате ДД.ММ: ");
string b = Console.ReadLine();
if (b.Length != 5 || b[2] != '.')
{
    Console.WriteLine("Ошибка, переделывай");
}
else
{
    string[] date = b.Split('.');
    int day, month;
    if (!int.TryParse(date[0], out day) || !int.TryParse(date[1], out month))
    {
        Console.WriteLine("Неверный формат даты");
    }
    else if (day < 1 || day > 31)
    {
        Console.WriteLine("Неверные значения");
        return;
    }
    else if (month < 01 || month > 12)
    {
        Console.WriteLine("Неверные значение");
        return;
    }
    else
    {
        switch (month)
        {
            case 1:
                Console.WriteLine(day <= 20 ? "Козерог" : "Водолей");
                break;
            case 2:
                if (day > 29) Console.WriteLine("Неверный день в феврале");
                else Console.WriteLine(day <= 19 ? "Водолей" : "Рыбы");
                break;
            case 3:
                Console.WriteLine(day <= 20 ? "Рыбы" : "Овен");
                break;
            case 4:
                if (day > 30) Console.WriteLine("Неверный день в апреле");
                else Console.WriteLine(day <= 20 ? "Овен" : "Телец");
                break;
            case 5:
                Console.WriteLine(day <= 21 ? "Телец" : "Близнецы");
                break;
            case 6:
                if (day > 30) Console.WriteLine("Неверный день в июне");
                else Console.WriteLine(day <= 21 ? "Близнецы" : "Рак");
                break;
            case 7:
                Console.WriteLine(day <= 22 ? "Рак" : "Лев");
                break;
            case 8:
                Console.WriteLine(day <= 23 ? "Лев" : "Дева");
                break;
            case 9:
                if (day > 30) Console.WriteLine("Неверный день в сентябре");
                else Console.WriteLine(day <= 23 ? "Дева" : "Весы");
                break;
            case 10:
                Console.WriteLine(day <= 23 ? "Весы" : "Скорпион");
                break;
            case 11:
                if (day > 30) Console.WriteLine("Неверный день в ноябре");
                else Console.WriteLine(day <= 22 ? "Скорпион" : "Стрелец");
                break;
            case 12:
                Console.WriteLine(day <= 21 ? "Стрелец" : "Козерог");
                break;
            default:
                Console.WriteLine("Неверный месяц");
                break;
        }
    }
    Console.WriteLine("Введите год вашего рождения (четырехзначное число):");
    int year;
    if (!int.TryParse(Console.ReadLine(), out year) || year < 1900)
    {
        Console.WriteLine("Неверный формат года");
    }
    else
    {
        string[] animals = { "Крыса", "Бык", "Тигр", "Кролик", "Дракон", "Змея", "Лошадь", "Коза", "Обезьяна", "Петух", "Собака", "Свинья" };
        string[] elements = { "Металл", "Вода", "Дерево", "Огонь", "Земля" };
        int animalIndex = (year - 1900) % 12;
        int elementIndex = (year - 1900) % 10 % 5;

        Console.WriteLine("Ваше животное по китайскому календарю:");
        Console.WriteLine(animals[animalIndex]);

        Console.WriteLine("Ваша стихия:");
        Console.WriteLine(elements[elementIndex]);
    }
}