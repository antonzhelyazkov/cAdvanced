﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace parkingLot
{
    class parkingLot
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (!input.Equals("END"))
            {
                var inputParams = Regex.Split(input, ", ");

                if (inputParams[0].Equals("IN"))
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    if (parking.Contains(inputParams[1]))
                    {
                        parking.Remove(inputParams[1]);
                    }
                }

                input = Console.ReadLine();
            }

            if (parking.Count() > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
