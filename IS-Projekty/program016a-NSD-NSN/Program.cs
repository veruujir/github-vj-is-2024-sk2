string again = "a";
while(again == "a") {
    Console.Clear();
    razitko();
    ulong a = nacistCislo("Zadejte číslo a: ");
    ulong b = nacistCislo("Zadejte číslo b: ");
    
    ulong nsd = vypocitatNsd(a, b);
    ulong nsn = vypocitatNsn(a, b, nsd);
    
    zobrazitVysledky(a, b, nsd, nsn);

    Console.WriteLine("\n\nPro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}

static void razitko() {
    Console.WriteLine("********************************");
    Console.WriteLine("********** NSD a NSN ***********");
    Console.WriteLine("********************************");
    Console.WriteLine("****** Veronika Jirásková ******");
    Console.WriteLine("****************************\n\n");
    Console.WriteLine();
}

static ulong nacistCislo(string zprava) {
    Console.Write(zprava);
    ulong cislo;
    while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
        Console.Write("Nebylo zadáno přirozené číslo!!! Zadejte znovu: ");
    }    
    return cislo;
}

static ulong vypocitatNsd(ulong a, ulong b) {
    while(a != b) {
        if(a > b){
            a = a - b;
        }else{
            b = b - a;     
        }}
    return a;
}

static ulong vypocitatNsn(ulong a, ulong b, ulong nsd) {
    return (a*b)/nsd;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n\nNSD čísel {0} a {1} je {2}", a, b, nsd);
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\nNSN čísel {a} a {b} je {nsn}");
    Console.ForegroundColor = ConsoleColor.White;
}