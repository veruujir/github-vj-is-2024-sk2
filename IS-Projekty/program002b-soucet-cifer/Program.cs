  // Opakování programu po stisknutí klávesy 'a'
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("*******Součet cifer*******");
            Console.WriteLine("***********************************");
            Console.WriteLine("********Veronika Jirásková*********");
            Console.WriteLine("***********************************\n\n");

            // Vstup od uživatele
            Console.Write("Zadejte celé číslo řady: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu první číslo řady:");
            }

            // Výpis vstupní hodnoty
            Console.WriteLine("");
            Console.WriteLine("Zadali jste: {0}", number);
            Console.WriteLine("");

            int suma = 0;
            int numberBackup = number;

            // Pokud je číslo záporné, pracujeme s jeho absolutní hodnotou
            if (number < 0)
            {
                number = -number;
            }

            // Součet cifer pomocí odečtu '0' od ASCII hodnoty
            foreach (char digitChar in number.ToString())
            {
                int digit = digitChar - '0'; // Získání hodnoty číslice
                suma += digit;
            }

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);

            // Opakování programu
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
