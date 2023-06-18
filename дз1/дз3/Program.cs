Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Введите цифру");
            Console.ForegroundColor = ConsoleColor.White;
            var userInput = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();          
            if ((userInput.Key == ConsoleKey.D6) || (userInput.Key == ConsoleKey.D7))
            {
                Console.WriteLine("Ура! выходной!");
            }else if ((userInput.Key == ConsoleKey.D1) ||
                (userInput.Key == ConsoleKey.D2) ||
                (userInput.Key == ConsoleKey.D3) ||
                (userInput.Key == ConsoleKey.D4) ||
                (userInput.Key == ConsoleKey.D5))
            {
                Console.WriteLine("Увы, не выходной ;)");
            }
            else { Console.WriteLine("Я вас не понял!"); }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;