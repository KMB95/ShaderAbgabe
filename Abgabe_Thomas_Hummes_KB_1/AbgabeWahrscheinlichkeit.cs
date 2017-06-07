﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Extantions
{
   /* public class Dictionary
    {
        private string _key;
        private double _rel;
        private double _wahrsch;

        public Dictionary()
        {
        }

        public Dictionary(string key, double rel, double wahrsch)
        {
            Key = key;
            Rel = rel;
            Wahrsch = wahrsch;
        }

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public double Rel
        {
            get { return _rel; }
            set { _rel = value; }
        }

        public double Wahrsch
        {
            get { return _wahrsch; }
            set { _wahrsch = value; }
        }
        */
        public static class  Abgabe_Wahrscheinlichkeit
    {
        public static T First<T>(this IList<T> x) // this List nur mit static 
        {

            return x[0];
        }

        // Generic constraint
        public static bool FirstEqual<T>(this IList<T> x, T value) where T : IComparable
        {

            return x[0].CompareTo(value) == 0;
        }


        public static double BerechnungWahrscheinlichkeit<K>(this Dictionary<string, double> l)
        {
            double sumAll =l.Sum(x => x. Value);
            List<double> relativList = new List<double> { };
          foreach (KeyValuePair<string, double> k in l)
            {
                relativList = sumAll/k; //-> Double Wert des einzelen key eintrags
            }


            // Debug: Liste ist leer;
            return sumAll;
        }

        


        public static void Bubblesort<T>(this IList<T> x) where T : IComparable
        {
            for (int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < x.Count - 1; j++)
                {
                    if (x[j].CompareTo(x[j + 1]) >= 1) // x[j]CompareTo(x)
                    {
                        T temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }

                }
            }

        }
    }

}

