string opakovani = "a";

while(opakovani == "a")
{
    Console.Clear(); // vymaže obrazovku
    Console.WriteLine("***************************************");
    Console.WriteLine("********* Generátor - 2D pole *********");
    Console.WriteLine("********* Veronika Jirásková **********");
    Console.WriteLine("***************************************");


    Console.Write("Zadejte počet řádků (m): ");
    int m;
    while(!int.TryParse(Console.ReadLine(), out m))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu počet řádků: ");
    
    Console.Write("Zadejte počet sloupců (n): ");
    int n;
    while(!int.TryParse(Console.ReadLine(), out n))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu počet sloupců: ");

    Console.Write("Zadejte dolní mez intervalu (dm): ");
    int dm;
    while(!int.TryParse(Console.ReadLine(), out dm))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu dolní mez: ");
    
    Console.Write("Zadejte horní mez intervalu (hm): ");
    int hm;
    while(!int.TryParse(Console.ReadLine(), out hm))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu horní mez: ");    

    Console.Write("Hledané číslo: ");
    int hledaneCislo;
    while(!int.TryParse(Console.ReadLine(), out hledaneCislo))
        Console.Write("Nebylo zadáno celé  číslo. Zadejte znovu hledané číslo: ");        

    Console.WriteLine("\n\n=========================================================================");
    Console.WriteLine("počet řádků: {0}; počet sloupců: {1}; dolní mez: {2}; horní mez: {3}",m, n, dm, hm);
    Console.WriteLine("=============================================================================");

    Random nahodne = new Random();
    int[,] pole = new int[m,n];    //deklarace pole

    int pocetHledanych = 0;

    Console.WriteLine("\nNáhodná čísla: ");
    for(int i=0; i<m;i++)
    {
        for(int j=0; j<n;j++)
        {
         pole[i,j] = nahodne.Next(dm, hm+1);
         if(pole[i,j]==hledaneCislo)
            pocetHledanych++;
         Console.Write("{0}; ", pole[i,j]);   
        }
        Console.WriteLine();
    }

    if(pocetHledanych==0)
        Console.WriteLine("\nHledané číslo {0} nebylo nalezeno", hledaneCislo);
    else 
        Console.WriteLine("\nHledané číslo {0} bylo nalezeno. Počet výskytů: {1}", hledaneCislo, pocetHledanych);    

    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a.");
    Console.WriteLine("Stiskem jiné klávesy program ukončíte.");
    opakovani = Console.ReadLine();
}