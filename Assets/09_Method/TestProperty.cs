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
        Debug.Log("AgeInt �� : " + AgeInt);
        Debug.Log("Int �� : " + TestInt);
        AgeInt = 3;
        Debug.Log("AgeInt �� : " + AgeInt);
        Debug.Log("Int �� : " + TestInt);
        TestInt = 10;
        Debug.Log("AgeInt �� : " + AgeInt);
        Debug.Log("Int �� : " + TestInt);

        Debug.Log("AgeFloat �� : " + AgeFloat);
        Debug.Log("Float �� : " + TestFloat);
        AgeFloat = 1;
        Debug.Log("AgeFloat �� : " + AgeFloat);
        Debug.Log("Float �� : " + TestFloat); 
        TestFloat = 4;
        Debug.Log("AgeFloat �� : " + AgeFloat);
        Debug.Log("Float �� : " + TestFloat);
    }
}
