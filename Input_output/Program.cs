using System;
using System.Globalization;
using System.Runtime.CompilerServices;



namespace Input_output
{
    internal class Program
    {
        static void Function1()
        {
            string UserString;
            int UserNumber;


        // ВВОД ЧИСЛА
            Console.Write("Введите число в диапазоне от 1 до 100: ");
            UserString = Console.ReadLine();

            do
            {
                if (int.TryParse(UserString, out UserNumber)) // попытка преобразовать строку в число
                {
                    if (UserNumber >= 1 && UserNumber <= 100) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{UserNumber}\" не является числом или находится вне диапазона, введите число ещё раз: ");
                UserString = Console.ReadLine();
            }
            while (true);
        

        // РЕЗУЛЬТАТ
            if (UserNumber % 3 == 0 && UserNumber % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (UserNumber % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (UserNumber % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(UserNumber);
            }
        }
  



        static void Function2()
        {
            string UserStringForNum;
            string UserStringForPer;

            int UserNumberForNum;
            int UserNumberForPer;


        // ВВОД ЧИСЛА
            Console.Write("Введите число: ");
            UserStringForNum = Console.ReadLine();

            do
            {
                if (int.TryParse(UserStringForNum, out UserNumberForNum)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{UserNumberForNum}\" не является числом, введите число ещё раз: ");
                UserStringForNum = Console.ReadLine();
            }
            while (true);


        // ВВОД ПРОЦЕНТА
            Console.Write("Введите процент, который хотите найти от числа: ");
            UserStringForPer = Console.ReadLine();

            do
            {
                if (int.TryParse(UserStringForPer, out UserNumberForPer)) // попытка преобразовать строку в число
                {
                    if (UserNumberForPer >= 1 && UserNumberForPer <= 100) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{UserNumberForPer}\" не может быть процентом, введите процент ещё раз: ");
                UserStringForPer = Console.ReadLine();
            }
            while (true);


        // РЕЗУЛЬТАТ
            Console.WriteLine($"{UserNumberForPer}% от числа {UserNumberForNum} = {UserNumberForNum * UserNumberForPer / 100}");
        }




        static void Function3()
        {
            string userString;
            int userNumber = 0;

        // ВВОД ЧИСЕЛ
            for (int i = 0; i < 4; ++i) 
            {
                Console.Write($"Введите число {i + 1} в диапазоне от 1 до 9: ");
                userString = Console.ReadLine();

                do
                {
                    if (int.TryParse(userString, out int userNumberTemp)) // попытка преобразовать строку в число
                    {
                        if (userNumberTemp >= 1 && userNumberTemp < 10) // проверка на попадание числом в диапазон
                        {
                            break;
                        }
                    }

                    Console.Write($"ОШИБКА: \"{userString}\" не является числом или находится вне диапазона, введите число ещё раз: ");
                    userString = Console.ReadLine();
                } 
                while (true);

                userNumber += Convert.ToInt32(userString) * 1000 / (int) (Math.Pow(10, i));
                //Console.WriteLine($"Предрезультат: {userNumber}, корень {Math.Pow(10, i)}, единицы {Convert.ToInt32(userString) * 1000 / Math.Pow(10, i)}");
            }

        // РЕЗУЛЬТАТ
            Console.WriteLine($"Результат: {userNumber}");
        }




        static void Function4()
        {
            string userString;
            string userNumber;

            int firstIndex;
            int secondIndex;



        // ВВОД ЧИСЛА
            Console.WriteLine("Введите любое шестизначное число: ");
            userNumber = Console.ReadLine();

            do
            {
                if (int.TryParse(userNumber, out int userNumberTemp)) // попытка преобразовать строку в число
                {
                    if (userNumberTemp >= 100000 && userNumberTemp <= 999999) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{userNumber}\" не является числом или находится вне диапазона, введите число ещё раз: ");
                userNumber = Console.ReadLine();
            }
            while (true);


        // ВВОД ПЕРВОГО НОМЕРА
            Console.WriteLine("Введите первый номер числа, которое хотите поменять: ");
            userString = Console.ReadLine();

            do
            {
                if (int.TryParse(userString, out firstIndex)) // попытка преобразовать строку в число
                {
                    if (firstIndex >= 1 && firstIndex <= 6) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{userString}\" не является числом или находится вне диапазона, введите число ещё раз: ");
                userString = Console.ReadLine();
            }
            while (true);


        // ВВОД ВТОРОГО НОМЕРА
            Console.WriteLine("Введите второй номер числа, которое хотите поменять: ");
            userString = Console.ReadLine();

            do
            {
                if (int.TryParse(userString, out secondIndex)) // попытка преобразовать строку в число
                {
                    if (secondIndex >= 1 && secondIndex <= 6 && firstIndex != secondIndex) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{userString}\" не является числом или находится вне диапазона, введите число ещё раз: ");
                userString = Console.ReadLine();
            }
            while (true);



        // РЕЗУЛЬТАТ
            for (int i = 0; i < 6; ++i)
            {
                
            }

            //Console.WriteLine($"Число: {}");

        }




        static void Function5()
        {
            string daysStr;
            int daysInt;

            string monthsStr;
            int monthsInt;

            string yearsStr;
            int yearsInt;


        // ВВОД ДНЯ
            Console.WriteLine("ВВОД ДАТЫ");
            Console.Write("Введите число: ");
            daysStr = Console.ReadLine();

            do
            {
                if (int.TryParse(daysStr, out daysInt)) // попытка преобразовать строку в число
                {
                    if (daysInt >= 1 && daysInt <= 31) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{daysStr}\" не может быть днём или находится вне диапазона, введите число ещё раз: ");
                daysStr = Console.ReadLine();
            }
            while (true);


        // ВВОД МЕСЯЦА
            Console.Write("Введите номер месяца: ");
            monthsStr = Console.ReadLine();

            do
            {
                if (int.TryParse(monthsStr, out monthsInt)) // попытка преобразовать строку в число
                {
                    if (monthsInt >= 1 && monthsInt <= 12) // проверка на попадание числом в диапазон
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{monthsStr}\" не может быть месяцем или находится вне диапазона, введите число ещё раз: ");
                monthsStr = Console.ReadLine();
            }
            while (true);


        // ВВОД ГОДА
            Console.Write("Введите год: ");
            yearsStr = Console.ReadLine();

            do
            {
                if (int.TryParse(yearsStr, out yearsInt)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{yearsStr}\" не может быть годом, введите число ещё раз: ");
                yearsStr = Console.ReadLine();
            }
            while (true);


        // РЕЗУЛЬТАТ
            int day_of_week = (7000 + (daysInt + (yearsInt - (14 - monthsInt) / 12) + (yearsInt - (14 - monthsInt) / 12) / 4 - (yearsInt - (14 - monthsInt) / 12) / 100 + (yearsInt - (14 - monthsInt) / 12) / 400 + (31 * (monthsInt + 12 * ((14 - monthsInt) / 12) - 2)) / 12)) % 7;

            switch (day_of_week)
            {
                case 1: Console.WriteLine("День недели: понедельник"); break;
                case 2: Console.WriteLine("День недели: вторник"); break;
                case 3: Console.WriteLine("День недели: среда"); break;
                case 4: Console.WriteLine("День недели: четверг"); break;
                case 5: Console.WriteLine("День недели: пятница"); break;
                case 6: Console.WriteLine("День недели: суббота"); break;
                case 7: Console.WriteLine("День недели: воскресенье"); break;
            }
        }




        static void Function6()
        {
            string tempStr;
            int tempInt;

            string choice;


        // ВВОД ТЕМПЕРАТУРЫ
            Console.Write("Введите температуру: ");
            tempStr = Console.ReadLine();

            do
            {
                if (int.TryParse(tempStr, out tempInt)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{tempStr}\" не может быть температурой, введите число ещё раз: ");
                tempStr = Console.ReadLine();
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
                Console.Write($"\nТемпература по Фаренгейту: {tempInt * 1.8 + 32}");
            }
            else if (choice == "2") 
            {
                Console.Write($"\nТемпература по Цельсию: {(tempInt - 32) / 1.8}");
            }
        }




        static void Function7()
        {
            string firstUserStr;
            int firstUserInt;

            string secondUserStr;
            int secondUserInt;


        // ВВОД ПЕРВОГО ЧИСЛА
            Console.Write("Введите первое число диапазона: ");
            firstUserStr = Console.ReadLine();

            do
            {
                if (int.TryParse(firstUserStr, out firstUserInt)) // попытка преобразовать строку в число
                {
                    break;
                }

                Console.Write($"ОШИБКА: \"{firstUserStr}\" не является числом, введите число ещё раз: ");
                firstUserStr = Console.ReadLine();
            }
            while (true);


        // ВВОД ВТОРОГО ЧИСЛА
            Console.Write("Введите второе число диапазона: ");
            secondUserStr = Console.ReadLine();

            do
            {
                if (int.TryParse(secondUserStr, out secondUserInt)) // попытка преобразовать строку в число
                {
                    if (firstUserInt != secondUserInt)
                    {
                        break;
                    }
                }

                Console.Write($"ОШИБКА: \"{secondUserStr}\" не является числом или равно первому числу, введите число ещё раз: ");
                secondUserStr = Console.ReadLine();
            }
            while (true);


        // РЕЗУЛЬТАТ
            if (firstUserInt > secondUserInt)
            {
                (firstUserInt, secondUserInt) = (secondUserInt, firstUserInt);
            }

            Console.WriteLine($"\nЧётные числа в диапазоне от {firstUserInt} до {secondUserInt}: ");
            for (int i = firstUserInt + 1; i < secondUserInt; ++i)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }





        static void Main()
        {
            //Function1(); Console.WriteLine("\n");

            //Function2(); Console.WriteLine("\n");

            //Function3(); Console.WriteLine("\n");

            //Function4(); Console.WriteLine("\n"); // не доделал

            //Function5(); Console.WriteLine("\n");

            //Function6(); Console.WriteLine("\n");

            //Function7(); Console.WriteLine("\n");
        }
    }
}

/*
 * 1. Доделать 4 функцию
 * 2. Сделать нормальные имена
 * 3. Перенести проверку в отдельную функцию
 * 4. Решить, преобразовывать ли string в int
 */