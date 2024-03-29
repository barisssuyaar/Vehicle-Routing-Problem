﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgorithm
{
    public static class Geography
    {
        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            double R = 6371000; 
            double dLat = (lat2 - lat1) / 180.0 * Math.PI;

            double dLon = (lon2 - lon1) / 180.0 * Math.PI;

            double a = Math.Sin(dLat / 2.0) * Math.Sin(dLat / 2.0) +
                    Math.Sin(dLon / 2.0) * Math.Sin(dLon / 2.0) * Math.Cos(lat1 / 180.0 * Math.PI) * Math.Cos(lat2 / 180.0 * Math.PI);
            double c = 2.0 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1.0 - a));
            return R * c;
        }

        public static string SwapCharacters(string value, int position1, int position2)
        {
            
           
            char[] array = value.ToCharArray(); 
            char temp = array[position1]; 
            array[position1] = array[position2];
            array[position2] = temp; 
            return new string(array); 
        }
    }
}