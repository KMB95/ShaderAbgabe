using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using Extantions;

namespace Abgabe_Thomas_Hummes_KB_1
{

    public class List 
    {
        private string Name;
        private double Count;
        private double Plausibility;

        public List(string name, double count, double plausibility)
        {
            Name = name;
            Count = count;
            Plausibility = plausibility;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          /*  Dictionary<string, double> enemy = new Dictionary<string, double>() ;
            
            enemy.Add("Enemy1", 16);
            enemy.Add("Enemy2", 3);
            enemy.Add("Enemy1", 3);
            //Debug(SystemException Dictionary<> ist leer, hat den gleichen Key 2 x verwendet);
            if (enemy.Count<=0)
            {
                Console.Write("Dictionary is empty");
            }
            else if (enemy.Comparer == null)
                {
                    Console.Write("You have 2 identical Keys");
                }
            */
            List<int> ListEntry = new List<int>();
            List<List> enmy= new List();
            List<string>nameEnemyList = new List<string>();
           /* int i = 0;
            foreach (KeyValuePair<string, double> kvp in enemy)
            {
                
                Console.WriteLine("Key = {0}, Value = {1}" + " || Wahrscheinlichkeit: " + enemyList[i]+ " %", kvp.Key, kvp.Value );
                i += 1;
            }

            */
            for (int i = 0; i < wahrenemyList.Count; i++)
            {
                Console.WriteLine( );

            }
             
              
              
              
            Console.ReadKey();
        }
    }
}
