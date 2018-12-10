using System;

namespace nZahlenSortieren
{
[Author("A. Brockmeier", version = 1.1)]
	class Program
	{
		/* --< für die String ausgabe Methode aus der C# Dokumentation... mit kleinen Anpassungen:
		 * TODO: Methode selber schreiben!
		 * static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));
		 */
		static void DisplayArray(Int32[] arr) => Console.WriteLine(string.Join(" ", arr));
		
		static void Main(string[] args)
		{

			// --> Variablen
			string eingabe;
			int einAusgabe;
			int einAusgabeJ;
			int eingabeIsInt;// Sollte durch eine Kostante für den String j ersetzt werden... falls möglich!
			bool korrekteEingabe;
			bool korrekteEingabeVergleichJ;
			int anzahlElemente = 0;
			//  string zwischenSpeicher;			-->UNSUSED!
			//  bool endeDerEingabe = false;		-->UNSUSED!
			int[] eingabeArray;
			int i = 0;						  //-->NAMENSKONVENTIONEN...
			int x;							  //--> s.o.
			int xN;							  //--> s.o.
			
			// --> Eingabe (Abfrage der Größe des Arrays und der Elemente)
			
			while (anzahlElemente <= 0)
			{
				Console.WriteLine("Wie viele Zahlen möchten Sie eingeben:");
				eingabe = Console.ReadLine();
				Console.WriteLine("Anzahl: {0} \n", eingabe);
				// --> TODO: eine Methode daraus Basteln um nicht noch mehr Spagetti-Code prodozieren...
				korrekteEingabe = Int32.TryParse(eingabe, out anzahlElemente);

				if (anzahlElemente > 0 && korrekteEingabe)
				{
					Console.WriteLine("Der Array hat {0} Elemente.\n", anzahlElemente);
				}
				else
				{
					Console.Clear();
					Console.WriteLine("Bitte eine Zahl größer als 0 Eingeben!");
					eingabe = Console.ReadLine();
					Console.WriteLine("Anzahl: {0} \n", eingabe);
					korrekteEingabe = Int32.TryParse(eingabe, out anzahlElemente);

				}
				Console.WriteLine("Na fein... Sie haben die Anzahl von {0} Zahlen gewählt", eingabe);
				i = Convert.ToInt32(eingabe);
			}
		eingabeArray = new int[anzahlElemente];
		korrekteEingabe = true;
		for (x = 0; x <i; x++)
		{
			xN = x + 1;
			Console.WriteLine("Bitte {0}. Zahl eingeben:", xN);
			eingabe = Console.ReadLine();
			korrekteEingabe = int.TryParse(Convert.ToString(eingabe), out eingabeIsInt);
				while (korrekteEingabe == false)
				{
					Console.WriteLine("Bitte {0}. Zahl eingeben:", xN);
					Console.WriteLine("Bitte den Wertebereich von –2.147.483.648 bis 2.147.483.647 einhalten!");
					eingabe = Console.ReadLine();
					korrekteEingabe = int.TryParse(Convert.ToString(eingabe), out eingabeIsInt);
				}
			eingabeArray[x] = Convert.ToInt32(eingabe);

			// --> TODO: Fehlerhafte eingabe von Zahlen Abfangen... )
			
		}

		// -->  Ausgabe (Teil Eingegebene Zahlen)

		Console.WriteLine("Die Eingegebenen Zahlen lauten:");
		DisplayArray(eingabeArray);
		
		Console.WriteLine("Um den Eingegebenen Array vor dem Beenden aufsteigend " +
							"zu sortieren drücken sie bitte \"j\"!");
		Console.WriteLine("Alle anderen eingaben führen zum Beenden des " +
							"Programms!!! ;-) Vermeintlich... ");
		eingabe = Console.ReadLine();
		korrekteEingabe = Int32.TryParse(eingabe, out einAusgabe);
		korrekteEingabeVergleichJ = Int32.TryParse("j", out einAusgabeJ);
		
		// --> Verarbeitung

		if (korrekteEingabe == korrekteEingabeVergleichJ)
		{
			//TODO Sortierung selber implementieren... Gut´s Nächtle!	
			Array.Sort(eingabeArray); 
		
			// -->  Ausgabe (Teil sortierte Zahlen)

			// hier in diesem Fall zur Ausgabe verwendet, da "umsortiert" ;-) 
			DisplayArray(eingabeArray);    
			Console.WriteLine("fertig...");
		}
		else
			Console.WriteLine("Vielen Dank und bis später...");
		Console.ReadKey();
		}
	}
	
	// --< Code zum Erstellen von Benutzerdefinierten Attributen. Quelle: C#DOCS...

	public class Author : System.Attribute  
{  
    private string name;  
    public double version;  
  
    public Author(string name)  
    {  
        this.name = name;  
        version = 1.0;  
    }  
}  

}