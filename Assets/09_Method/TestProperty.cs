using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProperty : MonoBehaviour
{
    private int TestInt = 0;
    public int AgeInt
    {
        get
        {
            return TestInt;
        }
        set
        {
            TestInt = value;
        }
    }


    private float TestFloat;
    public float AgeFloat
    {
        get
        {
            return TestFloat;
        }
        set
        {
            TestFloat = 5.5f;
        }
    }


    private void Start()
    {
        Debug.Log("AgeInt 전 : " + AgeInt);
        Debug.Log("Int 전 : " + TestInt);
        AgeInt = 3;
        Debug.Log("AgeInt 중 : " + AgeInt);
        Debug.Log("Int 중 : " + TestInt);
        TestInt = 10;
        Debug.Log("AgeInt 후 : " + AgeInt);
        Debug.Log("Int 후 : " + TestInt);

        Debug.Log("AgeFloat 전 : " + AgeFloat);
        Debug.Log("Float 전 : " + TestFloat);
        AgeFloat = 1;
        Debug.Log("AgeFloat 중 : " + AgeFloat);
        Debug.Log("Float 중 : " + TestFloat); 
        TestFloat = 4;
        Debug.Log("AgeFloat 후 : " + AgeFloat);
        Debug.Log("Float 후 : " + TestFloat);
    }
}
