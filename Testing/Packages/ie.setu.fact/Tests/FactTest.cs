using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FactTest
{
    [Test]
    public void FactTestSimplePasses()
    {
        int[] input = { 4, 2, 8, 3, 9, 4, 10 };
        int[] output = Fact.fact(input);
        int[] expected = { 24, 2, 40320, 6, 362880, 24, 3628800 };

        CollectionAssert.AreEqual(expected, output);
    }

}

