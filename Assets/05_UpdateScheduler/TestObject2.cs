using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject2 : MonoBehaviour
{
    public int Frame = 20;

    void Start()
    {
        TestUpdateScheduler.Instance.RegisterList(Frame, OnMethodTwo);
    }

    public void OnMethodTwo()
    {
        Debug.Log("³ª´Â 2¹ø");
    }
}
