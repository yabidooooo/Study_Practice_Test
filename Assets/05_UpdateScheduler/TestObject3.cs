using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject3 : MonoBehaviour
{
    public int Frame = 30;

    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            MyScheduler.Instance.AddSchedule(Frame, OnMethodThree);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            MyScheduler.Instance.RemoveSchedule(OnMethodThree);
        }
    }

    public void OnMethodThree()
    {
        Debug.Log("³ª´Â 3¹ø");
    }
}
