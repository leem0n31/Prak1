
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Выберите номер задания:");
            Console.WriteLine();
            Console.WriteLine("Часть 1");
            Console.WriteLine("1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");
            Console.WriteLine("2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:");
            Console.WriteLine("3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
            Console.WriteLine("4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
            Console.WriteLine("5. Разработайте программу для нахождения самого длинного слова в предложении");
            Console.WriteLine("6. Разработайте программу, которая может перемножить два массива значений");
            Console.WriteLine("7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
            Console.WriteLine("8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
            Console.WriteLine();
            Console.WriteLine("Часть 2");
            Console.WriteLine("9. Напечатать полную таблицу умножения:");
            Console.WriteLine();
            Console.WriteLine("Часть 3 Вариант 8");
            Console.WriteLine("10. Разработайте программу для нахождения самого длинного слова в предложении");
            string input = Console.ReadLine();
            if (input == "0")
                break;
            switch (input)
            {
                case "1":
                    task1();
                    break;
                case "2":
                    task2();
                    break;
                case "3":
                    task3();
                    break;
                case "4":
                    task4();
                    break;
                case "5":
                    task5();
                    break;
                case "6":
                    task6();
                    break;
                case "7":
                    task7();
                    break;
                case "8":
                    task8();
                    break;
                    case "9":
                    task9();
                    break;
                case "10":
                    task10();
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
        }
    }
    static void task1()
    {
        Console.Clear();
        Console.WriteLine("Задача 1. Разработайте программу, которая принимает четыре числа и находит среднее значение между ними");

        Console.WriteLine("Введите первое число:");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите третье число:");
        double num3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите четвертое число:");
        double num4 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine($"Среднее значение: {average}");

        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }
    static void task2()
    {
        Console.Clear();
        Console.WriteLine("2. Разработайте программу-калькулятор, в которой можно выбрать действие для двух вводимых пользователем чисел:");
        Console.WriteLine("Введите два числа:");
        Console.Write("Первое число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());
        Console.Write("Второе число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Вы ввели числа: {firstNumber} и {secondNumber}");
        Console.WriteLine("Какое действие выполнить?");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Нахождение остатка");

        Console.Write("Действие: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine($"Результат: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                break;
            case 2:
                Console.WriteLine($"Результат: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                break;
            case 3:
                Console.WriteLine($"Результат: {firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                break;
            case 4:
                if (secondNumber != 0)
                {
                    Console.WriteLine($"Результат: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
                break;
            case 5:
                if (secondNumber != 0)
                {
                    Console.WriteLine($"Результат: {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                }
                break;
            default:
                Console.WriteLine("Ошибка: Неверный выбор действия.");
                break;
        }
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }
    static void task3()
    {
        Console.Clear();
        Console.WriteLine("3. Разработайте программу для конвертации температуры между градусами Цельсия, Кельвина, Фаренгейта");
        Console.WriteLine("Выберите шкалу вводимой температуры:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");

        int inputScale = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите показатель температуры (градусы):");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите тип шкалы для конвертации:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");

        int outputScale = Convert.ToInt32(Console.ReadLine());

        double result = 0;

        if (inputScale == 1) 
        {
            if (outputScale == 2)
            {
                result = temperature + 273.15;
            }
            else if (outputScale == 3)
            {
                result = (temperature * 9 / 5) + 32;
            }
        }
        else if (inputScale == 2)
        {
            if (outputScale == 1)
            {
                result = temperature - 273.15;
            }
            else if (outputScale == 3)
            {
                result = (temperature - 273.15) * 9 / 5 + 32;
            }
        }
        else if (inputScale == 3)
        {
            if (outputScale == 1) 
            {
                result = (temperature - 32) * 5 / 9;
            }
            else if (outputScale == 2) 
            {
                result = (temperature - 32) * 5 / 9 + 273.15;
            }
        }

        Console.WriteLine($"Вы выбрали: Из {inputScale} в {outputScale}");
        Console.WriteLine($"Результат конвертации: {result}");
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }
    static void task4()
 {
     Console.Clear(); 
     Console.WriteLine("4. Разработайте программу, которая позволяет определить имя файла (с расширением) по введенному пути");
     Console.Write("Введите путь к файлу: ");
     string path = Console.ReadLine();
     if (File.Exists(path))
     {
         string fileName = Path.GetFileName(path); Console.WriteLine($"Имя файла: {fileName}");
     }
     else
     {
         throw new FileNotFoundException("Файл не найден.");
     }
     Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач");
     Console.ReadKey();
 }
    static void task5()
    {
        Console.Clear();
        Console.WriteLine("5. Разработайте программу для нахождения самого длинного слова в предложении");
        Console.WriteLine("Введите предложение:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = "";
        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }
        Console.WriteLine($"Самое длинное слово: {longestWord}");
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();

    }
    static void task6()
    {
        Console.Clear();
        Console.WriteLine("6. Разработайте программу, которая может перемножить два массива значений");
        Console.WriteLine("Введите значения для первого массива через пробел:");
        int[] array1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine("Введите значения для второго массива через пробел:");
        int[] array2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        if (array1.Length != array2.Length)
        {
            Console.WriteLine("Массивы должны быть одинаковой длины.");
            return;
        }
        int[] resultArray = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            resultArray[i] = array1[i] * array2[i];
        }
        Console.WriteLine("Результат: " + string.Join(" ", resultArray));
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }
    static void task7()
    {
        Console.Clear();
        Console.WriteLine("7. Разработайте программу, которая может найти максимальное и минимальное число из пяти введенных");
        Console.WriteLine("Введите пять чисел через пробел:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        if (numbers.Length != 5)
        {
            Console.WriteLine("Пожалуйста, введите ровно пять чисел.");
            return;
        }

        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
        }

        Console.WriteLine($"Максимальное число: {max}");
        Console.WriteLine($"Минимальное число: {min}");
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }
    static void task8()
    {
        Console.Clear();
        Console.WriteLine("8. Разработайте программу, которая выводит “пирамиду” из чисел из количества уровней, введенных пользователем");
        Console.WriteLine("Введите количество уровней пирамиды: ");
        int levels = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= levels; i++)
        {
            for (int j = levels; j > i; j--) Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
           Console.WriteLine();
        }
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();

    }
    static void task9()
    {
        Console.Clear();
        Console.WriteLine("9. Напечатать полную таблицу умножения:");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,4}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }
    static void task10()
    {
        Console.Clear();
        Console.WriteLine("10. Разработайте программу для нахождения самого длинного слова в предложении");
        string sentence = "Какое-то предложениеееее";
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Самое длинное слово: {longestWord}");
        Console.WriteLine("Задача завершена, нажмите на любую клавишу, чтобы вернуться к списку задач.");
        Console.ReadKey();
    }

}

