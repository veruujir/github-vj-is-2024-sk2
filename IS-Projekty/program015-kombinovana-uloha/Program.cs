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

            Console.WriteLine("Náhodná čísla: ");

            for(int i = 0; i<n; i++){
            myArray[i] = randomNumber.Next(dm, hm+1);
            Console.Write("{0};", myArray[i]);
            }
    

    Console.WriteLine("\n\n*******Minimum a maximum*******");

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


        Console.WriteLine("\n\n*******Shaker Sort*******");
        int[] shakerArray = (int[])myArray.Clone();
            int shakerCompare = 0, shakerSwap = 0;
            for (int i = 0; i < shakerArray.Length / 2; i++)
            {
                bool swapped = false;
                for (int j = i; j < shakerArray.Length - i - 1; j++)
                {
                    shakerCompare++;
                    if (shakerArray[j] < shakerArray[j + 1])
                    {
                        int temp = shakerArray[j];
                        shakerArray[j] = shakerArray[j + 1];
                        shakerArray[j + 1] = temp;
                        shakerSwap++;
                        swapped = true;
                    }
                }
                for (int j = shakerArray.Length - 2 - i; j > i; j--)
                {
                    shakerCompare++;
                    if (shakerArray[j] > shakerArray[j - 1])
                    {
                        int temp = shakerArray[j];
                        shakerArray[j] = shakerArray[j - 1];
                        shakerArray[j - 1] = temp;
                        shakerSwap++;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            Console.WriteLine("\nShaker Sort: ");
            Console.WriteLine(string.Join("; ", shakerArray));
            Console.WriteLine("Porovnání: {0}, Výměny: {1}", shakerCompare, shakerSwap);

            Console.WriteLine("\n\n*******Druhé, třetí a čtvrté největší číslo*******");

// Seřadíme pole v sestupném pořadí
Array.Sort(myArray);
Array.Reverse(myArray);

// Odstraníme duplicity tím, že vytvoříme nový seznam
List<int> uniqueNumbers = new List<int>();
foreach (int num in myArray)
{
    if (!uniqueNumbers.Contains(num))
    {
        uniqueNumbers.Add(num);
    }
}

// Zkontrolujeme, zda máme dostatek unikátních čísel
int second = uniqueNumbers.Count > 1 ? uniqueNumbers[1] : -1;
int third = uniqueNumbers.Count > 2 ? uniqueNumbers[2] : -1;
int fourth = uniqueNumbers.Count > 3 ? uniqueNumbers[3] : -1;

Console.WriteLine($"\nDruhé největší číslo: {second}");
Console.WriteLine($"\nTřetí největší číslo: {third}");
Console.WriteLine($"\nČtvrté největší číslo: {fourth}");

Console.WriteLine("\n\n*******Medián*******");

// Seřadíme pole
Array.Sort(myArray);

// Výpočet mediánu
double median;
int middleIndex = myArray.Length / 2;

if (myArray.Length % 2 == 0)  // Pokud je počet čísel sudý
{
    // Průměr dvou prostředních hodnot
    median = (myArray[middleIndex - 1] + myArray[middleIndex]) / 2.0;
}
else  // Pokud je počet čísel lichý
{
    // Prostřední hodnota
    median = myArray[middleIndex];
}

Console.WriteLine($"Medián: {median}");


Array.Sort(myArray);
    if(n>=4){
    int ctvrteNejvetsi = myArray[n-4];
    Console.WriteLine($"Čtvrté největší číslo: {ctvrteNejvetsi}");
    string binarni = Convert.ToString(ctvrteNejvetsi,2);
    Console.WriteLine ($"Čtvrté největší číslo v binární soustavě: {binarni}");
}
else{
    Console.WriteLine("Pole nemá alespoň 4 prvky pro výpočet čtvrtého největšího čísla.");
}




            //opakování programu - TO DO 
            Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();



        }