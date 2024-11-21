 string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("*******Generátor - intervaly*******");
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
            int interval01 = 0;
            int interval02 = 0;
            int interval03 = 0;
            int interval04 = 0;
            for(int i = 0; i<n; i++){
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0};", myArray[i]);

                if(myArray[i] <= (0.25 * hm)){
                    interval01++;
                }else if(myArray [i] <= (0.5*hm)){
                    interval02++;
                }else if(myArray [i] <= (0.75*hm)){
                    interval03++;
                }else
                    interval04++;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n Interval <{0};{1}>: {2}", dm, 0.25*hm, interval01);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n Interval <{0};{1}>: {2}", 0.25*hm+1, 0.5*hm, interval02);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n Interval <{0};{1}>: {2}", 0.5*hm+1, 0.75*hm, interval03);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n Interval <{0};{1}>: {2}", 0.75*hm+1, hm, interval04);
            Console.ForegroundColor = ConsoleColor.White;





            //opakování programu - TO DO 
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }