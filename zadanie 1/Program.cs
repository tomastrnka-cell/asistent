namespace zadanie_1;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Napis prikaz ");
            string prikaz = Console.ReadLine();

            if (prikaz == "exit")
            {
                Console.WriteLine("Asistent ukonceny");
                break;
            }
            else if (prikaz == "sum")
            {
                sum();
            }
            else if (prikaz == "odm")
            {
                odm();
            }
            else if (prikaz == "find")
            {
                find();
            }
            else if (prikaz == "help")
            {
                help();
            }
            else if (prikaz == "rect")
            {
                Console.WriteLine("Zadaj prvu stranu obdlznika:");
                double stranaA = double.Parse(Console.ReadLine());

                Console.WriteLine("Zadaj druhu stranu obdlznika:");
                double stranaB = double.Parse(Console.ReadLine());

                if (stranaA <= 0)
                {
                    Console.WriteLine("Strana obdlznika musi byt vacsia ako nula");
                    continue;
                }

                if (stranaB <= 0)
                {
                    Console.WriteLine("Strana obdlznika musi byt vacsia ako nula");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Co chces vypocitat area perimeter diagonal alebo exit:");
                    string operacia = Console.ReadLine();

                    if (operacia == "area")
                    {
                        Console.WriteLine("Obsah obdlznika je " + Area(stranaA, stranaB));
                    }
                    else if (operacia == "perimeter")
                    {
                        Console.WriteLine("Obvod obdlznika je " + Perimeter(stranaA, stranaB));
                    }
                    else if (operacia == "diagonal")
                    {
                        Console.WriteLine("Uhlopriecka obdlznika je " + Diagonal(stranaA, stranaB));
                    }
                    else if (operacia == "exit")
                    {
                        Console.WriteLine("Mod prace s obdlznikom bol ukonceny.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Neznamy prikaz.");
                    }
                }
            }
            else if (prikaz == "array")
            {
                VykonajArray();
            }
            else
            {
                Console.WriteLine("Neznamy prikaz napis help");
            }

            void sum()
            {
                Console.WriteLine("Napis cislo 1");
                int cislo1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Napis cislo 2");
                int cislo2 = int.Parse(Console.ReadLine());

                int vysledok = cislo1 + cislo2;
                Console.WriteLine("Vysledok scitanie je " + vysledok);
            }

            void odm()
            {
                Console.WriteLine("Napis cislo ");
                int cislo = int.Parse(Console.ReadLine());

                if (cislo < 0)
                {
                    Console.WriteLine("Zaporne cislo sa neda odmocnit");
                }
                else
                {
                    double vysledok = Math.Sqrt(cislo);
                    Console.WriteLine("Odmocnina z cisla " + cislo + " je:" + vysledok);
                }
            }

            void find()
            {
                Console.WriteLine("Napis vetu");
                string veta = Console.ReadLine();

                Console.WriteLine("Napis ake slovo chces najst");
                string slovo = Console.ReadLine();

                int pozicia = veta.IndexOf(slovo);

                if (pozicia != -1)
                {
                    Console.WriteLine("Hladany podretazec sa vo vete nachadza na indexe " + pozicia);
                }
                else
                {
                    Console.WriteLine("Podreťazec " + slovo + " sa vo vete nenachádza.");
                }
            }

            void help()
            {
                Console.WriteLine("Podporovane prikazy:");
                Console.WriteLine("sum  - scitanie dvoch celych cisel");
                Console.WriteLine("odm  - druha odmocnina zo zadaneho cisla");
                Console.WriteLine("find - hladanie podretazca vo vete a vypis jeho indexu");
                Console.WriteLine("rect - odmera obdlznik");
                Console.WriteLine("array - praca s ciselym polom");
                Console.WriteLine("help - zobrazenie tohto zoznamu prikazov");
                Console.WriteLine("exit - ukoncenie programu");
            }

            double Area(double a, double b)
            {
                return a * b;
            }

            double Perimeter(double a, double b)
            {
                return 2 * (a + b);
            }

            double Diagonal(double a, double b)
            {
                return Math.Sqrt(a * a + b * b);
            }
        }
    }

    static void VykonajArray()
    {
        Console.WriteLine("Zadaj ciselne pole prosim oddel cisla medzerou:");
        Console.Write("> ");
        string vstup = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(vstup))
        {
            Console.WriteLine("Zadal si prazdne pole.");
            return;
        }

        string[] casti = vstup.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        int[] pole = new int[casti.Length];

        for (int i = 0; i < casti.Length; i++)
        {
            if (!int.TryParse(casti[i], out pole[i]))
            {
                Console.WriteLine("Chyba: " + casti[i] + "' nie je platne cele cislo.");
                return;
            }
        }

        while (true)
        {
            Console.Write("Co chces urobit find min sort alebo exit:");
            string prikaz = Console.ReadLine();

            if (prikaz == "exit")
            {
                Console.WriteLine("Mod prace s polom bol ukonceny.");
                break;
            }
            
            else if (prikaz == "find")
            {
                Console.Write("Ake cislo chces najst ");
                string textHladanecislo = Console.ReadLine();

                if (int.TryParse(textHladanecislo, out int hladaneCislo))
                {
                    NajdiVPoli(pole, hladaneCislo);
                }
                else
                {
                    Console.WriteLine("Neplatne cislo");
                }
            }
            
            else if (prikaz == "min")
            {
                int minHodnota = NajdiMin(pole);
                Console.WriteLine("Najmensia hodnota v poli je: " + minHodnota);
            }
            
            else if (prikaz == "sort")
            {
                ZoradPole(pole);
                string zoznamPola = string.Join(" ", pole);
                Console.WriteLine("Zoradil som pre teba pole. Teraz vypada takto: " + zoznamPola);
            }

            else
            {
                Console.WriteLine("Neznami prikaz napis find min sort alebo exit");
            }
        }
    }

    static void NajdiVPoli(int[] pole, int cislo)
    {
        int index = -1;

        for (int i = 0; i < pole.Length; i++)
        {
            if (pole[i] == cislo)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            int pozicia = index + 1;
            Console.WriteLine("Hodnota " + cislo + " sa v poli nachadza na pozicii " + pozicia + ".");
        }
        else
        {
            Console.WriteLine("Hodnota " + cislo + " sa v poli nenachadza.");
        }
    }

    static int NajdiMin(int[] pole)
    {
        int min = pole[0];

        for (int i = 1; i < pole.Length; i++)
        {
            if (pole[i] < min)
            {
                min = pole[i];
            }
        }

        return min;
    }

    static void ZoradPole(int[] pole)
    {
        Array.Sort(pole);
    }
}
