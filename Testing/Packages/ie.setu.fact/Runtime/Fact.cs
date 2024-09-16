using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fact : MonoBehaviour
{
   public static int[] fact(int[] t_numbers)
    {
        int[] factorialNumbers = new int[t_numbers.Length];

        for (int i = 0; i < t_numbers.Length; i++)
        {
            int factiorial = t_numbers[i];
            factorialNumbers[i] = t_numbers[i];

            while( factiorial > 1 ) 
            {
                factiorial--;
                factorialNumbers[i] *= factiorial;
            }
        }
        return factorialNumbers;
    }
}
