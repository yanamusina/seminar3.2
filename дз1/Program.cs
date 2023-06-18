bool fulfillingCondition = false;
            int number = 0;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Введите трехзначное число");
            Console.ForegroundColor = ConsoleColor.White;
            while (!fulfillingCondition)
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                if ((number >= 100) && (number < 1000))
                {
                    fulfillingCondition = true;
                }
                else
                {
                    Console.Write("Вы ввели не трехзначное число, попробуйте еще раз: ");
                }

            }
            number = (number / 10) % 10;
            Console.WriteLine($"Ответ {number}");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;