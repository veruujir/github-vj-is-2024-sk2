
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


            //vstup od uživatele - lepší varianta TO DO
            Console.Write("Zadejte první číslo řady (celé číslo): ");
            int first;
            while(!int.TryParse(Console.ReadLine(), out first)){
                Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu první číslo řady:");
            
            }

            //opakování programu - TO DO 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }

    }

}