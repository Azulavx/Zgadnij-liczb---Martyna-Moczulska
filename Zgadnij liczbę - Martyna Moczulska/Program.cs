// See https://aka.ms/new-console-template for more information
Random r = new Random();
int liczba = r.Next(1, 10);
int liczba2;
Console.WriteLine("Konsola wylosowała liczbę od 1-10");
Console.WriteLine("Zgadnij jaka to liczba");
liczba2 = Convert.ToInt32(Console.ReadLine());
while (liczba2 != liczba) 
{
    if (liczba2 > liczba)
    {
        Console.WriteLine("Niestety liczba którą próbowałeś zgadnąć jest mniejsza niż wylosowana!");
        Console.WriteLine("Spróbuj ponownie!");
        liczba2 = Convert.ToInt32(Console.ReadLine());
    }
    else
    if (liczba2 < liczba)
    {
        Console.WriteLine("Niestety liczba którą próbowałeś zgadnąć jest większa niż wylosowana!");
        Console.WriteLine("Spróbuj ponownie!");
        liczba2 = Convert.ToInt32(Console.ReadLine());
    }
}
if (liczba2 == liczba)
{
    Console.WriteLine("Brawo udało ci się!!");
    Console.WriteLine("Wylosowana liczba to " + liczba);
}