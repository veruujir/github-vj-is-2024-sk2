// Opakování programu po stisknutí klávesy 'a'
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******Pravoúhlý trojúhelník******");
            Console.WriteLine("****************************");
            Console.WriteLine("*****Veronika Jirásková*****");
            Console.WriteLine("****************************\n\n");

            // Vstup od uživatele
            Console.Write("Zadejte výšku trojúhelníku (celé číslo): ");
            int vyska;
            while (!int.TryParse(Console.ReadLine(), out vyska))
            {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
            }

            // Vykreslení pravoúhlého trojúhelníku
            for (int i = 1; i <= vyska; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }