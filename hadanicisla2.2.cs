using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace prokekt
{

    public class Program 
    {
        public static void Main()
        {
        	blbec:;
        	try{
			neuhodd:;
			int pokusy = 0;
			Random nahoda = new Random();
			int cisloznahody = Convert.ToInt32(nahoda.Next(1,10));
            Console.WriteLine("Myslím si celé číslo od 1 do 10. Máš 7 pokusů. Hádej.");
            b:;
            string easter1 = Console.ReadLine();
            if (easter1 == "easteregg"){Console.Clear();Console.WriteLine("Easter egg schován na"); Console.WriteLine("bit.ly/slavkuveasterhadanicisla1");Console.ReadLine();}
            else{goto nic1;}
            nic1:;
            int hadani = Convert.ToInt32(easter1);
            if(hadani == cisloznahody)
            {
        		Console.WriteLine("");
        		Console.WriteLine("BLAHOPŘEJI!!! UHODL/A JSI! Pro težší hádání stiskni enter.");
        		Console.ReadLine();
        		Console.Clear();
            	goto tezsi;
            }
            else if(hadani > cisloznahody)
            {
            	pokusy += 1;
            	Console.WriteLine("");
            	Console.WriteLine("Neuhodl/a jsi. Moje číslo je menší.");
            	if(pokusy > 6)
            	{
            		goto neuhod;
            	}
            	else
            	{
            		goto a;
            	}
            }
            else if(hadani < cisloznahody)
        	{
            	pokusy += 1;
            	Console.WriteLine("");
            	Console.WriteLine("Neuhodl/a jsi. Moje číslo je větší.");
            	if(pokusy > 6)
            	{
            		goto neuhod;
            	}
            	else
            	{
            		goto a;
            	}
            }
            
            neuhod:;
            Console.WriteLine("Škoda. Už jsi hádal/a 7x. Stiskni enter a vygeneruji nové číslo.");
            Console.ReadLine();
            pokusy = 0;
            Console.Clear();
            goto neuhodd;
            
            a:;
            Console.WriteLine("Znovu si myslím to samé číslo. Piš.");
            goto b;
            
            tezsi:;
        	neuhodd2:;
        	int pokusy2 = 0;
        	pokusy2 = 0;
        	Console.WriteLine("");
        	Console.WriteLine("2. kolo. Teď si myslím číslo od 1 do 20 a máš jen 5 pokusů.");
        	int kolo2nahoda = Convert.ToInt32(nahoda.Next(1,20));
        	b2:;
        	int hadani2 = Convert.ToInt32(Console.ReadLine());

            if(hadani2 == kolo2nahoda)

            {
        		Console.WriteLine("");
        		Console.WriteLine("BLAHOPŘEJI!!! UHODL/A JSI I 2. KOLO!!! Ale 3. nedáš!");
        		Console.ReadLine();
        		Console.Clear();
        		goto nejtezsi;
            }
            else if(hadani2 > kolo2nahoda)
            {
            	pokusy2 += 1;
            	Console.WriteLine("");
            	Console.WriteLine("Neuhodl/a jsi. Moje číslo je menší.");
            	if(pokusy2 > 4)
            	{
            		goto neuhod2;
            	}
            	else
            	{
            		goto a2;
            	}
            }
            else if(hadani2 < kolo2nahoda)
        	{
            	pokusy += 1;
            	Console.WriteLine("");
            	Console.WriteLine("Neuhodl/a jsi. Moje číslo je větší.");
            	if(pokusy > 4)
            	{
            		goto neuhod2;
            	}
            	else
            	{
            		goto a2;
            	}
            }
            
            neuhod2:;
            Console.WriteLine("Škoda. Už jsi hádal/a 5x. Stiskni enter a vygeneruji nové číslo.");
            Console.ReadLine();
            pokusy = 0;
            Console.Clear();
            goto neuhodd2;
            
            a2:;
            Console.WriteLine("Znovu si myslím to samé číslo. Piš.");
            goto b2;
            
            
            nejtezsi:;
        	neuhodd3:;
        	int pokusy3 = 0;
        	pokusy3 = 0;
        	Console.WriteLine("");
        	Console.WriteLine("Dostal/a jsi se i do 3. kola. Teď si myslím číslo od 1 do 20 a máš jen 3 pokusy. To nedáš...");
        	int kolo3nahoda = Convert.ToInt32(nahoda.Next(1,20));
        	b3:;
        	int hadani3 = Convert.ToInt32(Console.ReadLine());

            if(hadani3 == kolo3nahoda)

            {
        		Console.WriteLine("");
        		Console.WriteLine("BLAHOPŘEJI!!! UHODL/A JSI I 3. KOLO!!!  a to jsem ti nevěřil.... :'(");
        		Console.ReadLine();
            }
            else if(hadani3 > kolo3nahoda)
            {
            	pokusy3 += 1;
            	Console.WriteLine("");
            	Console.WriteLine("Neuhodl/a jsi. Moje číslo je menší.");
            	if(pokusy3 > 3)
            	{
            		goto neuhod3;
            	}
            	else
            	{
            		goto a3;
            	}
            }
            else if(hadani3 < kolo3nahoda)
        	{
            	pokusy += 1;
            	Console.WriteLine("");
            	Console.WriteLine("Neuhodl/a jsi. Moje číslo je větší.");
            	if(pokusy > 3)
            	{
            		goto neuhod3;
            	}
            	else
            	{
            		goto a3;
            	}
            }
            
            neuhod3:;
            Console.WriteLine("Škoda. Už jsi hádal/a 3x. Stiskni enter a vygeneruji nové číslo.");
            Console.ReadLine();
            pokusy = 0;
            Console.Clear();
            goto neuhodd3;
            
            a3:;
            Console.WriteLine("Znovu si myslím to samé číslo. Piš.");
            goto b3;
        	}
        	catch{Console.WriteLine("Debile. Zmáčkni ENTER."); goto blbec;}
        }
    }
}
