// Opakování programu po stisknutí klávesy 'a'
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("******Písmeno Z******");
            Console.WriteLine("****************************");
            Console.WriteLine("*****Veronika Jirásková*****");
            Console.WriteLine("****************************\n\n");

         Console.Write("Zadejte velikost obrazce (celé číslo): ");
            int size;
        while (!int.TryParse(Console.ReadLine(), out size))
            {
         Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
             }

            for (int i = 0; i < size; i++)
            {
             for (int j = 0; j < size; j++)
             {
            if (i == 0 || i == size - 1 || i + j == size - 1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
            Console.WriteLine();
        }
            
            Console.WriteLine("\n\n****************************");
            Console.WriteLine("******Kosočtverec vyplněný******");
            Console.WriteLine("****************************\n\n");

            Console.Write("Zadejte velikost obrazce (celé číslo): ");
                int velikost;
            while (!int.TryParse(Console.ReadLine(), out velikost) || velikost <= 0)
                {
            Console.WriteLine("Nezadali jste kladné celé číslo. Zadejte znovu celé číslo:");
                }

            // Horní polovina kosočtverce
            for (int i = 0; i < velikost; i++)
                {
            for (int j = 0; j < velikost * 2 - 1; j++)
                {
            // Podmínky pro vykreslení horní poloviny kosočtverce
            if (j >= velikost - 1 - i && j <= velikost - 1 + i)
                {
            Console.Write("* ");
                }
                else
                {
            Console.Write("  ");
                }
            }
            Console.WriteLine();
            }

        // Dolní polovina kosočtverce
            for (int i = velikost - 2; i >= 0; i--)
            {
            for (int j = 0; j < velikost * 2 - 1; j++)
            {
        // Podmínky pro vykreslení dolní poloviny kosočtverce
            if (j >= velikost - 1 - i && j <= velikost - 1 + i)
            {
            Console.Write("* ");
            }
            else
            {
            Console.Write("  ");
            }
            }
            Console.WriteLine();
            }

            Console.WriteLine("\n\n****************************");
            Console.WriteLine("******Přesýpací hodiny******");
            Console.WriteLine("****************************\n\n");

            Console.Write("Zadejte výšku obrazce (celé číslo): ");
                int výška;
            while (!int.TryParse(Console.ReadLine(), out výška) || výška <= 0)
            {
            Console.WriteLine("Nezadali jste kladné celé číslo. Zadejte znovu celé číslo:");
            }

        // Horní polovina přesýpacích hodin
            for (int i = 0; i < výška; i++)
            {
             for (int j = 0; j < výška * 2 - 1; j++)
            {
        // Podmínky pro vykreslení horní poloviny přesýpacích hodin
            if (j >= i && j < výška * 2 - 1 - i)
            {
            Console.Write("* ");
            }
            else
             {
            Console.Write("  ");
             }
            }
            Console.WriteLine();
            }

        // Dolní polovina přesýpacích hodin
            for (int i = výška - 2; i >= 0; i--)
            {
            for (int j = 0; j < výška * 2 - 1; j++)
            {
        // Podmínky pro vykreslení dolní poloviny přesýpacích hodin
            if (j >= i && j < výška * 2 - 1 - i)
             {
            Console.Write("* ");
             }
            else
            {
            Console.Write("  ");
             }
            }
             Console.WriteLine();
            }

            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }