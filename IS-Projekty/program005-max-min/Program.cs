string again = "a"; //= je přiřazení hodnoty, vyhodnocuje se zprava doleva
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************");
    Console.WriteLine("*******Generátor pseudonáhodných čísel*******");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************Veronika Jirásková**************");
    Console.WriteLine("*****************************************\n\n");
    Console.WriteLine();

    // Vstup od uživatele
    Console.Write("Zadejte počet generovaných čísel: ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
    }
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dm;
    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
    }
    Console.Write("Zadejte horní mez (celé číslo): ");
    int hm;
    while (!int.TryParse(Console.ReadLine(), out hm))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu celé číslo:");
    }

    Console.WriteLine("\n\n =================================================");
    Console.WriteLine("\n\nUživatelský vstup:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, dm, hm);
    Console.WriteLine("\n\n =============================================\n\n");

    int[] myArray = new int[n];

    Random randomNumber = new Random();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n; i++)
    {
        myArray[i] = randomNumber.Next(dm, hm + 1);
        Console.Write("{0}; ", myArray[i]);
    }

    int minimum = myArray[0];
    int maximum = myArray[0];

    List<int> poziceMin = new List<int>();
    List<int> poziceMax = new List<int>();

    poziceMin.Add(0);
    poziceMax.Add(0);

    for (int i = 1; i < n; i++)
    {
        if (myArray[i] < minimum)
        {
            minimum = myArray[i];
            poziceMin.Clear();
            poziceMin.Add(i);
        }
        else if (myArray[i] == minimum)
        {
            poziceMin.Add(i);
        }

        if (myArray[i] > maximum)
        {
            maximum = myArray[i];
            poziceMax.Clear();
            poziceMax.Add(i);
        }
        else if (myArray[i] == maximum)
        {
            poziceMax.Add(i);
        }
    }

    Console.WriteLine("\n\nMinimum: {0} (počet výskytů: {1})", minimum, poziceMin.Count);
    Console.Write("Pozice minimálních hodnot: ");
    foreach (int pozice in poziceMin)
    {
        Console.Write(pozice + ", ");
    }

    Console.WriteLine("\n\nMaximum: {0} (počet výskytů: {1})", maximum, poziceMax.Count);
    Console.Write("Pozice maximálních hodnot: ");
    foreach (int pozice in poziceMax)
    {
        Console.Write(pozice + ", ");
    }

    // Opakování programu
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
