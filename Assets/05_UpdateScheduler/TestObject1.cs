using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject1 : MonoBehaviour
{
    public int Frame = 10;

    void Start()
    {
        MyScheduler.Instance.AddSchedule(Frame, OnMethodOne);
    }

    public void OnMethodOne()
    {
        Debug.Log("³ª´Â 1¹ø");
    }
}
