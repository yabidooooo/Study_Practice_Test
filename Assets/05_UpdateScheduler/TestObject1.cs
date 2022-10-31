using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject1 : MonoBehaviour
{
    public int Frame = 10;

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MyScheduler.Instance.AddSchedule(Frame, OnMethodOne);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MyScheduler.Instance.RemoveSchedule(OnMethodOne);
        }
    }

    public void OnMethodOne()
    {
        Debug.Log("³ª´Â 1¹ø");
    }
}
