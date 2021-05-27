using System;
using System.Collections.Generic;


namespace TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int n = 4;
            string[] arr = {"ACN", "DAU", "ADN", "DCU"};
            //string[] arr = {"ABN", "BDU", "CDU", "CAN", "DBU", "BDN"};
            //string[] arr = {"ADU", "BAC", "DCN"};


            //Tariff
            // A -> B = 10Units/KM
            // B -> C = 20Units/KM
            // C -> D = 40Units/KM
            // Input(x, y, z) - x : start, y - End, z - time(Normal: N, Untime: U)
            // If U -> 0.2 * totalTariff
            // Routes will be :  A -> B -> C -> D  OR D -> C -> B -> A;

            List<string> li = new List<string>(arr);
            List<string> Route = new List<string>() {"A", "B", "C", "D"};

            //validation
            int count;
            foreach(string s in li) {
                char[] charaters = s.ToCharArray();
                count = 0;
                foreach(char c in charaters) {
                    count ++;
                    if(count == 3) {
                        if(!(c == 'N') && !(c == 'U')) { 
                            Console.WriteLine("Invail Time of Travel");
                            return;
                        }
                    }
                    else {
                        if(!Route.Contains(Char.ToString(c))) {
                            Console.WriteLine("Invalid Location"); 
                            return; 
                        } 
                    }
                }
            }

            //Logic
            
            int sum, diff;
            double rupee = 0;

            foreach(string item in li) {
                
                char[] getSplitString = item.ToCharArray();    
                //Console.WriteLine(string.Join(", ", getSplitString));
                
                sum = Route.IndexOf(Char.ToString(getSplitString[0])) + Route.IndexOf(Char.ToString(getSplitString[1])) + 1;
                diff = sum - 2;

                //Console.WriteLine(diff);

                if(diff == 0) {
                    if(getSplitString[2] == 'U') rupee += 10 * 1.2;
                    else  rupee += 10;
                }

                else if(diff == 1) {
                    if(getSplitString[2] == 'U') rupee +=  20 * 1.2;
                    else rupee += 30;
                }
                else if(diff == 2) {
                    if(getSplitString[2] == 'U') rupee += 70 * 1.2;
                    else rupee += 70;
                }
                else if(diff == 3) {
                    if(getSplitString[2] == 'U') rupee += 60 * 1.2;
                    else rupee += 60;
                }

                else if(diff == 4) {
                    if(getSplitString[2] == 'U') rupee += 40 * 1.2;
                    else rupee += 40;
                }

                //Console.WriteLine(rupee);
            }

            Console.WriteLine("The car has taken {0} trips and has collected total amount of {1} rupee", li.Count, rupee);
        

        }
    }
}
