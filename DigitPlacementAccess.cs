using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitPlacementAccess : MonoBehaviour
{
    /*
    Created by Cody Rauh, 12.21.2020, (cc-by-4.0) commercial use allowed, please include in credits section of your Unity game/app.
    This script is designed to help the user access a single digit in within multi-digit number.

    Example:
    private int mathTest = 143;

    This script will allow the user to grab 1, 4 or 3 and access single digits of a number provided from another script.
    1 would be placed in the position of hundred as digitHundred, 4 would be placed in the position as digitTens, and
    3 would be placed placed in digitOnes.

    public int digitHundreds = 1;
    public int digitTens = 4;
    public int digitOnes = 3;
    */

    public int digitMillions;
    public int digitHundredThousands;
    public int digitTenThousands;
    public int digitThousands;
    public int digitHundreds;
    public int digitTens;
    public int digitOnes;

    //this will be the number provided by an external variable for breakdown into single digits.
    public int breakDownNumber;

    [SerializeField] private int totalLoopsProcessed;

    public void NumberDissection() 
    {
        //for testing purposes, comment out when not testing
        //currentNumberSize = mathTest;

        digitMillions= breakDownNumber / 1000000 %10;
        digitHundredThousands = breakDownNumber / 100000 % 10;
        digitTenThousands = breakDownNumber / 10000 % 10;
        digitThousands = breakDownNumber / 1000 % 10;
        digitHundreds = breakDownNumber / 100 %10;
        digitTens = breakDownNumber / 10 % 10;
        digitOnes = breakDownNumber % 10;

        //comment out when not testing to preserve resources, Debug.Log is an expensive operation for mobile devices.
       /* 
        Debug.Log("Millions Number ='s " + digitMillions);
        Debug.Log("HundredThousands Number ='s " + digitHundredThousands);
        Debug.Log("TenThousands Number ='s " + digitTenThousands);
        Debug.Log("Thousands Number ='s " + digitThousands);
        Debug.Log("Hundreds Number ='s " + digitHundreds);
        Debug.Log("Tens Number ='s " + digitTens);
        Debug.Log("Ones Number ='s " + digitOnes);
       */
    }
}
