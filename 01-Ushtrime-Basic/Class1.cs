using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Ushtrime_Basic
{
    static class Ushtrimet
    {
        public static void LLotaria()
        {
            Console.WriteLine("Mire se vini te llotaria");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ju lutem tregoni numrin tuaj me fat?");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum == 0)
            {
                Console.WriteLine("Keni fituar nje TV");
            }
            else if (userNum == 1)
            {
                Console.WriteLine("Keni fituar nje PC");

            }
            else if (userNum == 2)
            {
                Console.WriteLine("keni fituar nje llaptop");
            }
            else
            {
                Console.WriteLine("Fate për hera tjera.");
            }
        }
        public static void Krahaso() {
            decimal num1 = 0;
                decimal num2 = 0;
            Console.WriteLine("Krahaso dy numra");
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine();

            bool validInput = false;

            while (!validInput)
            {
            Console.Write("Jep numrin e pare: ");
                if (decimal.TryParse(Console.ReadLine(), out num1))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Ju lutem mundohuni te shenoni nje numer te plot, ose decimal per numrin 1: ");
                }
            }
            validInput = false;
            Console.Write( "Jep numrin e dyte: ");
            while (!validInput)
            {
                if (decimal.TryParse(Console.ReadLine(), out num2)) {
                    
                        validInput = true;
                    }
                    else {

                    Console.WriteLine("Ju lutem mundohuni te shenoni nje numer te plot, ose decimal per numrin 2: ");
                }
            }
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} > {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} < {num2}");
            }
            else if (num2 == num1)
            {
                Console.WriteLine($"{num1} = {num2}");
            }
            else
            {
                Console.WriteLine("Sigurohuni qe te shenoni numra (ex: 1 ,1.5 etc)");
            }


        }
        public static void Semafori()
        {
            Console.WriteLine("Semafori");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();


            bool correctNum = false;
            int num = 0;

            while (!correctNum)
            {
                Console.WriteLine("Shenoni nje numer nga 1 deri ne 3.");
                if(int.TryParse(Console.ReadLine() , out num))
                {
                    if(num>0 && num < 4)
                    {
                        correctNum = true;
                        switch (num)
                        {
                            case 1: Console.WriteLine("E Kuqe.");break;
                            case 2: Console.WriteLine("E Portokall!");break;
                            case 3: Console.WriteLine("E Gjelber?");break;
                            default: Console.WriteLine("Something went wrong");break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please only input a number between 1 and 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Please only input a number between 1 and 3.");
                }

            }
        }
        public static void Search()
        {
            bool stayActive = true;
            List<string> list = new List<string>();

            string fjala_me_e_gjate="";
            string fjala_UNI = "Asnje Fjale nuk permban uni.";
            string UNI = "uni";






            Console.WriteLine("Krahaso fjalet");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();
            while (stayActive)
            {
                Console.Write("Sheno nje fjale: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }
                else if (input.Length < 4)
                {
                    continue;
                }
                else if (input.Equals("exit"))
                {
                    stayActive = false;
                }
                else
                {
                    list.Add(input);

                    if (input.Length > fjala_me_e_gjate.Length)
                    {
                        fjala_me_e_gjate = input;
                    }
                    else
                    {
                        continue;
                    }
                    if (input.Contains(UNI))
                    {
                        fjala_UNI = input;
                    }

                }

            }
            Console.WriteLine($"Fjala Me e gjate: {fjala_me_e_gjate}, \nFjala Uni: {fjala_UNI}");
        }
        public static void TabelaShumzimit()
        {
            Console.WriteLine("Tabela Shumzimit");
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}   ");
                }
                Console.WriteLine();
            }
        }
        public static void VitiBrishte()
        {
            int muaji =2; 
               int viti =2000;
            bool stayActive = true;
            bool eShkuar = true;
           

            while (stayActive)
            {
                Console.Write("Sheno mujin me nje numer nga 1 deri 12: ");
                if(int.TryParse(Console.ReadLine(), out muaji))
                {
                    if(muaji > 0 && muaji <= 12) { 
                    
                    stayActive = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Shenoni nje numer nga 1 deri ne 12! {EX: 8}");
                }
            }
            stayActive = true;
            while (stayActive)
            {
                Console.Write("Shenoni Vitin me kater shifra {EX: 1998}: ");
                if(int.TryParse(Console.ReadLine()  , out viti))
                {
                    
                    if (viti > 2030)
                    {
                        Console.WriteLine("Zgjedhni me pak se viti 2030.");
                        continue;
                    }
                    else if( viti < 1900)
                    {
                        Console.WriteLine("Zgjedhni me shume se viti 1900.");
                        continue;
                    }
                    else
                    {
                    stayActive=false;

                    }
                }
                else
                {
                    Console.WriteLine();
                }
            }

            switch (muaji) {

                case 1:
                    Console.WriteLine("Muaji Janar ka 31 dite");
                    break;
                case 2:
                    if((viti%2 == 0 && viti%100 != 0)||viti%400 == 0 ) {
                        
                        Console.WriteLine("Ky eshte vit i brishte dhe muaji shkurt ka 29 dite.");
                    }
                    else
                    {
                        Console.WriteLine("Muaji Shkurt ka 28 dite");
                    }
                    break;
                case 3:
                    Console.WriteLine("Muaji Mars ka 31 dite");
                    break;
                case 4:
                    Console.WriteLine("Muaji Prill ka 30 dite");
                    break;
                case 5:
                    Console.WriteLine("Muaji Maj ka 31 dite");
                    break;
                case 6:
                    Console.WriteLine("Muaji Qershore ka 30 dite");
                    break;
                case 7:
                    Console.WriteLine("Muaji Korrik ka 31 dite");
                    break;
                case 8:
                    Console.WriteLine("Muaji Gushte ka 31 dite");
                    break;
                case 9:
                    Console.WriteLine("Muaji Shtatore ka 30 dite");
                    break;
                case 10:
                    Console.WriteLine("Muaji Tetore ka 31 dite");
                    break;
                case 11:
                    Console.WriteLine("Muaji Nentore ka 30 dite");
                    break;
                case 12:
                    Console.WriteLine("Muaji Dhjetore ka 31 dite");
                    break;
                default:
                    Console.WriteLine("Something went wrong.....");
                    break;

            }

        }
    }
}
