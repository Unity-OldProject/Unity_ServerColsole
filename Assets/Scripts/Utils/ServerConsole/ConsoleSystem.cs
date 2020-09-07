using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleSystem : MonoBehaviour
{


    public static void Run(string cmd, bool any)
    {
        //Debug.Log("Your cmd : " + cmd);
        Console.Write( "Your cmd : " + cmd + "\n\n" );
    }
}
