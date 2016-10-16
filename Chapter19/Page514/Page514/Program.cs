﻿using System;
using System.Linq;

class Program
{
   static void Main()
   {
      int[] intArray = new int[] { 3, 4, 5, 6, 7, 9 };

      var count1    = Enumerable.Count( intArray );            // Method syntax
      var firstNum1 = Enumerable.First( intArray );            // Method syntax

      var count2    = intArray.Count();                        // Extension syntax
      var firstNum2 = intArray.First();                        // Extension syntax

      Console.WriteLine( "Count: {0}, FirstNumber: {1}", count1, firstNum1 );
      Console.WriteLine( "Count: {0}, FirstNumber: {1}", count2, firstNum2 );
   }
}

