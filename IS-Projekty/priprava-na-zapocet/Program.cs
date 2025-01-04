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

            // Smyčka pro hledání minima a maxima
            for (int i = 1; i < n; i++)
            {
                // Hledání minima
                if (myArray[i] < minimum)
                {
                    minimum = myArray[i];
                    poziceMin.Clear();  // Vymaže předchozí pozice
                    poziceMin.Add(i);   // Přidá novou pozici pro nové minimum
                }
                else if (myArray[i] == minimum)
                {
                    poziceMin.Add(i);  // Pokud je hodnota rovna minimu, přidá pozici
                }

                // Hledání maxima
                if (myArray[i] > maximum)
                {
                    maximum = myArray[i];
                    poziceMax.Clear();  // Vymaže předchozí pozice
                    poziceMax.Add(i);   // Přidá novou pozici pro nové maximum
                }
                else if (myArray[i] == maximum)
                {
                    poziceMax.Add(i);  // Pokud je hodnota rovna maximu, přidá pozici
                }
            }

            // Výpis výsledků
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

    // seřazení Comb sort
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

    // seřazení bubble sort
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

    // seřazení insertion sort
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

    // seřazení selection sort
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

    //seřazení shell sort
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

    // Fibonacciho posloupnost
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
ulong soucet1 = 0; // Tady je správná inicializace součtu

for (int i = 0; i <= second; i++)
{
    ulong fib = Fibonacci(i);
    Console.Write($"{fib}; ");
    soucet1 += fib; // Přičítání k součtu
}

Console.WriteLine($"\nSoučet Fibonacciho posloupnosti až do druhého největšího čísla: {soucet1}");

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
    if(n>=4){
    int ctvrteNejvetsi = myArray[n-4];
    Console.WriteLine($"Čtvrté největší číslo: {fourth}");
    string binarni = Convert.ToString(fourth,2);
    Console.WriteLine ($"Čtvrté největší číslo v binární soustavě: {binarni}");
}
else{
    Console.WriteLine("Pole nemá alespoň 4 prvky pro výpočet čtvrtého největšího čísla.");
}

// převod do čtyřkové soustavy
static string ConvertToQuanternary(int number){ /*ConvertToSenary pokud šestková*/
    string quaternary="";
    while (number > 0){
        int remainder = number%4; /*6 pokud šestková*/
        quaternary = remainder+quaternary;
        number/=4; /*6 pokud šestková*/
    }
    return quaternary!=""?quaternary: "0";
}
// součet a součin cifer maxima a minima
int zaloha12 = maximum;
int zaloha22 = minimum;
int suma1 = 0;  
int soucin1 = 1;  
int cifra1;

if (maximum < 0)
    maximum = -maximum;

if (minimum < 0)
    minimum = -minimum;


while (minimum >= 10)
{
    cifra1 = minimum % 10;
    minimum = (minimum - cifra1) / 10;
    suma1 += cifra1;  
    soucin1 *= cifra1;  
}

suma1 += maximum;
soucin1 *= minimum;

Console.WriteLine("Součet cifer čísla {0} = {1}", zaloha12, suma1);
Console.WriteLine("Součin cifer čísla {0} = {1}", zaloha22, soucin1);

//Celočíselný průměr
static int CelociselnyPrumer(int[] pole)
{
    if (pole.Length == 0)
    {
        return 0;
    }
    int soucet = 0;
    foreach (int cislo in pole)
    {
        soucet += cislo;
    }
    return soucet / pole.Length;
}

int prumer = CelociselnyPrumer(myArray);
Console.WriteLine($"\n\nCeločíelný průměr vygenerovaných čísel: {prumer}");

static int CelociselnyPrumerSoustava(int cislo, int soustava, int[] pole)
{
    int zbytek;
    int sum = 0;
    for (int i = 0; cislo > 0; i++)
    {
        zbytek = cislo % soustava;
        sum += zbytek;
        cislo = cislo / soustava;
        pole[i] = zbytek;
        Console.WriteLine("Číslo = {0}, zbytek = {1}", cislo, zbytek);
    }
    return sum;
}
//Dělitelnost třemi

int pocetDelitelnych = pocetCiselDelitelnchTremi (myArray);
Console.WriteLine($"\n\nPočet čísel dělitelných třemi: {pocetDelitelnych}");

