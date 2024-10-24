 string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("*******Generátor pseudonáhodných čísel*******");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*************Veronika Jirásková**************");
            Console.WriteLine("*****************************************\n\n");
            Console.WriteLine();


            //vstup od uživatele - lepší varianta TO DO
            Console.Write("Zadejte počet generovaných čísel: ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
            
            }
             Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
            
            }
              Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
            
            }

            Console.WriteLine("\n\n =================================================");
            Console.WriteLine("\n\nUživatelský vstup:");
            Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2},", n, dm, hm);
            Console.WriteLine("\n\n =============================================\n\n");

            //deklarace pole
            int[] myArray = new int[n];

            //příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            int negativeCount = 0;
            int positiveCount = 0;
            int zeroCount = 0;
            int suda = 0;
            int licha =0;

            Console.WriteLine("Náhodná čísla: ");
            


            for(int i = 0; i<n; i++){
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0};", myArray[i]);
        

             if (myArray[i] < 0) {
                    negativeCount++;
            } else if (myArray[i] > 0) {
                    positiveCount++;
            } else {
                    zeroCount++;
             }
             

             if (myArray[i]%2 == 0 )
                suda ++;
             else
                licha ++;
             }






            Console.WriteLine("\nZáporná čísla: {0}", negativeCount);
            Console.WriteLine("Kladná čísla: {0} ", positiveCount);
            Console.WriteLine("Nuly: {0}", zeroCount);
            Console.WriteLine("Sudá čísla: {0} ", suda);
            Console.WriteLine("Lichá čísla: {0}", licha);


            //opakování programu - TO DO 
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }