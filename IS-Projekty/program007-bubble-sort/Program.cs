 using System.Diagnostics;
 
 string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("*******Bubble sort*******");
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

            Console.WriteLine("Náhodná čísla: ");

            for(int i = 0; i<n; i++){
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0};", myArray[i]);
            }

            Stopwatch myStopwatch = new Stopwatch();
            myStopwatch.Start();

            int numberCompare = 0;
            int numberChange = 0;
            for(int i = 0; i < n-1 ; i++){
                for(int j = 0; j<n-i-1 ; j++){
                    numberCompare++;
                    if(myArray[j] < myArray[j+1]){
                        int tmp = myArray[j];
                        myArray[j] = myArray[j+1];
                        myArray[j+1] = tmp;
                        numberChange++;
                    }
                }
            }
            myStopwatch.Stop();

            Console.WriteLine("\n\nSeřazení pole podle bubble sortu:");
             for(int i = 0; i<n; i++){
                 Console.Write("{0};", myArray[i]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n\nČas potřebný na sežazení pole algoritmem Bubble Sort: {0}", myStopwatch.Elapsed);
            
            Console.WriteLine("\n\nPočet porovnání: {0}", numberCompare);
            Console.WriteLine("Počet výměn: {0}", numberChange);

            Console.ResetColor();
            //opakování programu - TO DO 
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }