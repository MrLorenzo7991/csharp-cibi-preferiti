//array cibi preferiti
string[] cibiPreferiti = {"Lasagne", "Pizza", "Carne alla brace", "Biscotti", "Fagioli", "Ravioli cinesi"};

//Lunghezza classifica
double lunghezza = cibiPreferiti.Length;
Console.WriteLine("La lunghezza della classifica è di " + lunghezza + " cibi.");

//Stampa classifica
Console.WriteLine("I cibi presenti nella lista sono: ");
for(int i = 0; i < lunghezza; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

//Cibo top
Console.WriteLine("Il cibo primo in classifica è: " + cibiPreferiti[0]);

//Cibo ultimo
Console.WriteLine("Il cibo ultimo in classifica è: " + cibiPreferiti[(int)(lunghezza - 1)]);

//cibo di mezza classifica
if(cibiPreferiti.Length % 2 != 0)
{   //caso numero di elementi dispari
    Console.WriteLine("Il cibo di mezza classifica è: " + cibiPreferiti[(int)(Math.Floor(lunghezza / 2))]);
}
else 
{   //caso numero di elementi pari
    Console.WriteLine("I cibi di metà classifica sono: " + cibiPreferiti[(int) (lunghezza / 2 - 1)] + " e " + cibiPreferiti[(int) lunghezza / 2]);
}