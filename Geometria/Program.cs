using Geometria;


Console.WriteLine("Inserisci la base del rettangolo: ");
int baseUtente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo: ");
int altezzaUtente = int.Parse(Console.ReadLine());

Rettangolo rettangolo1 = new Rettangolo(baseUtente, altezzaUtente);

//------ RETTANGOLO 1 ------
rettangolo1.stampareRettangoloInConsole();



Console.WriteLine();

Console.WriteLine("Inserisci la base del rettangolo; ");
baseUtente = int.Parse(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del rettangolo: ");
altezzaUtente = int.Parse(Console.ReadLine());

Rettangolo rettangolo2 = new Rettangolo(baseUtente, altezzaUtente);

//------ RETTANGOLO 2 ------
rettangolo2.stampareRettangoloInConsole();




