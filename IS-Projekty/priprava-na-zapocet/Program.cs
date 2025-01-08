string again = "a"; // = je přiřazení hodnoty, vyhodnocuje se zprava doleva
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("*******Generátor pseudonáhodných čísel*******");
            Console.WriteLine("*********************************************");
            Console.WriteLine("*************Veronika Jirásková**************");
            Console.WriteLine("*****************************************\n\n");

            // vstup od uživatele
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
            Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2},", n, dm, hm);
            Console.WriteLine("\n\n =============================================\n\n");

            // deklarace pole
            int[] myArray = new int[n];

            // příprava pro generování náhodných čísel
            Random randomNumber = new Random();

            Console.WriteLine("Náhodná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = randomNumber.Next(dm, hm + 1);
                Console.Write("{0};", myArray[i]);
            }
        //MINIMUM A MAXIMUM
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

    // Comb sort
    int gap = n;
    bool swapped = true;
    while (gap != 1 || swapped) 
    {
        gap = (int)(gap / 1.3);
        if (gap < 1)
            gap = 1;

        swapped = false;
        for (int i = 0; i < n - gap; i++)
        {
            int j = i + gap;
            if (myArray[i] < myArray[j])
            {
                int temp = myArray[i];
                myArray[i] = myArray[j];
                myArray[j] = temp;
                swapped = true;
            }
        }
    }
    Console.WriteLine("\n\nComb Sort:");
    for (int i = 0; i < n; i++)
        Console.Write("{0};", myArray[i]);

    // seřazení Shaker sort
    int[] shakerArray = (int[])myArray.Clone();

    for (int i = 0; i < shakerArray.Length / 2; i++)
    {
        for (int j = i; j < shakerArray.Length - i - 1; j++)
        {
            if (shakerArray[j] < shakerArray[j + 1])
            {
                int temp = shakerArray[j];
                shakerArray[j] = shakerArray[j + 1];
                shakerArray[j + 1] = temp;
                swapped = true;
            }
        }

        for (int j = shakerArray.Length - 2 - i; j > i; j--)
        {
            if (shakerArray[j] > shakerArray[j - 1])
            {
                int temp = shakerArray[j];
                shakerArray[j] = shakerArray[j - 1];
                shakerArray[j - 1] = temp;
                swapped = true;
            }
        }

        if (!swapped) break;
    }

    Console.WriteLine("\nShaker Sort: ");
    Console.WriteLine(string.Join("; ", shakerArray));

    //bubble sort
    int numberCompare = 0;
    int numberChange = 0;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            numberCompare++;
            if (myArray[j] < myArray[j + 1])
            {
                int tmp = myArray[j];
                myArray[j] = myArray[j + 1];
                myArray[j + 1] = tmp;
                numberChange++;
            }
        }
    }

    Console.WriteLine("\n\nSeřazení pole podle bubble sortu:");
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0};", myArray[i]);
    }

    //insertion sort
    int[] insertionArray = (int[])myArray.Clone();
    for (int i = 1; i < insertionArray.Length; i++)
    {
        int key = insertionArray[i];
        int j = i - 1;
        while (j >= 0 && insertionArray[j] > key)
        {
            insertionArray[j + 1] = insertionArray[j];
            j--;
        }
        insertionArray[j + 1] = key;
    }
    Console.WriteLine("\nInsertion Sort: ");
    Console.WriteLine(string.Join("; ", insertionArray));

    //selection sort
    int[] selectionArray = (int[])myArray.Clone();
    for (int i = 0; i < selectionArray.Length - 1; i++)
    {
        int maxIndex = i;
        for (int j = i + 1; j < selectionArray.Length; j++)
        {
            if (selectionArray[j] > selectionArray[maxIndex])
            {
                maxIndex = j;
            }
        }
        int tmp = selectionArray[i];
        selectionArray[i] = selectionArray[maxIndex];
        selectionArray[maxIndex] = tmp;
    }
    Console.WriteLine("\nSelection Sort: ");
    Console.WriteLine(string.Join("; ", selectionArray));

    //shell sort
    int[] shellArray = (int[])myArray.Clone();
