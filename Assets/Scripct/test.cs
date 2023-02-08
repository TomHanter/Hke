using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    private int number = 5;
    private double doubleNumber = 314.15653453535f;
    private float flatNymber = 1.3453535353533f;
    private string strochka = "Hello";
    private bool flag = true;
    private bool flag2 = false;
    
    
    
    
    void Start()
    {
       /* print(number);
        print(strochka);
        print(flag);
        print(flag2);
        print(flatNymber);
        print(doubleNumber); */
        
        if (flag)
        {
            print("flag is true");
        }
        else
        {
            print("flag is not true");
        }

        if (number >10)
        {
            print("number >10");
        }
        else if(number ==10)
        {
            print("number =10");
        }
        else
        {
            print("number <10");
        }
        
        print(this.gameObject.name);

        gameObject.name = "NewName";
        print(this.gameObject.name);
    }
    
    
}
