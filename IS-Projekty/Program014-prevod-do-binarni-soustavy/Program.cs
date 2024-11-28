
string again = "a";
while(again == "a") {
    //Console.Clear();
    Console.WriteLine("******************************");
    Console.WriteLine("******* Převod z 10 do 2 soustavy *******");
    Console.WriteLine("******************************");
    Console.WriteLine("******** Veronika Jirásková *********");
    Console.WriteLine("******************************\n\n");
    Console.WriteLine();

    Console.Write("Zadejte číslo v 10 soustavě (přirozené číslo): ");
    uint cislo;
    while(!uint.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo v 10 soustavě (přirozené číslo): ");
    }

    uint[] myArray = new uint[32];
    uint zaloha = cislo;
    uint zbytek;

    uint i;
    for(i=0; cislo > 0; i++) {
        zbytek = cislo % 2;
        cislo = (cislo - zbytek)/2;
        myArray[i] = zbytek;

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Celá část = {0}; Zbytek = {1}", cislo, zbytek);
    }


    Console.WriteLine("\n\nPoslední využitý index pole: {0}", i-1);

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\n\nVýsledek:");
    for(int j=(int)i-1; j>=0; j--) {
        Console.Write("{0}",myArray[j]);
    }

    //opakování programu - TO DO 
     Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}