for (int shell = n / 2; shell > 0; shell /= 2)
{
    for (int i = shell; i < n; i++)
    {
        int temp = shellArray[i];
        int j;
        for (j = i; j >= shell && shellArray[j - shell] > temp; j -= shell)
        {
            shellArray[j] = shellArray[j - shell];
        }
        shellArray[j] = temp;
    }
}
Console.WriteLine("\n\nShell Sort:");
for (int i = 0; i < n; i++)
{
    Console.Write("{0};", shellArray[i]);
}

    // druhé, třetí, čtvrté největší číslo
    Array.Sort(myArray);
    Array.Reverse(myArray);
    List<int> uniqueNumbers = new List<int>();
    foreach (int num in myArray)
    {
        if (!uniqueNumbers.Contains(num))
        {
            uniqueNumbers.Add(num);
        }
    }
    int second = uniqueNumbers.Count > 1 ? uniqueNumbers[1] : -1;
    int third = uniqueNumbers.Count > 2 ? uniqueNumbers[2] : -1;
    int fourth = uniqueNumbers.Count > 3 ? uniqueNumbers[3] : -1;

    Console.WriteLine($"\nDruhé největší číslo: {second}");
    Console.WriteLine($"\nTřetí největší číslo: {third}");
    Console.WriteLine($"\nČtvrté největší číslo: {fourth}");

   // Funkce pro výpočet Fibonacciho posloupnosti
static ulong Fibonacci(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;

    ulong a = 0;
    ulong b = 1;
    ulong c = 0;

    for (int i = 2; i <= n; i++)
    {
        c = a + b;
        a = b;
        b = c;
    }

    return c;
}

Console.WriteLine("\n\nFibonacciho posloupnost až do druhého největšího čísla:");
ulong soucet1 = 0;

for (int i = 0; i < second; i++) 
{
    ulong fib = Fibonacci(i);
    Console.Write($"{fib}; ");
    soucet1 += fib; 
}
Console.WriteLine($"\nSoučet Fibonacciho posloupnosti až do druhého největšího čísla: {soucet1}");

// Aritmetický průměr
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += myArray[i];
            }

            int celaCast = suma / n;
            int zbytek = suma % n;

            Console.WriteLine("Suma všech čísel: {0}", suma);
            Console.WriteLine("Aritmetický průměr: {0} (celá část: {1}, zbytek: {2})", (double)suma / n, celaCast, zbytek);

//Aritmetická posloupnost
    int pocet = 10; 
    int diference = fourth;
    int pprvek = second; 
    int soucet2 = pprvek;

    Console.WriteLine($"Počet: {pocet}");
    Console.WriteLine($"Diference: {diference}");
    Console.WriteLine($"První prvek: {pprvek}");
    Console.Write("Aritmetická řada: ");
    Console.Write(pprvek);
    for (int i = 1; i < pocet; i++) 
    {
        pprvek = pprvek + diference;
        soucet2 = soucet2 + pprvek;
        Console.Write(", {0}", pprvek);
    }


    Console.WriteLine($"\nSoučet řady: {soucet2}\n");

  //Median
   double median;
    int middleIndex = myArray.Length / 2;

if (myArray.Length % 2 == 0)  
{
    
    median = (myArray[middleIndex - 1] + myArray[middleIndex]) / 2.0;
}
else  
{
    median = myArray[middleIndex];
}

Console.WriteLine($"Medián: {median}");

//převod do binární soustvy
    Array.Sort(myArray);
    if(n>=2){
    int druhe = myArray[n-2];
    Console.WriteLine($"Druhé největší číslo: {second}");
    string binarni = Convert.ToString(second,2);
    Console.WriteLine ($"Druhé největší číslo v binární soustavě: {second}(2) = {binarni}");
}
else{
    Console.WriteLine("Pole nemá alespoň 2 prvky pro výpočet druhého největšího čísla.");
}

//Převod čísla do čtyřkové soustavy
static string ConvertToQuanternary(int number)
{
    string quaternary = "";
    while (number > 0)
    {
        int remainder = number % 4;
        quaternary = remainder + quaternary;
        number /= 4;
    }
    return quaternary != "" ? quaternary : "0";
}
Console.WriteLine($"Druhé největší číslo v čtyřkové soustavě je: {second}(4) = {ConvertToQuanternary(second)}");

// Součet a součin cifer maxima
int zaloha12 = maximum;
int cifra1;

if (maximum < 0)
    maximum = -maximum;

int sumaMaximum = 0;
int soucinMaximum = 1;
int tempMaximum = maximum;

while (tempMaximum > 0)
{
    cifra1 = tempMaximum % 10;
    tempMaximum /= 10;
    sumaMaximum += cifra1;  
    soucinMaximum *= cifra1;  
}
Console.WriteLine("Součet cifer čísla {0} = {1}", zaloha12, sumaMaximum);
Console.WriteLine("Součin cifer čísla {0} = {1}", zaloha12, soucinMaximum);

