using System;
using System.Collections.Generic;
using Extantions;

namespace Abgabe_Thomas_Hummes_KB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> enemy = new Dictionary<string, double>() ;
            enemy.Add("Enemy1", 16);
            enemy.Add("Enemy2", 3);
            enemy.Add("Enemy3", 3);
            

            foreach (KeyValuePair<string, double> kvp in enemy)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }



            /*  List<int> enemyList = new List<int> { 1, 2, 3, 4, 5 };
              Console.WriteLine(string.Join(",", enemyList));
              */
              
            Console.ReadKey();
        }
    }
}
