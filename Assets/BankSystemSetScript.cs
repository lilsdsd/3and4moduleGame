using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BankSystemSetScript : MonoBehaviour
{

// When I want a really global variable what I do is to make a 
// static class to store this variables, like this:
    public static int BankMoney;
    
    void Start()
    {
        // This way every single script in my game could access this 
        // variable just writing:
        BankMoney = 20000;
    }
   // GlobalVariables.pathLength += SegmentLength;

    
    void Update()
    {
        
    }
}