//Celočíselný průměr
static int CelyPrumer(int[] pole)
{
    return pole.Length == 0 ? 0 : pole.Sum() / pole.Length;
}

int prumer = CelyPrumer(myArray);
Console.WriteLine($"\n\nCeločíselný průměr vygenerovaných čísel: {prumer}");

static int SoucetCiferVCSoustave(int cislo, int soustava)
{
    int sum = 0;
    while (cislo > 0)
    {
        sum += cislo % soustava;
        cislo /= soustava;
    }
    return sum;
}

//Dělitelnost třemi
int pocetDelitelnych = pocetCiselDelitelnychTremi (myArray);
Console.WriteLine($"\n\nPočet čísel dělitelných třemi: {pocetDelitelnych}");

static int pocetCiselDelitelnychTremi(int[]pole){
    int pocet = 0;
    foreach(int cislo in pole){
        if (cislo%3==0){
            pocet++;
        }
    }
    return pocet;
}

//NSD a NSN
int a = second;
int b = third;
long zaloha1 = a;
long zaloha2 = b;

while(a != b)
{
    if(a > b)
        a = a - b;
    else
        b = b - a;
}

long NSD = a; 
Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", zaloha1, zaloha2, NSD);
long NSN = (zaloha1 * zaloha2) / NSD;
Console.WriteLine("\n\nNSN čísel {0} a {1} je {2}", zaloha1, zaloha2, NSN);

//Počet sudých a lichých 
int pocetSudych, pocetLichych;
SpocitejSudeLiche(myArray,out pocetSudych, out pocetLichych);
Console.WriteLine($"\n\nPočet sudých čísel: {pocetSudych}");
Console.WriteLine($"Počet lichých čísel: {pocetLichych}");

static void SpocitejSudeLiche(int[]myArray, out int pocetSudych, out int pocetLichych){
    pocetSudych = 0;
    pocetLichych = 0;
    foreach (int cislo in myArray){
        if (cislo % 2 ==0){
            pocetSudych++;
        }
        else{
            pocetLichych++;

        }
    }}

   //Faktoriál 2. největšího čísla
    int faktorial = faktorial1(second);
        Console.WriteLine($"\nFaktoriál druhého největšího čísla: {faktorial}");

    static int faktorial1(int cislo)
    {
        if (cislo == 0)
        {
            return 1;
        }
        int faktorial = 1;
        for (int i = 2; i <= cislo; i++)
        {
            faktorial *= i;
        }
        return faktorial;
    }

     //INTERVALY
    int int01 = 0, int02 = 0, int03 = 0, int04 = 0;

       
        double intervalSize = (double)(hm - dm) / 4; 
        foreach (int num in myArray)
        {
            if (num <= dm + intervalSize)
                int01++;
            else if (num <= dm + 2 * intervalSize)
                int02++;
            else if (num <= dm + 3 * intervalSize)
                int03++;
            else
                int04++;
        }
        Console.WriteLine("\n\nIntervaly:");
        Console.WriteLine("Interval <{0}; {1}>: {2}", dm, dm + intervalSize, int01);
        Console.WriteLine("Interval <{0}; {1}>: {2}", dm + intervalSize + 1, dm + 2 * intervalSize, int02);
        Console.WriteLine("Interval <{0}; {1}>: {2}", dm + 2 * intervalSize + 1, dm + 3 * intervalSize, int03);
        Console.WriteLine("Interval <{0}; {1}>: {2}", dm + 3 * intervalSize + 1, hm, int04);

    // Kosodélník, šířka: třetí největší číslo, výška: čtvrté největší
   int width = third; // šířka
int height = fourth; // výška

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < width; j++)
    {
        if (i == 0 || i == 1 || i == height - 1 || i == height - 2)
        {
            Console.Write("* ");
        }
        else if (j == 0 || j == width - 1)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }

    Console.WriteLine();
}
Console.WriteLine("\n");

//ŠTÍT
int vyska4 = second; 
for (int i = 0; i < vyska4 / 2 + 1; i++)
{
    for (int j = 0; j < vyska4; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}
for (int i = 0; i < vyska4 / 2 + 1; i++) 
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("  "); 
    }

    for (int j = 0; j < vyska4 - (2 * i); j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}

Console.WriteLine("\n");

 // dva trojúhelníky a čtverec mezi nimi
