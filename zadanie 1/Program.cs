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

            if (prikaz == "sum")
            {
                sum();
            }

            if (prikaz == "odm")
            {
                odm();
            }

            if (prikaz == "find")
            {
                find();
            }
            
            if (prikaz == "help")
            {
                help();
            }

            void sum()
            {
                Console.WriteLine("Napis cislo 1");
                int cislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Napis cislo 2");
                int cislo2 = Convert.ToInt32(Console.ReadLine());

                int vysledok = cislo1 + cislo2;
                Console.WriteLine($"Vysledok scitanie je {vysledok}");

            }
            
            void odm ()
            {
                Console.WriteLine("Napis cislo ");
                int cislo = Convert.ToInt32(Console.ReadLine());

                if (cislo < 0)
                {
                    Console.WriteLine("Zaporne cislo sa neda odmocnit");
                }

                else
                {
                    double vysledok = Math.Sqrt(cislo);
                    Console.WriteLine($"Odmocnina z cisla {cislo} je: {vysledok}");
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
                    Console.WriteLine($"Hladany podretazec sa vo vete nachadza na indexe {pozicia}.");

                }
                else
                {
                    Console.WriteLine($"Podreťazec '{slovo}' sa vo vete nenachádza.");
                }
            }
            void help()
            {
                    Console.WriteLine("Podporovane prikazy:");
                    Console.WriteLine("sum  - scitanie dvoch celych cisel");
                    Console.WriteLine("odm  - druha odmocnina zo zadaneho cisla");
                    Console.WriteLine("find - hladanie podretazca vo vete a výpis jeho pozicie");
                    Console.WriteLine("help - zobrazenie tohto zoznamu prikazov");
                    Console.WriteLine("exit - ukoncenie programu");
            }
        }
    }
}