using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

public class Programa {
    
    public static void Main()
    {
       //starting now 20:29PM fuso Brasilia 21/04/2026

        string[] Items = new string[6] {"sword","truco","shield","glob-glubs","HP-potion","grimorie"};
        ShowItems(Items);

    
    }
    public static void ShowItems(string[] items){
        

        Console.WriteLine("Do you want to checkout your number of items ? S/N");
        string ReceiveInput = Console.ReadLine().ToLower();
        string ShotInput = ReceiveInput;
        
        if (ShotInput != "n" || ShotInput != "s"){
            bool VerifyShotInput = false;
            while (!VerifyShotInput)
            {
               
                if (ShotInput == "s" || ShotInput == "n"){
                    VerifyShotInput = true;
                    } 
                else
                {
                    Console.WriteLine("System out error, you just can type s or n lower or upper case. try again!");
                    ShotInput = Console.ReadLine().ToLower();
                }
            }
            
        }

        if (ShotInput == "s")
        {

            Console.WriteLine(items.Length);

        }



        for (int index = 0; index < items.Length - 1;index++)
        {
            Console.WriteLine($"Item {index} => {items[index]}");
        }
        





    }
}// YEAAAAAAAAAAAAAAH I DID IT, 21:32PM

  