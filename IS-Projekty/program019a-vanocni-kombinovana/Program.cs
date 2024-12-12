
        string again = "a"; // Výchozí hodnota pro opakování programu
        while (again == "a") 
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("********  Vánoční kombinovaná úloha  ********");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*************Veronika Jirásková**************");
            Console.WriteLine("*****************************************\n\n");

            // Získání vstupních hodnot od uživatele
            Console.Write("Zadejte počet generovaných čísel: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm = int.Parse(Console.ReadLine());
            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm = int.Parse(Console.ReadLine());

            Console.WriteLine("\n\n =================================================");
            Console.WriteLine("\n\nUživatelský vstup:");
            Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2},", n, dm, hm);
            Console.WriteLine("\n\n =============================================\n\n");

            // Deklarace pole pro náhodná čísla
            int[] myArray = new int[n];
            Random randomNumber = new Random();
            Console.WriteLine("Náhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0};", myArray[i]);
            }

            // Comb Sort
            Console.WriteLine("\n\n****************** Comb sort *********************");

            int gap = n;
            bool swapped = true;
            while (gap != 1 || swapped)
            {
                gap = (int)(gap / 1.3);
                if (gap < 1) gap = 1;

                swapped = false;
                for (int i = 0; i < n - gap; i++)
                {
                    int k = i + gap;
                    if (myArray[i] < myArray[k])
                    {
                        int temp = myArray[i];
                        myArray[i] = myArray[k];
                        myArray[k] = temp;
                        swapped = true;
                    }
                }
            }

            Console.WriteLine("\nComb Sort:");
            foreach (var num in myArray)
                Console.Write("{0};", num);

            // Opět generování náhodných čísel pro další algoritmus
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
            }

            // Insertion Sort
            Console.WriteLine("\n\n****************** Insertion sort *********************");

            for (int i = 1; i < n; i++)
            {
                int item = myArray[i];
                int j = i - 1;
                while (j >= 0 && myArray[j] > item)
                {
                    myArray[j + 1] = myArray[j];
                    j--;
                }
                myArray[j + 1] = item;
            }

            Console.WriteLine("\nInsertion Sort:");
            foreach (var num in myArray)
                Console.Write("{0};", num);

            // Aritmetický průměr
            Console.WriteLine("\n\n****************** Aritmetický průměr *********************");
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += myArray[i];
            }

            int celaCast = suma / n;
            int zbytek = suma % n;

            Console.WriteLine("Suma všech čísel: {0}", suma);
            Console.WriteLine("Aritmetický průměr: {0} (celá část: {1}, zbytek: {2})", (double)suma / n, celaCast, zbytek);

            // Vánoční stromeček
            Console.WriteLine("\n\n****************** Vánoční stromeček *********************");
            for (int i = 1; i <= celaCast; i++)
            {
                for (int vyska = 1; vyska <= i; vyska++)
                {
                    Console.Write(new string(' ', celaCast - vyska + 1));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new string('*', vyska * 2 - 1));
                }
            }

            int kmenVyska = celaCast - 1;
            int kmenSirka = celaCast - 2;

            if (kmenVyska < 1) kmenVyska = 1;
            if (kmenSirka < 1) kmenSirka = 1;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < kmenVyska; i++)
            {
                for (int l = 1; l <= celaCast - (kmenSirka / 2); l++)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < kmenSirka; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;

            // Opakování programu
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }

