using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObject2 : MonoBehaviour
{
    public Action<int, Action> testObjectTwo;
    public int Frame = 20;
    TestUpdateScheduler tus = new TestUpdateScheduler();
    void Awake()
    {
        testObjectTwo += tus.OnUpdateScheduler;
    }
    void Update()
    {
        //testObjectTwo(Frame, OnMethod);
    }
    public void OnMethod()
    {
        Debug.Log(this.name);
    }
}
