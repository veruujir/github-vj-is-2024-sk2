 string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("*******Analýza textu*******");
            Console.WriteLine("****************************");
            Console.WriteLine("*****Veronika Jirásková*****");
            Console.WriteLine("****************************\n\n");
            Console.WriteLine();



            Console.WriteLine("Zadejte text pro analýzu: ");
            string myText = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine(myText);
            //Console.WriteLine(myText[0]);
            //Console.WriteLine(myText.Length);
            //Console.WriteLine(myText[myText.Length - 1]);

             string samohlasky = "aeiouyáéíóúůý"; 
            string souhlasky = "bcčdďfghjklmnňpqrřsštťvwxzž"; 
            string cislice = "0123456789"; 
            string samohlaskyVelke = "AEIOUYÁÉÍÓÚŮÝ";
            string souhlaskyVelke = "BCČDĎFGHJKLMNŇPQRŘSŠTŤVWXZŽ";

            int pocetsamohlasek = 0;
            int pocetsouhlasek = 0;
            int pocetcislic = 0;
            int pocetznaku = 0;
            int pocetsamohlasekVelkych = 0;
            int pocetsouhlasekVelkych = 0;

    foreach (char c in myText)
    {
        if (samohlasky.IndexOf(c) >= 0)  
        {
            pocetsamohlasek++;
        }
        else if (souhlasky.IndexOf(c) >= 0)  
        {
            pocetsouhlasek++;
        }
        else if (cislice.IndexOf(c) >= 0) 
        {
            pocetcislic++;
        }
        else if (samohlaskyVelke.IndexOf(c) >= 0)
        {
            pocetsamohlasekVelkych++;
        }
        else if (souhlaskyVelke.IndexOf(c) >= 0)
        {
            pocetsouhlasekVelkych++;
        }
        else  
        {
            pocetznaku++;
        }
    }

    Console.WriteLine("\nVýsledky analýzy:");
    Console.WriteLine($"Počet samohlásek: {pocetsamohlasek}");
    Console.WriteLine($"Počet souhlásek: {pocetsouhlasek}");
    Console.WriteLine($"Počet číslic: {pocetcislic}");
    Console.WriteLine($"Počet velkých samohlásek: {pocetsamohlasekVelkych}");
    Console.WriteLine($"Počet velkých souhlásek: {pocetsouhlasekVelkych}");
    Console.WriteLine($"Počet ostatních znaků: {pocetznaku}");

            
            

            //opakování programu - TO DO 
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }