//array cibi preferiti
string[] cibiPreferiti = {"Lasagne", "Pizza", "Carne alla brace", "Biscotti", "Fagioli", "Ravioli cinesi", "Tiramisù"};

//Lunghezza classifica
Console.WriteLine("La lunghezza della classifica è di " + cibiPreferiti.Length + " cibi.");

//Stampa classifica
Console.WriteLine("I cibi presenti nella lista sono: ");
for(int i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

//Cibo top
Console.WriteLine("Il cibo primo in classifica è: " + cibiPreferiti[0]);

//Cibo ultimo
Console.WriteLine("Il cibo ultimo in classifica è: " + cibiPreferiti[cibiPreferiti.Length - 1]);
