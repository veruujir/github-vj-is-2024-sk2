using System;

class Program
{
    static void Main()
    {
        string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("*********************************************");
            Console.WriteLine("******* Třídicí algoritmy *******");
            Console.WriteLine("*********************************************");
            Console.WriteLine("************* Veronika Jirásková **************");
            Console.WriteLine("*********************************************\n\n");

            // Uživatelský vstup
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

            Console.WriteLine("\n\n=================================================");
            Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, dm, hm);
            Console.WriteLine("=================================================\n\n");

            // Generování náhodných čísel
            int[] myArray = new int[n];
            Random random = new Random();
            Console.WriteLine("Generovaná čísla: ");
            for (int i = 0; i < n; i++)
            {
                myArray[i] = random.Next(dm, hm + 1);
                Console.Write("{0}; ", myArray[i]);
            }

            Console.WriteLine("\n\n=================================================");

            // Bubble Sort
            int[] bubbleArray = (int[])myArray.Clone();
            int bubbleCompare = 0, bubbleSwap = 0;
            for (int i = 0; i < bubbleArray.Length - 1; i++)
            {
                for (int j = 0; j < bubbleArray.Length - i - 1; j++)
                {
                    bubbleCompare++;
                    if (bubbleArray[j] > bubbleArray[j + 1])
                    {
                        int temp = bubbleArray[j];
                        bubbleArray[j] = bubbleArray[j + 1];
                        bubbleArray[j + 1] = temp;
                        bubbleSwap++;
                    }
                }
            }
            Console.WriteLine("\nBubble Sort: ");
            Console.WriteLine(string.Join("; ", bubbleArray));
            Console.WriteLine("Porovnání: {0}, Výměny: {1}", bubbleCompare, bubbleSwap);

            // Selection Sort
            int[] selectionArray = (int[])myArray.Clone();
            int selectionCompare = 0, selectionSwap = 0;
            for (int i = 0; i < selectionArray.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < selectionArray.Length; j++)
                {
                    selectionCompare++;
                    if (selectionArray[j] > selectionArray[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int tmp = selectionArray[i];
                selectionArray[i] = selectionArray[maxIndex];
                selectionArray[maxIndex] = tmp;
                selectionSwap++;
            }
            Console.WriteLine("\nSelection Sort: ");
            Console.WriteLine(string.Join("; ", selectionArray));
            Console.WriteLine("Porovnání: {0}, Výměny: {1}", selectionCompare, selectionSwap);

            // Insertion Sort
            int[] insertionArray = (int[])myArray.Clone();
            int insertionCompare = 0, insertionSwap = 0;
            for (int i = 1; i < insertionArray.Length; i++)
            {
                int key = insertionArray[i];
                int j = i - 1;
                while (j >= 0 && insertionArray[j] > key)
                {
                    insertionCompare++;
                    insertionArray[j + 1] = insertionArray[j];
                    j--;
                    insertionSwap++;
                }
                insertionArray[j + 1] = key;
            }
            Console.WriteLine("\nInsertion Sort: ");
            Console.WriteLine(string.Join("; ", insertionArray));
            Console.WriteLine("Porovnání: {0}, Výměny: {1}", insertionCompare, insertionSwap);

            // Shaker Sort
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

            // Opakování programu
            Console.WriteLine("\nPro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
