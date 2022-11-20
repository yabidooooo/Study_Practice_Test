using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenScript : ChildScript
{
    void Start()
    {
        zero = 2;
        one = 3;

        Debug.Log("Children : " + zero + Time.time);
        Debug.Log("Children : " + one + Time.time);
    }

    void Update()
    {
        
    }
}
