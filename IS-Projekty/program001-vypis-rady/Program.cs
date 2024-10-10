using System;
using System.Collections.Specialized;
using System.Threading.Tasks.Dataflow;

class Program {

    static void Main() {

        //chci, aby se program opakoval po stisku klávesy a
        string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("*******Název programu*******");
            Console.WriteLine("****************************");
            Console.WriteLine("*****Veronika Jirásková*****");
            Console.WriteLine("****************************\n\n");
            Console.WriteLine();

            //vstup od uživatele - špatná varianta TO DO
            //Console.Write("Zadejte první číslo řady: ");
            //int first = int.Parse(Console.ReadLine());

            //vstup od uživatele - lepší varianta TO DO
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu první číslo řady:");
            }

            Console.Write("Zadejte poslední číslo řady (celé číslo): ");
            int last;
            while(!int.TryParse(Console.ReadLine(), out last)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu poslední číslo řady:");
            }

            Console.Write("Zadejte diferenci: ");
            int step;
            while(!int.TryParse(Console.ReadLine(), out step)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu diferenci:");

            //výpis uživatelského vstupu
            Console.WriteLine();
            Console.WriteLine("================================================");
            Console.WriteLine("První číslo řady: {0}", first);
            Console.WriteLine("Poslední číslo řady: {0},", last);
            Console.WriteLine("Diference řady: {0}", step);
            Console.WriteLine();
            Console.WriteLine();


            //logika pro výpis řady - TO DO

            //opakování programu - TO DO 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }

    }

}}