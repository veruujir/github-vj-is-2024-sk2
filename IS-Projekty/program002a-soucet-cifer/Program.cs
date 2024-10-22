//chci, aby se program opakoval po stisku klávesy a
        string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("*******Součet a součin cifer*******");
            Console.WriteLine("***********************************");
            Console.WriteLine("********Veronika Jirásková*********");
            Console.WriteLine("***********************************\n\n");
            Console.WriteLine();


            //vstup od uživatele - lepší varianta TO DO
            Console.Write("Zadejte celé číslo řady: ");
            int number;
            while(!int.TryParse(Console.ReadLine(), out number)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu první číslo řady:");
            }
             //výpis vstupní hodnoty
             Console.WriteLine("");
             Console.WriteLine("Uživatel zadal: {0}", number);
             Console.WriteLine("");

            int suma = 0;
            int soucin = 1; 
            int numberBackup = number;
            int digit;

            if(number < 0){
                number = - number;
            }

            while(number >= 10) {
                digit = number % 10; //operátor modulo (určení zbytku po dělení číslem)
                number = (number - digit) / 10;
                Console.WriteLine("Digit = {0}", digit);
                suma = suma + digit;
                soucin *= digit;
            }
            Console.WriteLine("Digit = {0}", number);
            suma = suma + number;
            soucin = soucin * number;

            Console.WriteLine("\n\nSoučet cifer čísla {0} je {1}", numberBackup, suma);
            Console.WriteLine("Součin cifer čísla {0} je {1}\n\n", numberBackup, soucin);




            //opakování programu 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
