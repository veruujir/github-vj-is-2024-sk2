﻿ string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
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

            Console.WriteLine("Náhodná čísla: ");

            for(int i = 0; i<n; i++){
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0};", myArray[i]);
            }

            int minimum = myArray[0];
            int maximum = myArray[0];
            int poziceMin = 0;
            int poziceMax = 0;
            
            

            for (int i = 1; i < n; i++)
            {
        if (myArray[i] < minimum)
        {
            minimum = myArray[i];
            poziceMin = i;
        }
        if (myArray[i] > maximum)
        {
            maximum = myArray[i];
            poziceMax = i;
        }
    }

    Console.WriteLine("\n\nMinimum: {0} (první je na pozici {1})", minimum, poziceMin);
    Console.WriteLine("Maximum: {0} (první je na pozici {1})", maximum, poziceMax);




            //opakování programu - TO DO 
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }