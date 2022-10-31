using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject2 : MonoBehaviour
{
    public int Frame = 20;

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            MyScheduler.Instance.AddSchedule(Frame, OnMethodTwo);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            MyScheduler.Instance.RemoveSchedule(OnMethodTwo);
        }
    }

    public void OnMethodTwo()
    {
        Debug.Log("³ª´Â 2¹ø");
    }
}
