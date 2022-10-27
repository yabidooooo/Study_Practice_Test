using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject3 : MonoBehaviour
{
    public int Frame = 30;

    void Start()
    {
        MyScheduler.Instance.AddSchedule(Frame, OnMethodThree);
    }

    public void OnMethodThree()
    {
        Debug.Log("³ª´Â 3¹ø");
    }
}