static int pocetCiselDelitelnchTremi(int[]pole){
    int pocet = 0;
    foreach(int cislo in pole){
        if (cislo%3==0){
            pocet++;
        }
    }
    return pocet;
}
 Console.WriteLine("NSD a NSN");
//NSD a NSN
int a = second;
int b = third;
long zaloha1 = a;
long zaloha2 = b;

// Pracujeme s a a b, zálohy neovlivníme
while(a != b)
{
    if(a > b)
        a = a - b;
    else
        b = b - a;
}

long NSD = a; // Po výpočtu NSD se a a b shodují
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
    }
}



    // Kosodélník, šířka: třetí největší číslo, výška: čtvrté největší
    int width = third;
    int height = fourth;

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < width; j++)
        {
            if (i == 0 || i == height - 1)
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

    int height1 = 2 * second; 
    int width1 = height - 2; 

    Console.WriteLine("\n\nPřesýpací hodiny:");
    for (int i = 0; i < height1; i++)
    {
        int spaces = i < height1 / 2 ? i : height1 - i - 1;

        for (int j = 0; j < spaces; j++)
        {
            Console.Write(" "); 
        }

        for (int j = 0; j < width1; j++)
        {
            if (i == 0 || i == height1 - 1)
            {
                Console.Write("* "); 
            }
            else if (j == 0 || j == width1 - 1)
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

    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}


















/*


//Faktoriál 5. největšího čísla

int faktorial = FaktorialPatehoNejvetsiho (pole);
Console.WriteLine ($"\n\nFaktoriál pátého největšího čísla: {faktorial}");

static int faktorial (int cislo){
    if (cislo==0){
        return 1;
    }
    int faktorial = 1;
    for (int i=1; i<=cislo; i++){
        faktorial *=i;
    }
    return faktorial;
}
static int FaktorialPatehoNejvetsiho (int []pole){
    if(pole.Length<5){
        return -1;
    }
    Array.Sort(pole);
    int pateNejvetsi = pole [pole.Length-5];
    return faktorial (pateNejvetsi);
}


 //Ciferný součet a součin:
    
   int zaloha1 = max;
    int zaloha2 = min;
    int suma = 0;
    int soucin = 1;
    int cifra;

    if(max<0)
        max = -1 * max;

    while(min>=10) {
        cifra = min % 10;
        min = (min - cifra)/10;
        suma = suma + cifra;
        soucin = soucin * cifra;
    }   
    suma = suma + max;
    soucin = soucin * min;

    Console.WriteLine("Součet cifer čísla {0} = {1}", zaloha1, suma);
    Console.WriteLine("Součin cifer čísla {0} = {1}", zaloha2, soucin); 



 //pravouhly
  
    for (int i =1;i<=n;i++)
    {
    for( int j=1; j<=i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    }

    
    //rovnoramenny prazdny

    for(int i =1; i<= n; i++)
    {
        for(int j =1; j<= n-i; j++) 
        {
            Console.Write(" ");
        } 
        for(int k =1; k<= 2*i-1; k++) 
        {
            if(i==1 || i ==n ||k==1||k==2*i-1)
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

    //posunutí obdelnik
    int posunutiVpravo = 4; 

for (int i = 1; i <= DruhyNejvetsi; i++)
{
    for (int k = 0; k < posunutiVpravo; k++) 
    {
        Console.Write(" ");
    }

    for (int j = 1; j <= TretiNevetsi; j++)
    {
        if ( j == 1 || j == TretiNevetsi)
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

    //strom
  for (int k = 1; k <= DruhyNejvetsi; k++)
{
    for (int i = 1; i <= k; i++)
    {
        for (int j = 1; j <= DruhyNejvetsi - i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i * 2 - 1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
 }

//obdélník
  int w = 5; //šířka obdélníku
   int h = 3; //výška obdélníku

   Console.WriteLine("\nobdelnik");
   for (int i = 0; i < h; i++)
   {
            string stars = new string('*', w);
            Console.WriteLine(stars);
        } 

    }


    Console.WriteLine("\n\n\nPro opakování programu stiskněte klávesu a");
    opakovani=Console.ReadLine(); 
}
*/