using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;




namespace Homework
{
    internal class Program
    {
        static void Function1()
        {
            string str;
            int number;


        // ВВОД ЧИСЛА
            Console.Write("Введите число в диапазоне от 1 до 100: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out number)) // попытка преобразовать строку в число
                {
                    if (number >= 1 && number <= 100) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не является числом или находится вне диапазона, введите число (от 0 до 100) ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);
        

        // РЕЗУЛЬТАТ
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
  



        static void Function2()
        {
            string str;

            int number;
            int percent;


        // ВВОД ЧИСЛА
            Console.Write("Введите число: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out number)) // попытка преобразовать строку в число
                {
                    if (number != 0) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не является числом или равно нулю, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // ВВОД ПРОЦЕНТА
            Console.Write("Введите процент, который хотите найти от числа: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out percent)) // попытка преобразовать строку в число
                {
                    if (percent >= 1 && percent <= 100) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не может быть процентом, введите процент ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // РЕЗУЛЬТАТ
            Console.WriteLine($"{percent}% от числа {number} = {number * percent / 100}");
        }




        static void Function3()
        {
            string str;
            int number = 0;
            int result = 0;

        // ВВОД ЧИСЕЛ
            for (int i = 0; i < 4; ++i) 
            {
                Console.Write($"Введите число {i + 1} в диапазоне от 1 до 9: ");
                str = Console.ReadLine();

                do
                {
                    if (int.TryParse(str, out number)) // попытка преобразовать строку в число
                    {
                        if (number >= 1 && number < 10) // проверка на попадание числом в диапазон
                        {
                            break;
                        }
                    }

                    Console.Write($"ОШИБКА: \"{str}\" не является числом или находится вне диапазона, введите число ещё раз: ");
                    str = Console.ReadLine();
                } 
                while (true);

                result += number * 1000 / (int) (Math.Pow(10, i));
                //Console.WriteLine($"Предрезультат: {userNumber}, корень {Math.Pow(10, i)}, единицы {Convert.ToInt32(userString) * 1000 / Math.Pow(10, i)}");
            }

        // РЕЗУЛЬТАТ
            Console.WriteLine($"Результат: {result}");
        }




        static void Function4()
        {
            string number;

            string str;
            int firstIndex;
            int secondIndex;



        // ВВОД ЧИСЛА
            Console.Write("Введите любое шестизначное число: ");
            number = Console.ReadLine();

            do
            {
                if (int.TryParse(number, out int numberTemp)) // попытка преобразовать строку в число
                {
                    if (numberTemp >= 100000 && numberTemp <= 999999) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{number}\" не является числом или не является шестизначным, введите число ещё раз: ");
                number = Console.ReadLine();
            }
            while (true);


        // ВВОД ПЕРВОГО НОМЕРА
            Console.Write("Введите номер первого числа (от 1 до 5): ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out firstIndex)) // попытка преобразовать строку в число
                {
                    if (firstIndex >= 1 && firstIndex <= 5) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не является числом или находится вне диапазона, введите число (от 1 до 5) ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // ВВОД ВТОРОГО НОМЕРА
            Console.Write($"Введите номер второго числа (от {firstIndex} до 6): ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out secondIndex)) // попытка преобразовать строку в число
                {
                    if (secondIndex >= 1 && secondIndex <= 6 && firstIndex < secondIndex) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не является числом или находится вне диапазона, введите число (от {firstIndex} до 6) ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);



        // РЕЗУЛЬТАТ
            --firstIndex; --secondIndex;

            StringBuilder result = new StringBuilder();
            result.Length = number.Length;

            char buf = number[firstIndex];
            for (int i = 0; i < 6; ++i)
            {
                if (i == firstIndex)
                {
                    result.Append(number[secondIndex]);
                }
                else if (i == secondIndex)
                {
                    result.Append(buf);
                }
                else
                {
                    result.Append(number[i]);
                }
            }

            Console.WriteLine($"Исходное число: {number}");
            Console.WriteLine($"Изменённое число: {result}");
        }




        static void Function5()
        {
            string str;

            int days;
            int months;
            int years;


        // ВВОД ДНЯ
            Console.Write("Введите день: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out days)) // попытка преобразовать строку в число
                {
                    if (days >= 1 && days <= 31) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не может быть днём, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // ВВОД МЕСЯЦА
            Console.Write("Введите номер месяца: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out months)) // попытка преобразовать строку в число
                {
                    if (months >= 1 && months <= 12) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не может быть месяцем, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // ВВОД ГОДА
            Console.Write("Введите год: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out years)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{str}\" не может быть годом, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // РЕЗУЛЬТАТ
            int dayOfWeek = (7000 + (days + (years - (14 - months) / 12) + (years - (14 - months) / 12) / 4 - (years - (14 - months) / 12) / 100 + (years - (14 - months) / 12) / 400 + (31 * (months + 12 * ((14 - months) / 12) - 2)) / 12)) % 7;
            // формула не моя, я нашёл её в интернете

            Console.Write($"День недели {days}.{months}.{years}: ");
            switch (dayOfWeek)
            {
                case 1: Console.Write("понедельник"); break;
                case 2: Console.Write("вторник"); break;
                case 3: Console.Write("среда"); break;
                case 4: Console.Write("четверг"); break;
                case 5: Console.Write("пятница"); break;
                case 6: Console.Write("суббота"); break;
                case 7: Console.Write("воскресенье"); break;
            }
        }




        static void Function6()
        {
            string str;
            int temperature;

            string choice;


        // ВВОД ТЕМПЕРАТУРЫ
            Console.Write("Введите температуру: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out temperature)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{str}\" не может быть температурой, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // МЕНЮ ВЫБОРА ШКАЛЫ ДЛЯ ПЕРЕВОДА
            Console.WriteLine("\nВыберите, в какую единицу измерения хотите перевести: ");
            Console.WriteLine("1 - по шкале Фаренгейта");
            Console.WriteLine("2 - по шкале Цельсия");
            Console.Write("Ваш выбор: ");

            choice = Console.ReadLine();

            do
            {
                if (int.TryParse(choice, out int choiceTemp)) // попытка преобразовать строку в число
                {
                    if (choiceTemp >= 1 && choiceTemp <= 2) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{choice}\" не является пунктом меню, введите число ещё раз: ");
                choice = Console.ReadLine();
            }
            while (true);

         
        // РЕЗУЛЬТАТ
            if (choice == "1") 
            {
                Console.Write($"\nТемпература по Фаренгейту: {Math.Round(temperature * 1.8 + 32, 2)}");
            }
            else if (choice == "2") 
            {
                Console.Write($"\nТемпература по Цельсию: {Math.Round((temperature - 32) / 1.8, 2)}");
            }
        }




        static void Function7()
        {
            string str;

            int firstNumber;
            int secondNumber;


        // ВВОД ПЕРВОГО ЧИСЛА
            Console.Write("Введите первое число диапазона: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out firstNumber)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{str}\" не является числом, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // ВВОД ВТОРОГО ЧИСЛА
            Console.Write("Введите второе число диапазона: ");
            str = Console.ReadLine();

            do
            {
                if (int.TryParse(str, out secondNumber)) // попытка преобразовать строку в число
                {
                    if (firstNumber != secondNumber)
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{str}\" не является числом или равно первому числу, введите число ещё раз: ");
                str = Console.ReadLine();
            }
            while (true);


        // РЕЗУЛЬТАТ
            if (firstNumber > secondNumber)
            {
                (firstNumber, secondNumber) = (secondNumber, firstNumber);
            }

            Console.WriteLine($"\nЧётные числа в диапазоне от {firstNumber} до {secondNumber}: ");
            for (int i = firstNumber + 1; i < secondNumber; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }





        static void Main()
        {
            Function1(); Console.WriteLine("\n");
            //Function2(); Console.WriteLine("\n");
            //Function3(); Console.WriteLine("\n");
            //Function4(); Console.WriteLine("\n");
            //Function5(); Console.WriteLine("\n");
            //Function6(); Console.WriteLine("\n");
            //Function7(); Console.WriteLine("\n");
        }
    }
}