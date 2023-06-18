bool fulfillingCondition = false;
            int number = 0;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Введите число");
            Console.ForegroundColor = ConsoleColor.White;
            while (!fulfillingCondition)
            {
                number = Convert.ToInt32(Console.ReadLine());
                
                if (number > 100)
                {
                    fulfillingCondition = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Данное число не имеет искомое значение");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (number >= 1000)
            {
                number = number / 10;
            }
            number = number % 10;
            
            Console.WriteLine($"Ответ {number}");     
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;