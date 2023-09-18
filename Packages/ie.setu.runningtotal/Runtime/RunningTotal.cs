using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningTotal : MonoBehaviour
{
   public static int[] runningTotal(int[] t_numbers)
    {
        int[] runningTotal = new int[t_numbers.Length];
        runningTotal[0] = t_numbers[0];

        for (int i = 1; i < t_numbers.Length; i++)
        {
            int addedInt = t_numbers[i];

            for (int o = 0; o < i; o++)
            {
                addedInt = addedInt + t_numbers[o];
                runningTotal[i] = addedInt;
            }
        }

        return runningTotal;
    }
}
