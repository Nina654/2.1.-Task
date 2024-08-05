

using System;

public class Program
{
    public static void Main()
    {
        int[] seznam = new int[10];

        Console.WriteLine("Vnesi 10 števil");

for (int i = 0; i < seznam.Length; i++)
            
try     
{
    Console.Write( i+1 + ". Število: ");
    seznam[i] = Convert.ToInt32(Console.ReadLine());

}
catch (Exception) 
{ 
    Console.WriteLine("Prosim vpišite število, drugi znaki niso dovoljeni!"); 
                i--;
}

        
            Console.WriteLine("Seznam števil:");
        foreach (int stevila in seznam)
        {
            Console.WriteLine(stevila);
        }

        Console.WriteLine("Seznam sodih števil:");
        foreach (int stevila in seznam)
        {

            if (stevila % 2 == 0)
                Console.WriteLine(stevila);

        }

        Console.WriteLine("Seznam lihih števil:");
        foreach (int stevila in seznam)
        {
            if (stevila % 2 != 0)
                Console.WriteLine(stevila);
        }


        Console.WriteLine("Seznam števil od najmanjšega do največjega:");
        Array.Sort(seznam);
        foreach (int i in seznam)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine("Največje število: " + seznam.Max());
        Console.WriteLine("Najmanjše število: " + seznam.Min());    


    }
}
