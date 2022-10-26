using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject3 : MonoBehaviour
{
    public Action<int, Action> testObjectThree;
    public int Frame = 30;
    TestUpdateScheduler tus = new TestUpdateScheduler();
    void Awake()
    {
        testObjectThree += tus.OnUpdateScheduler;
    }
    void Update()
    {
        //testObjectThree(Frame, OnMethod);
    }
    public void OnMethod()
    {
        Debug.Log(this.name);   
    }
}
