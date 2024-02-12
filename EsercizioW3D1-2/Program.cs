namespace EsercizioW3D1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool continua = true;


            while (continua) {
                Console.WriteLine("");
                Console.WriteLine("==============MENU===============");
                Console.WriteLine("1:  Coca Cola 150 ml (€ 2.50)");
                Console.WriteLine("2:  Insalata di pollo (€ 5.20)");
                Console.WriteLine("3:  Pizza Margherita (€ 10.00)");
                Console.WriteLine("4:  Pizza 4 Formaggi (€ 12.50)");
                Console.WriteLine("5:  Pz patatine fritte (€ 3.50)");
                Console.WriteLine("6:  Insalata di riso (€ 8.00)");
                Console.WriteLine("7:  Frutta di stagione (€ 5.00)");
                Console.WriteLine("8:  Pizza fritta (€ 6.80)");
                Console.WriteLine("9:  Piadina vegetariana (€ 6.00)");
                Console.WriteLine("10: Panino Hamburger (€ 7.90)");
                Console.WriteLine("11: Stampa conto finale e conferma");
                Console.WriteLine("==============MENU===============");

                Console.WriteLine("Scegli un'opzione (1-11) o premi 'q' per uscire:");

                string scelta = Console.ReadLine();

                switch (scelta)
                {
                    case "1":
                        Console.Clear();
                        Menu m = new Menu("CoCa Cola", (decimal)2.50);
                        Menu.Piatto.Add(m);
                        Console.WriteLine($"{m.NomePiatto} aggiunto al Menu");
                        break;
                    case "2":
                        Console.Clear();
                        Menu m1 = new Menu("Insalata di Pollo", (decimal)5.20);
                        Menu.Piatto.Add(m1);
                        Console.WriteLine($"{m1.NomePiatto} aggiunto al Menu");
                        break;
                    case "3":
                        Console.Clear();
                        Menu m2 = new Menu("Pizza Margherita", (decimal)10.00);
                        Menu.Piatto.Add(m2);
                        Console.WriteLine($"{m2.NomePiatto} aggiunto al Menu");
                        break;
                    case "4":
                        Console.Clear();
                        Menu m3 = new Menu("Pizza 4 Formaggi", (decimal)12.50);
                        Menu.Piatto.Add(m3);
                        Console.WriteLine($"{m3.NomePiatto} aggiunto al Menu");
                        break;
                    case "5":
                        Console.Clear();
                        Menu m4 = new Menu("Pz patatine fritte", (decimal)3.50);
                        Menu.Piatto.Add(m4);
                        Console.WriteLine($"{m4.NomePiatto} aggiunto al Menu");
                        break;
                    case "6":
                        Console.Clear();
                        Menu m5 = new Menu("Insalata di riso", (decimal)8.00);
                        Menu.Piatto.Add(m5);
                        Console.WriteLine($"{m5.NomePiatto} aggiunto al Menu");
                        break;
                    case "7":
                        Console.Clear();
                        Menu m6 = new Menu("Frutta di stagione", (decimal)5.00);
                        Menu.Piatto.Add(m6);
                        Console.WriteLine($"{m6.NomePiatto} aggiunto al Menu");
                        break;
                    case "8":
                        Console.Clear();
                        Menu m7 = new Menu("Pizza Fritta", (decimal)6.80);
                        Menu.Piatto.Add(m7);
                        Console.WriteLine($"{m7.NomePiatto} aggiunto al Menu");
                        break;
                    case "9":
                        Console.Clear();
                        Menu m8 = new Menu("Piadina Vegetariana", (decimal)6.00);
                        Menu.Piatto.Add(m8);
                        Console.WriteLine($"{m8.NomePiatto} aggiunto al Menu");
                        break;
                    case "10":
                        Console.Clear();
                        Menu m9 = new Menu("Panino Hamburger", (decimal)7.90);
                        Menu.Piatto.Add(m9);
                        Console.WriteLine($"{m9.NomePiatto} aggiunto al Menu");
                        break;
                    case "11":
                        Menu.MostraOrdini();
                        continua = false;
                        break;
                }
            }  
        }
    }


    public class Menu
    {
        private string _name;
        private decimal _costo;

        private static List<Menu> _piatto = new List<Menu>();

        public string NomePiatto
        {
            get { return  _name; }
            set { _name = value; }
        }
        public decimal Costo
        {
            get { return _costo; } 
            set { _costo = value; }
        }
        public static List<Menu> Piatto
        {
            get
            {
                return _piatto;
            }
            set
            {
                _piatto = value;
            }
        }

        public Menu (string nome , decimal costo)
        {
            this._name = nome;
            this._costo = costo;
        }

        public static void MostraOrdini()
        {
            decimal totale = 0;
            decimal coperto = 3;

            Console.WriteLine("L'ordine è :");

            for (int i = 0; i < _piatto.Count; i++)
            {
                
                Console.WriteLine($"- {_piatto[i].NomePiatto}, Costo: {_piatto[i].Costo} €");

                totale += _piatto[i].Costo;
            }

            Console.WriteLine($"Il totale dell'ordine è {totale} € a cui verranno aggiunti {coperto} € di coperto, per un totale di {totale + coperto}€");
        }
    }
}
