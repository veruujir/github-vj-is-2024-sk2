 string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("*******Výpočet PÍ*******");
            Console.WriteLine("****************************");
            Console.WriteLine("*****Veronika Jirásková*****");
            Console.WriteLine("****************************\n\n");
            Console.WriteLine();


            //vstup od uživatele - lepší varianta TO DO
            Console.Write("Zadejte přesnost (reálné číslo - čím menší, tím přesnější výpočet bude): ");
            double presnost;
            while(!double.TryParse(Console.ReadLine(), out presnost)){
                Console.WriteLine("Nezadali jste přesnost správně. Zadejte znovu:");
            
            }
            double i = 1;
            double piCtvrt = 1;
            double znamenko = 1;

            while (1/i >= presnost)
                {
                i = i+2;
                znamenko = -znamenko;
                piCtvrt += znamenko * (1/i);
                }

            double pi = 4 * piCtvrt;

    
            Console.WriteLine("\n\n=================================================");
            Console.WriteLine($"Vypočtená hodnota PÍ: {pi}");
            Console.WriteLine("=================================================\n\n");


            

            //opakování programu - TO DO 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }