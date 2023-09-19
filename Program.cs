// Doe de begroeting
Console.WriteLine("****************************************************");
Console.WriteLine("Bereken de faculteit van een getal");
Console.WriteLine("****************************************************");

Console.WriteLine("Goeiedag. Van welk getal moet de faculteit berekend worden? ");
int getal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Met welk type iteratie moet de berekening gebeuren?");
Console.WriteLine("1. For loop");
Console.WriteLine("2. While loop");
Console.WriteLine("3. Do-While loop");
Console.WriteLine("4. Recursie");


Console.WriteLine("Geef jij  keuze");

char keuze = Console.ReadLine().First();

long nFaculteit = 1;
int i = 1;


switch (keuze)
{

    case '1':

    for (i = getal; i > 1; i--)
    {
        nFaculteit *= i;
        // nFaculteit = nFaculteit* index;
    }
    break;

    case '2':
        
    while (i <= getal)
    {
        nFaculteit *= i;
            i++;
    }
    break;


    case '3':


    do
    {
        nFaculteit *= i;
        i++;

    } while (i <= getal);
    break;

    case '4':

        nFaculteit = BerekenFaculteit(getal);


    break;

}

Console.WriteLine(getal + "!= " + nFaculteit);

int BerekenFaculteit (int getal)
{
    if (getal == 1) 
        return 1; 
        return getal * BerekenFaculteit(getal - 1);
    }





