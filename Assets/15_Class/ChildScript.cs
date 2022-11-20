using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : ParentScript
{
    public int one = 1;

    void Start()
    {
        zero = 1;

        Debug.Log("Child : " + zero + Time.time);
        Debug.Log("Child : " + one + Time.time);
    }

    void Update()
    {
        
    }
}
