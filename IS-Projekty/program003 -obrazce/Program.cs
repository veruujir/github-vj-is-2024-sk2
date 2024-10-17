//chci, aby se program opakoval po stisku klávesy a
        string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("**********Obdélník**********");
            Console.WriteLine("****************************");
            Console.WriteLine("*****Veronika Jirásková*****");
            Console.WriteLine("****************************\n\n");
            Console.WriteLine();


            //vstup od uživatele - lepší varianta TO DO
            Console.Write("Zadejte šířku obrazce (celé číslo): ");
            int sirka;
            while(!int.TryParse(Console.ReadLine(), out sirka)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
            }
            Console.Write("Zadejte výšku obrazce (celé číslo): ");
            int vyska;
            while(!int.TryParse(Console.ReadLine(), out vyska)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
            }

           // for(int i = 1; i <= 10; i++){
            //    Console.WriteLine(i);
            //}

           // int j =1;
           // while( j <=10 ){
           //     Console.WriteLine(j);
           //     j++;
           // }

           for(int i = 1; i <= vyska; i++){
            for(int j = 1; j <= sirka; j++){
                Console.Write("* ");
        
            }
            Console.WriteLine();
           }
            


            //opakování programu - TO DO 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();




        }