int vyska6 = second; // Výška a šířka trojúhelníku a čtverce
int width6 = vyska6; 

// Horní rovnostranný trojúhelník
for (int i = 1; i <= vyska6 / 2; i++)
{
    for (int j = 0; j < (vyska6 - i); j++) // Mezery na začátku řádku
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2 * i - 1; j++) // Hvězdičky v řádku
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}

// Čtverec
for (int i = 0; i < vyska6; i++)
{
    for (int j = 0; j < width6; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}

// Spodní rovnostranný trojúhelník
for (int i = vyska6 / 2 - 1; i >= 0; i--)
{
    for (int j = 0; j < (vyska6 - i); j++) // Mezery na začátku řádku
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2 * i - 1; j++) // Hvězdičky v řádku
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}


    //PŘESÝPACÍ HODINY
   int height1 = second;  
int width1 = 2 * height1; 

Console.WriteLine("\n\nPřesýpací hodiny:");

for (int i = 0; i < height1; i++)  
{
    for (int j = 0; j < width1; j++)
    {
        if (j >= i && j < width1 - i)  
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

for (int i = height1 - 2; i >= 0; i--)  
{
    for (int j = 0; j < width1; j++)
    {
        if (j >= i && j < width1 - i) 
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine("\n");


//ŠIPKA NAHORU
int vyska8 = second; 
int sirka8 = 3; 

for (int i = 1; i <= vyska8; i++)
{
    for (int j = 1; j <= vyska8 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
for (int i = 0; i < vyska8; i++) 
{
    int mezera = (vyska8 - sirka8) / 2; 
    for (int j = 0; j < mezera; j++) 
    {
        Console.Write(" ");
    }

    for (int j = 0; j < sirka8; j++)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}
Console.WriteLine("\n");
Console.WriteLine("\n");


//ŠIPKA DOLU
int vyska80 = second;
int sirka80 = 3; 

for (int i = 0; i < vyska80; i++) 
{
    int mezera = (vyska80 - sirka80) / 2; 
    for (int j = 0; j < mezera; j++) 
    {
        Console.Write(" ");
    }
    for (int j = 0; j < sirka80; j++) 
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}

for (int i = vyska80; i >= 1; i--)
{
    
    for (int j = 1; j <= vyska80 - i; j++) 
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= i; k++)
    {
        Console.Write("* "); 
    }

    Console.WriteLine();
}

Console.WriteLine("\n");
Console.WriteLine("\n");



 //PRAVOÚHLÝ TROJÚHELNÍK
 int vyska = second;

for (int i = 1; i <= vyska; i++)
{
    // Přidání mezer pro zrcadlový efekt
    for (int j = 1; j <= vyska - i; j++)
    {
        Console.Write(" ");  // Mezery pro zrcadlový efekt
    }

    // Výpis hvězdiček bez mezer mezi nimi
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");  // Hvězdičky, bez mezery mezi nimi
    }

    Console.WriteLine();
}
Console.WriteLine("\n");

//ČTVEREC ÚHLOPŘÍČNĚ PRÁZDNÝ
int vyskaSirka = second;

for (int i = 0; i < vyskaSirka; i++)  // Řádky
{
    for (int j = 0; j < vyskaSirka; j++)  // Sloupce
    {
        // Okraje čtverce a úhlopříčka zleva doprava
        if (i == 0 || i == vyskaSirka - 1 || j == 0 || j == vyskaSirka - 1 || i == j)
        {
            Console.Write("* ");
        }
        // V prostoru nad úhlopříčkou (i < j) vypíšeme nulu
        else if (i < j)
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("  ");  // Mezery uvnitř čtverce
        }
    }
    Console.WriteLine();
}

Console.WriteLine("\n");
//ROVNOSTRANNÝ TROJÚHELNÍK
        int vyska10 = second;

for (int i = 1; i <= vyska10; i++)
{
    for (int j = 1; j <= vyska10 - i; j++)
    {
        Console.Write(" ");
    }

    for (int k = 1; k <= i; k++)
    {
        Console.Write("* "); 
    }

    Console.WriteLine();
}

Console.WriteLine("\n");
    //OBDÉLNÍK
    int sirka3 = second;
    int vyska3 = third;

for (int h = 0; h < vyska; h++)
{
    for (int j = 0; j < sirka3; j++) 
    {
        if (h == 0 || h == vyska - 1 || j == 0 || j == sirka3 - 1) 
        {
            Console.Write("*");
        }
        else 
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine(); 
}
    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();}
 