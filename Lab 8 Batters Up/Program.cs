using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_Batters_Up
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            { 
            Console.WriteLine("Welcome to the batting calculator. Please enter the number of batters.");
            int Batters = int.Parse(Console.ReadLine());
           

            int[][] BatterArray = new int[Batters][];
            int AtBat=0;
            for (int i = 0; i < Batters; i++)
            {
                Console.WriteLine("Please enter the number of times at bat.");
                AtBat = int.Parse(Console.ReadLine());
                BatterArray[i] = new int[AtBat];
                
            }

            for (int r = 0; r < Batters; r++)
            {
                for (int Q = 0; Q < BatterArray[r].Length; Q++)
                {
                    Console.WriteLine($"Player # {r+1} Result {Q+1}");
                    BatterArray[r][Q] = int.Parse(Console.ReadLine());
                    
                }
            }

                for (int R = 0; R < Batters; R++)
                {
                    int sum = 0;
                    double Slugging = 0;
                    int count = 0;
                    double BA = 0;
                    for (int Q = 0; Q < BatterArray[R].Length; Q++)
                    {
                        if (BatterArray[R][Q] > 0)
                        {
                            count++;

                        }
                        BA = (double)count / AtBat;
                        sum = sum + BatterArray[R][Q];
                        Slugging = (double)sum / AtBat;




                    }
                    Console.WriteLine("Slugging Percentage " + (Slugging)); Console.WriteLine("Batting average " + (BA));
                }
                Console.WriteLine("Would you like to calculate more stats? (Y/N)");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
        }
    }
}
