using System.Text;

namespace Zadanie;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj swój tekst");
        string tekst = Console.ReadLine();
        Console.WriteLine("Liczba samogłosek w twoim tekscie: "+HowManyVowels(tekst));
        Console.WriteLine("Twój tekst bez powtórzeń: "+RepeatedCharacters(tekst));
    }

    static int HowManyVowels(string userTekst)
    {
        string vowels="aąeęiouóyAĄEĘIOUÓY";
        int meter = 0;

        for (int i = 0; i < userTekst.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (userTekst[i] == vowels[j])
                {
                    meter++;
                }
            }
        }
        
        return meter;        
    }

    static string RepeatedCharacters(string userTekst)
    {
        StringBuilder sb=new StringBuilder(userTekst);

        for (int i = 0; i < userTekst.Length-1; i++)
        {
            
            if (userTekst[i] == userTekst[i+1])
            {
                sb.Remove(i, 1);
            }
            
        }
        
        return sb.ToString();
        
    }

}