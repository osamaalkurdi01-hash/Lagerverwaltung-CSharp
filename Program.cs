namespace Lagerverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produkt> produkte = new List<Produkt>();


            while (true)
            {
                Console.Clear();


                Console.WriteLine("==========================");
                Console.WriteLine("     LAGERVERWALTUNG");
                Console.WriteLine("==========================");

                Console.WriteLine("1. Produkt hinzufügen");
                Console.WriteLine("2. Produkte anzeigen");
                Console.WriteLine("3. Produkt suchen");
                Console.WriteLine("4. Bestand ändern");
                Console.WriteLine("5. Produkt löschen");
                Console.WriteLine("6. Programm beenden");

                Console.WriteLine("==========================");

                Console.Write("Bitte wähle eine Option: ");
                

                string eingabe = Console.ReadLine() ?? "";

               



                /* if (eingabe == "1")
                 {
                     Console.WriteLine("Produkt hinzufügen wurde ausgewählt.");
                 }
                 else if (eingabe == "2")
                 {
                     Console.WriteLine("Produkte anzeigen wurde ausgewählt.");
                 }
                 else if (eingabe == "3")
                 {
                     Console.WriteLine("Produkt suchen wurde ausgewählt.");
                 }
                 else if (eingabe == "4")
                 {
                     Console.WriteLine("Bestand ändern wurde ausgewählt.");
                 }
                 else if (eingabe == "5")
                 {
                     Console.WriteLine("Programm wird beendet.");
                 }
                 else
                 {
                     Console.WriteLine("Ungültige Auswahl!");
                 }      
                            ( einfache Form )         */



                switch (eingabe)
                {
                    case "1":
                        {
                            Produkt neuesProdukt = new Produkt();
                            Console.WriteLine();
                            Console.Write("Produktname: ");
                            neuesProdukt.Name = Console.ReadLine() ?? "";


                            int bestand;

                            while (true)
                            {
                                Console.Write("Bestand: ");
                                string eingabeBestand = Console.ReadLine() ?? "";

                                if (int.TryParse(eingabeBestand, out bestand))
                                {
                                    break;
                                }

                                Console.WriteLine("Bitte gib eine gültige ganze Zahl ein!");
                            }

                            neuesProdukt.Bestand = bestand;

                            produkte.Add(neuesProdukt);

                            Console.WriteLine();
                            Console.WriteLine("Produkt wurde hinzugefügt !");

                            break;
                        }


                    case "2":

                        {
                            Console.WriteLine("Deine Produkte:");
                            Console.WriteLine();

                            Console.WriteLine("{0,-25} {1,10}", "Produkt", "Bestand");
                            Console.WriteLine("----------------------------------------");

                            foreach (Produkt produkt in produkte)
                            {
                                Console.WriteLine("{0,-25} {1,10}", produkt.Name, produkt.Bestand);
                            }

                            break;
                        }




                    case "3":

                        {

                            Console.Write("Welches Produkt möchtest du suchen? ");
                            string suche = Console.ReadLine() ?? "";

                            bool gefunden = false;

                            foreach (Produkt produkt in produkte)
                            {
                                if (produkt.Name == suche)
                                {
                                    gefunden = true;
                                }
                            }

                            if (gefunden)
                            {
                                Console.WriteLine("Produkt wurde gefunden!");
                            }
                            else
                            {
                                Console.WriteLine("Produkt wurde nicht gefunden!");
                            }

                            break;
                        }



                    case "4":

                        {
                            Console.WriteLine();
                            Console.Write("Welches Produkt möchtest du ändern? ");
                            string sucheBestand = Console.ReadLine() ?? "";

                            bool bestandGefunden = false;

                            foreach (Produkt produkt in produkte)
                            {
                                if (produkt.Name == sucheBestand)
                                {
                                    int neuerBestand;

                                    while (true)
                                    {
                                        Console.Write("Neuer Bestand: ");
                                        string eingabeNeuerBestand = Console.ReadLine() ?? "";

                                        if (int.TryParse(eingabeNeuerBestand, out neuerBestand))
                                        {
                                            break;
                                        }

                                        Console.WriteLine("Bitte gib eine gültige ganze Zahl ein!");
                                    }

                                    produkt.Bestand = neuerBestand;

                                    Console.WriteLine("Bestand wurde aktualisiert!");
                                    bestandGefunden = true;
                                    break;
                                }
                            }

                            if (!bestandGefunden)
                            {
                                Console.WriteLine("Produkt wurde nicht gefunden!");
                            }

                            break;

                        }


                    case "5":


                        {
                            Console.Write("Welches Produkt möchtest du löschen? ");
                            string produktZumLoeschen = Console.ReadLine() ?? "";

                            bool produktGefunden = false;

                            foreach (Produkt produkt in produkte)
                            {
                                if (produkt.Name == produktZumLoeschen)
                                {
                                    produktGefunden = true;
                                    break;
                                }
                            }


                            if (produktGefunden)
                            {
                                produkte.RemoveAll(p => p.Name == produktZumLoeschen);
                                Console.WriteLine("Produkt wurde erfolgreich gelöscht!");
                            }
                            else
                            {
                                Console.WriteLine("Produkt wurde nicht gefunden!");
                            }

                            break;
                        }


                    case "6":

                        {
                            Console.WriteLine("Programm beenden");
                            return;
                        }
                        

                    default:
                        Console.WriteLine("Ungültige Auswahl!");
                        break;

                }


                Console.WriteLine();
                Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();


                


            }





        }
    }
}
