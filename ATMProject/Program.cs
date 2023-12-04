using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        Console.Write("Çekmek istediğiniz tutarı girin: ");
        int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, int> banknotlar = CalculateBanknote(cekilecekTutar);

        Console.WriteLine("Çekilen banknotlar:");
        if (banknotlar.Count > 0)
        {
            string outputMessage = string.Empty;
            foreach (var banknot in banknotlar)
            {
                outputMessage += $"{banknot.Value} adet {banknot.Key} TL.\n";
                
            }
            Console.WriteLine(outputMessage);
            Console.ReadLine();
        }
        
    }

    static Dictionary<int, int> CalculateBanknote(int tutar)
    {
        int[] banknotlar = { 200, 100, 50, 20, 10, 5};
        Dictionary<int, int> cekilenBanknotlar = new Dictionary<int, int>();

        foreach (var banknot in banknotlar)
        {
            if (tutar >= banknot)
            {
                int adet = tutar / banknot;
                tutar %= banknot;
                cekilenBanknotlar.Add(banknot, adet);
            }
        }

        return cekilenBanknotlar;
    }
}